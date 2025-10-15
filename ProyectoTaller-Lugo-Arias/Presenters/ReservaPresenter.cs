using ProyectoTaller_Lugo_Arias.Models;
using ProyectoTaller_Lugo_Arias.Repositorio;
using ProyectoTaller_Lugo_Arias.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller_Lugo_Arias.Presenters
{
    public class ReservaPresenter
    {
        //campos
        private IReservasView view;
        private IReservaRepositorio reservaRepositorio;
        private BindingSource reservasBindingSource;
        private IEnumerable<ReservaModel> reservasList;

        private IClienteRepositorio clienteRepositorio;
        private IHabitacionRepositorio habitacionRepositorio;
        private IFormaPagoRepositorio formaPagoRepositorio;
        private ITipoHabitacionRepositorio tipoHabitacionRepositorio;
        private BindingSource clientesBusquedaBindingSource;
        private BindingSource habitacionesDisponiblesBindingSource;

        private BindingSource reservasBindingSourceActivas;
        private IEnumerable<ReservaModel> reservasListActivas;
        private BindingSource reservasBindingSourcePendientes;
        private IEnumerable<ReservaModel> reservasListPendientes;
        private BindingSource reservasBindingSourceFinalizadas;
        private IEnumerable<ReservaModel> reservasListFinalizadas;


        public ReservaPresenter(IReservasView view, IReservaRepositorio reservaRepositorio, IFormaPagoRepositorio formaPagoRepositorio, ITipoHabitacionRepositorio tipoHabitacionRepositorio, IHabitacionRepositorio habitacionesRepositorio, IClienteRepositorio clienteRepositorio)
        {

            this.reservasBindingSource = new BindingSource();
            this.reservasBindingSourceActivas = new BindingSource();
            this.reservasBindingSourcePendientes = new BindingSource();
            this.reservasBindingSourceFinalizadas = new BindingSource();
            this.clientesBusquedaBindingSource = new BindingSource();
            this.habitacionesDisponiblesBindingSource = new BindingSource();

            this.view = view;
            this.reservaRepositorio = reservaRepositorio;
            this.clienteRepositorio = clienteRepositorio;
            this.habitacionRepositorio = habitacionesRepositorio;
            this.formaPagoRepositorio = formaPagoRepositorio;
            this.tipoHabitacionRepositorio = tipoHabitacionRepositorio;

            // suscribir eventos de la vista a los manejadores de eventos
            this.view.BuscarEvent += BuscarReserva;
            this.view.AgregarEvent += AgregarReserva;
            this.view.EditarEvent += LoadSelectedReservaToEdit;
            this.view.EliminarEvent += DeleteSelectedReserva;
            this.view.GuardarEvent += GuardarReserva;
            this.view.CancelarEvent += CancelarAction;

            //establecer el origen de datos del enlace
            this.view.SetReservaListBindingSource(reservasBindingSource);
            this.view.SetReservasListBindingSourceActivas(reservasBindingSourceActivas);
            this.view.SetReservasListBindingSourcePendientes(reservasBindingSourcePendientes);
            this.view.SetReservasListBindingSourceFinalizadas(reservasBindingSourceFinalizadas);
            this.view.SetClientesBusquedaBindingSource(clientesBusquedaBindingSource);
            this.view.SetHabitacionesDisponiblesListComboBox(habitacionesDisponiblesBindingSource);
            //cargar datos de la tabla empleados
            LoadAllReservasList();

            this.view.SetPagosListComboBox(formaPagoRepositorio.GetAll());
            this.view.SetTiposHabitacionListComboBox(tipoHabitacionRepositorio.GetAll());

            //mostrar la vista
            this.view.Show();
        }

        private void LoadAllReservasList()
        {
            reservasList = reservaRepositorio.GetAll();
            reservasBindingSource.DataSource = reservasList; //establece el origen de datos del enlace

            reservasListActivas = reservaRepositorio.GetAllActivas();
            reservasBindingSourceActivas.DataSource = reservasListActivas; 
            reservasListFinalizadas = reservaRepositorio.GetAllFinalizadas();
            reservasBindingSourceFinalizadas.DataSource = reservasListFinalizadas;
            reservasListPendientes = reservaRepositorio.GetAllPendientes();
            reservasBindingSourcePendientes.DataSource = reservasListPendientes;

        }

        private void CancelarAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void CleanViewFields()
        {
            view.Id_cliente = 0;
            view.Cant_personas = 0;
            view.Tipo = " ";
            view.Monto_total = 0;
            view.Id_pago = 1;
            view.Tipo = string.Empty;
            view.Estado = string.Empty;
            view.IsEditar = false;
            view.IsNuevo = true;

        }

        private void GuardarReserva(object? sender, EventArgs e)
        {
            try
            {
                var reserva = new ReservaModel
                {
                    Nro_reserva = string.IsNullOrEmpty(view.Nro_reserva) ? 0 : Convert.ToInt32(view.Nro_reserva),
                    Fecha_ingreso = view.Fecha_ingreso,
                    Fecha_salida = view.Fecha_salida,
                    Id_cliente = view.Id_cliente,
                    Nro_habitacion = view.Nro_habitacion,
                    Id_pago = view.Id_pago,
                    Cant_personas = view.Cant_personas,
                };

                // Calcular monto y estado
                reserva.Monto_total = reservaRepositorio.CalcularMontoTotal(reserva.Nro_habitacion, reserva.Fecha_ingreso, reserva.Fecha_salida);
                reserva.CalcularEstado();

                if (reserva.Monto_total <= 0)
                    throw new Exception("El monto total no puede ser cero o negativo.");

                if (view.IsEditar)
                {
                    reservaRepositorio.Edit(reserva);
                    view.Mensaje = "Reserva actualizada correctamente.";
                }
                else
                {
                    reservaRepositorio.Add(reserva);
                    view.Mensaje = "Reserva agregada correctamente.";
                }

                view.IsNuevo = true;
                LoadAllReservasList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsNuevo = false;
                view.Mensaje = $"Error al guardar la reserva: {ex.Message}";
            }
        }

        private void DeleteSelectedReserva(object? sender, EventArgs e)
        {
            try
            {
                var reserva = (ReservaModel)reservasBindingSource.Current;
                reservaRepositorio.Delete(reserva.Nro_reserva);
                view.IsNuevo = true;
                view.Mensaje = "Reserva eliminada correctamente";
                LoadAllReservasList();
            }
            catch (Exception ex)
            {
                view.IsNuevo = false;
                view.Mensaje = "Ocurrio un error, no se pudo eliminar la reserva";
            }
        }

        private void LoadSelectedReservaToEdit(object? sender, EventArgs e)
        {
            var reserva = (ReservaModel)reservasBindingSource.Current;

            view.Nro_reserva = reserva.Nro_reserva.ToString();
            view.Fecha_ingreso = reserva.Fecha_ingreso;
            view.Fecha_salida = reserva.Fecha_salida;
            view.Monto_total = reserva.Monto_total;
            view.Id_cliente = reserva.Id_cliente;
            view.Nro_habitacion = reserva.Nro_habitacion;
            view.Id_pago = reserva.Id_pago;
            view.Cant_personas = reserva.Cant_personas;
            view.Estado = reserva.Estado;
            view.IsEditar = true;
        }

        private void AgregarReserva(object? sender, EventArgs e)
        {
            view.IsEditar = false;
        }

        private void BuscarReserva(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.Buscar);

            if (!emptyValue)
            {
                reservasList = reservaRepositorio.GetByValue(this.view.Buscar);
            }
            else
            {
                reservasList = reservaRepositorio.GetAll();
            }

            reservasBindingSource.DataSource = reservasList;
            
        }

        private void MapReservaToView(ReservaModel reserva)
        {
            if (reserva == null) return;
            this.view.Nro_reserva = reserva.Nro_reserva.ToString();
            this.view.Fecha_ingreso = reserva.Fecha_ingreso;
            this.view.Fecha_salida = reserva.Fecha_salida;
            this.view.Monto_total = reserva.Monto_total;
            this.view.Id_cliente = reserva.Id_cliente;
            this.view.Nro_habitacion = reserva.Nro_habitacion;
            this.view.Id_pago = reserva.Id_pago;
            this.view.Cant_personas = reserva.Cant_personas;
            this.view.Estado = reserva.Estado;
        }

        private ReservaModel MapViewToReserva()
        {
            return new ReservaModel
            {
                Nro_reserva = int.TryParse(view.Nro_reserva, out int nro) ? nro : 0,
                Fecha_ingreso = view.Fecha_ingreso,
                Fecha_salida = view.Fecha_salida,
                Monto_total = view.Monto_total,
                Id_cliente = view.Id_cliente,
                Nro_habitacion = view.Nro_habitacion,
                Id_pago = view.Id_pago,
                Cant_personas = view.Cant_personas,
                Estado = view.Estado
            };
        }

             // --- LÓGICA DE CLIENTES ---
        
        private void SearchClient(object sender, EventArgs e)
        {
            string valorBusqueda = view.ClienteBusqueda;
            
            if (!string.IsNullOrWhiteSpace(valorBusqueda) && valorBusqueda.Length >= 3)
            {
                try
                {
                    var clientes = clienteRepositorio.GetByValue(valorBusqueda); 
                    clientesBusquedaBindingSource.DataSource = clientes;
                }
                catch (Exception ex)
                {
                    view.Mensaje = "Error buscando clientes: " + ex.Message;
                }
            }
            else
            {
                clientesBusquedaBindingSource.DataSource = null;
            }
        }

        private void AssignSelectedClient(object sender, EventArgs e)
        {
            // Asume que la vista actualiza view.Id_cliente_Seleccionado al seleccionar un cliente
            int idSeleccionado = view.Id_cliente_Seleccionado;
            
            if (idSeleccionado > 0)
            {
                view.Id_cliente = idSeleccionado; 
                view.Mensaje = $"Cliente ID {idSeleccionado} asignado.";
                clientesBusquedaBindingSource.DataSource = null; 
            }
        }

        // --- LÓGICA DE HABITACIONES Y CÁLCULO ---
        
        private void LoadHabitacionesDisponibles(object sender, EventArgs e)
        {
            try
            {
                if (view.Cant_personas > 0 && view.Fecha_salida > view.Fecha_ingreso)
                {
                    // Usa el método del repositorio con los criterios de la vista
                    var disponibles = reservaRepositorio.GetHabitacionesDisponibles(
                        view.Tipo, // Asumo que esta propiedad existe en IReservasView
                        view.Cant_personas,
                        view.Fecha_ingreso,
                        view.Fecha_salida
                    );
                    habitacionesDisponiblesBindingSource.DataSource = disponibles.ToList();
                    
                    CalculateMontoTotal(this, EventArgs.Empty); 
                }
            }
            catch (Exception ex)
            {
                view.Mensaje = "Error al buscar habitaciones: " + ex.Message;
            }
        }

        private void CalculateMontoTotal(object sender, EventArgs e)
        {
            try
            {
                if (view.Nro_habitacion > 0)
                {
                    float monto = reservaRepositorio.CalcularMontoTotal( 
                        view.Nro_habitacion,
                        view.Fecha_ingreso,
                        view.Fecha_salida
                    );
                    view.Monto_total = monto;
                }
                else
                {
                    view.Monto_total = 0;
                }
            }
            catch (Exception ex)
            {
                view.Mensaje = "Error al calcular el monto: " + ex.Message;
                view.Monto_total = 0;
            }
        }
        }
    }


