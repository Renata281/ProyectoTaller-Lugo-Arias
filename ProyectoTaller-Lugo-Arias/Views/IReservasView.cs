using ProyectoTaller_Lugo_Arias.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller_Lugo_Arias.Views
{
    public interface IReservasView
    {
        //campos
        string Nro_reserva { get; set; }
        DateTime Fecha_ingreso { get; set; }
        DateTime Fecha_salida { get; set; }
        float Monto_total { get; set; }
        int Id_cliente { get; set; }
        int Nro_habitacion { get; set; }
        int I_piso { get; set; }
        int Id_pago { get; set; }
        int Cant_personas { get; set; } 
        string Estado { get; set; }
        string Tipo { get; set; }

        string Buscar { get; set; }
        bool IsEditar { get; set; }
        bool IsNuevo { get; set; }
        string Mensaje { get; set; }

        //eventos
        event EventHandler BuscarEvent;
        event EventHandler AgregarEvent;
        event EventHandler EditarEvent;
        event EventHandler EliminarEvent;
        event EventHandler GuardarEvent;
        event EventHandler CancelarEvent;

        void SetReservaListBindingSource(BindingSource reservasBindingSource);
        void SetReservasListBindingSourceActivas(BindingSource reservasBindingSource);
        void SetReservasListBindingSourceFinalizadas(BindingSource reservasBindingSource);
        void SetReservasListBindingSourcePendientes(BindingSource reservasBindingSource);


        void SetPagosListComboBox(IEnumerable<FormaPagoModel>pagoList);
        void SetTiposHabitacionListComboBox(IEnumerable<TipoHabitacionModel> tipoHabitacionList);

        // Nuevo evento: Se dispara cuando cambia la selección de la pestaña
        event EventHandler SelectedTabChanged;

        // Nuevo evento: Se dispara al cambiar fechas, tipo o cantidad de personas
        event EventHandler CriteriosBusquedaHabitacionChanged;

        // Nuevo evento: Se dispara al seleccionar una habitación para recalcular monto
        event EventHandler HabitacionSeleccionadaChanged;
        // Propiedad esencial para la lógica de refresco (Índice de Tab Activo)
        int TabIndex { get; }

        // Campo de entrada de texto para la búsqueda
        string ClienteBusqueda { get; set; }

        // El ID del cliente que será asociado a la reserva (Necesario para el Repositorio)
        int Id_cliente_Seleccionado { get; set; }

        // Fuente de datos para el control que mostrará los resultados de la búsqueda de clientes
        void SetClientesBusquedaBindingSource(BindingSource clienteBindingSource);

        // Nuevo evento: Se dispara cuando el usuario cambia el texto en el TextBox de búsqueda
        event EventHandler ClienteBusquedaChanged;

        // Nuevo evento: Se dispara cuando el usuario selecciona un cliente de la lista de resultados
        event EventHandler ClienteSeleccionadoEvent;

        // conecta la interfaz de usuario con una fuente de datos
        void Show();
        void SetHabitacionesDisponiblesListComboBox(BindingSource habitacionesDisponiblesBindingSource);
    }

}
