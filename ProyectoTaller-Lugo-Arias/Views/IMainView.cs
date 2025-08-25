using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller_Lugo_Arias.Views
{
    public interface IMainView
    {
        event EventHandler ShowEmpleadosView;
        event EventHandler ShowClientesView;
        event EventHandler ShowReservasView;
        event EventHandler ShowHabitacionesView;
        event EventHandler ShowTipoHabitacionView;
    }
}
