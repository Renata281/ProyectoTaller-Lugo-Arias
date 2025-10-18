using ProyectoTaller_Lugo_Arias.Models;
using ProyectoTaller_Lugo_Arias.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller_Lugo_Arias.View
{
    public interface IHabitacionView 
    {
        string Nro_habitacion { get; set; }
        string Cant_camas { get; set; }
        string Precio_unitario { get; set; }
        string Descripcion { get; set; }
        string Tipo { get; set; }
        string Id_piso { get; set; }
        string Id_estado { get; set; }
        string Estado_descripcion { get; set; }
        int Id_tipo { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }
        string Cant_personas { get; set; }

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
