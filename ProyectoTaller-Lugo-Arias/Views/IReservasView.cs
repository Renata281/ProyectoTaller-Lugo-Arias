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
        string nro_reserva { get; set; }
        DateTime fecha_ingreso { get; set; }
        DateTime fecha_salida { get; set; }
        decimal monto_total { get; set; }
        int id_cliente { get; set; }
        int nro_habitacion { get; set; }
        int id_piso { get; set; }
        int id_pago { get; set; }
        string descripcion { get; set; } //forma de pago

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

        //void SetClientesListComboBox(IEnumerable<ClienteModel> clienteList);
        //void SetHabitacionesListComboBox(IEnumerable<HabitacionModel> habitacionList);
        //void SetPagosListComboBox(IEnumerable<PagoModel> pagoList);

        // conecta la interfaz de usuario con una fuente de datos
        void SetReservasListBindingSource(BindingSource reservasList);
        void Show();



    }

}
