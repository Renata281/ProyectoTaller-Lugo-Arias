using ProyectoTaller_Lugo_Arias.Models;
using ProyectoTaller_Lugo_Arias.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller_Lugo_Arias.View
{
    public interface IHabitacionView 
    {
        String Nro_habitacion { get; set; }
        String Cant_camas { get; set; }
        String Precio_unitario { get; set; }
        String Descripcion { get; set; }
        String Tipo { get; set; }
        String Id_piso { get; set; }
        String Id_estado { get; set; }
        String Estado_descripcion { get; set; }

        String SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        String Message { get; set; }

        //eventos
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetPisosListComboBox(IEnumerable<PisoModel> pisoList);
        void SetEstadoHabitacionListComboBox(IEnumerable<EstadoHabitacionModel> estadoList);

        //metodos 

        void SetListaHabitacionBindingSourse(BindingSource listaHab);
        void SetListaHabitacionBindingSourseDisponibles(BindingSource habitacionesBindingSourceDisponibles);
        void SetListaHabitacionBindingSourseMantenimiento(BindingSource habitacionesBindingSourceMantenimiento);
        void SetListaHabitacionBindingSourseOcupadas(BindingSource habitacionesBindingSourceOcupadas);
        void Show();
        void SetTipoHabitacionListComboBox(IEnumerable<TipoHabitacionModel> tipoList);
    }
}
