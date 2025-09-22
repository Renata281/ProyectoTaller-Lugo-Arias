using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoTaller_Lugo_Arias.Models;

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

        //metodos 
        void SetListaHabitacionesBindingSourse(BindingSource listaHab);
        void SetListaHabitacionBindingSourse(BindingSource habitacionBindingSource);
        void Show();
    }
}
