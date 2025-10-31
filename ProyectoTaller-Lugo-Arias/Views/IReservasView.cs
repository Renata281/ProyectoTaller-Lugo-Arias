using ProyectoTaller_Lugo_Arias.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller_Lugo_Arias.Views
{
    public interface IReservasView
    {
        //campos
        string Nro_reserva { get; set; }
        DateTime Fecha_ingreso { get; set; }
        DateTime Fecha_salida { get; set; }
        decimal Monto_total { get; set; }
        int Id_cliente { get; set; }
        int Nro_habitacion { get; set; }
        int Id_piso { get; set; }
        int Id_pago { get; set; }
        int Cant_personas { get; set; } 
        string Estado { get; set; }
        int Id_tipo { get; set; }

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

        void SetClientesListComboBox(IEnumerable<ClienteModel> clienteList);

        // Nuevo evento: Se dispara cuando cambia la selección de la pestaña
        event EventHandler SelectedTabChanged;

        // Nuevo evento: Se dispara al cambiar fechas, tipo o cantidad de personas
        event EventHandler CriteriosBusquedaHabitacionChanged;

        // Nuevo evento: Se dispara al seleccionar una habitación para recalcular monto
        event EventHandler HabitacionSeleccionadaChanged;
        // Propiedad esencial para la lógica de refresco (Índice de Tab Activo)
        int TabIndex { get; }
        void Show();
        void SetHabitacionesDisponiblesListComboBox(BindingSource habitacionesDisponiblesBindingSource);
    }

}
