using ProyectoTaller_Lugo_Arias.Models;
using ProyectoTaller_Lugo_Arias.Repositorio;
using ProyectoTaller_Lugo_Arias.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoTaller_Lugo_Arias.Presenters
{
    public class ReservaPresenter
    {
        private IReservasView view;
        private IReservaRepositorio reservaRepositorio;
        private BindingSource reservasBindingSource;
        private IEnumerable<ReservaModel> reservasList;

        private IClienteRepositorio clienteRepositorio;
        private IHabitacionRepositorio habitacionRepositorio;
        private IFormaPagoRepositorio formaPagoRepositorio;
        private ITipoHabitacionRepositorio tipoHabitacionRepositorio;
       // private BindingSource clientesBusquedaBindingSource;
        private BindingSource habitacionesDisponiblesBindingSource;

        private BindingSource reservasBindingSourceActivas;
        private IEnumerable<ReservaModel> reservasListActivas;
        private BindingSource reservasBindingSourcePendientes;
        private IEnumerable<ReservaModel> reservasListPendientes;
        private BindingSource reservasBindingSourceFinalizadas;
        private IEnumerable<ReservaModel> reservasListFinalizadas;

        public ReservaPresenter(IReservasView view, IReservaRepositorio reservaRepositorio,
            IFormaPagoRepositorio formaPagoRepositorio, ITipoHabitacionRepositorio tipoHabitacionRepositorio,
            IHabitacionRepositorio habitacionesRepositorio, IClienteRepositorio clienteRepositorio)
        {
            this.reservasBindingSource = new BindingSource();
            this.reservasBindingSourceActivas = new BindingSource();
            this.reservasBindingSourcePendientes = new BindingSource();
            this.reservasBindingSourceFinalizadas = new BindingSource();
           // this.clientesBusquedaBindingSource = new BindingSource();
            this.habitacionesDisponiblesBindingSource = new BindingSource();

            this.view = view;
            this.reservaRepositorio = reservaRepositorio;
            this.clienteRepositorio = clienteRepositorio;
            this.habitacionRepositorio = habitacionesRepositorio;
            this.formaPagoRepositorio = formaPagoRepositorio;
            this.tipoHabitacionRepositorio = tipoHabitacionRepositorio;

            // Suscribir eventos
            this.view.BuscarEvent += BuscarReserva;
            this.view.AgregarEvent += AgregarReserva;
            this.view.EditarEvent += LoadSelectedReservaToEdit;
            this.view.EliminarEvent += DeleteSelectedReserva;
            this.view.GuardarEvent += GuardarReserva;
            this.view.CancelarEvent += CancelarAction;
            this.view.CriteriosBusquedaHabitacionChanged += LoadHabitacionesDisponibles;
            this.view.HabitacionSeleccionadaChanged += CalculateMontoTotal;
            //this.view.ClienteBusquedaChanged += SearchClient;
            //this.view.ClienteSeleccionadoEvent += AssignSelectedClient;

            // Orígenes de datos
            this.view.SetReservaListBindingSource(reservasBindingSource);
            this.view.SetReservasListBindingSourceActivas(reservasBindingSourceActivas);
            this.view.SetReservasListBindingSourcePendientes(reservasBindingSourcePendientes);
            this.view.SetReservasListBindingSourceFinalizadas(reservasBindingSourceFinalizadas);
          //  this.view.SetClientesBusquedaBindingSource(clientesBusquedaBindingSource);
            this.view.SetHabitacionesDisponiblesListComboBox(habitacionesDisponiblesBindingSource);

            // Cargar datos
            LoadAllReservasList();
            this.view.SetPagosListComboBox(formaPagoRepositorio.GetAll());
            this.view.SetTiposHabitacionListComboBox(tipoHabitacionRepositorio.GetAll());
            this.view.SetClientesListComboBox(clienteRepositorio.GetAll());

            this.view.Show();
        }

        private void LoadAllReservasList()
        {
            reservasList = reservaRepositorio.GetAll();
            reservasBindingSource.DataSource = reservasList;

            reservasListActivas = reservaRepositorio.GetAllActivas();
            reservasBindingSourceActivas.DataSource = reservasListActivas;

            reservasListFinalizadas = reservaRepositorio.GetAllFinalizadas();
            reservasBindingSourceFinalizadas.DataSource = reservasListFinalizadas;

            reservasListPendientes = reservaRepositorio.GetAllPendientes();
            reservasBindingSourcePendientes.DataSource = reservasListPendientes;
        }

        private void CancelarAction(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void CleanViewFields()
        {
            view.Id_cliente = 0;
            view.Cant_personas = 0;
            view.Id_tipo = 0;
            view.Monto_total = 0m;
            view.Id_pago = 1;
            view.Estado = string.Empty;
            view.IsEditar = false;
            view.IsNuevo = true;
        }
        

        private void GuardarReserva(object sender, EventArgs e)
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
                    Id_piso = view.Id_piso,
                    Id_pago = view.Id_pago,
                    Cant_personas = view.Cant_personas,
                    Id_tipo = view.Id_tipo
                };

                reserva.Monto_total = reservaRepositorio.CalcularMontoTotal(reserva.Nro_habitacion, reserva.Fecha_ingreso, reserva.Fecha_salida);
                reserva.CalcularEstado();

                if (reserva.Monto_total <= 0)
                    throw new Exception("El monto total no puede ser cero o negativo.");

                if (view.IsEditar)
                {
                    // Actualizar reserva existente
                    reservaRepositorio.Edit(reserva);
                    view.Mensaje = "Reserva actualizada correctamente.";
                }
                else
                {
                    // Agregar nueva reserva
                    reservaRepositorio.Add(reserva);

                    // Cambiar el estado de la habitación a "Ocupada" (id_estado = 3)
                    habitacionRepositorio.ActualizarEstado(reserva.Nro_habitacion, reserva.Id_piso, 3);

                    view.Mensaje = "Reserva agregada correctamente.";
                }

                // Refrescar listas y DataGridViews
                LoadAllReservasList();
                // Si tenés un método similar para refrescar habitaciones, llamalo aquí
                // Por ejemplo: LoadHabitacionesDisponibles(null, EventArgs.Empty);

                CleanViewFields();
                view.IsNuevo = true;
            }
            catch (Exception ex)
            {
                view.IsNuevo = false;
                view.Mensaje = $"Error al guardar la reserva: {ex.Message}";
            }
        } 
        
        

        private void DeleteSelectedReserva(object sender, EventArgs e)
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
                view.Mensaje = "Ocurrió un error, no se pudo eliminar la reserva";
            }
           

        }

        private void LoadSelectedReservaToEdit(object sender, EventArgs e)
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
            view.Id_tipo = reserva.Id_tipo;
            view.Estado = reserva.Estado;
            view.IsEditar = true;
        }

        private void AgregarReserva(object sender, EventArgs e)
        {
            view.IsEditar = false;
        }

        private void BuscarReserva(object sender, EventArgs e)
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

        // --- HABITACIONES Y CÁLCULO ---
        private void LoadHabitacionesDisponibles(object sender, EventArgs e)
        {
            try
            {
                if (view.Cant_personas > 0 && view.Fecha_salida > view.Fecha_ingreso)
                {
                    var disponibles = reservaRepositorio.GetHabitacionesDisponibles(
                        view.Id_tipo, // <--- ahora usa Id_tipo
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
                    decimal monto = reservaRepositorio.CalcularMontoTotal(
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


