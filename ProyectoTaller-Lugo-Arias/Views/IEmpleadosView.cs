using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller_Lugo_Arias.Views
{
    public interface IEmpleadosView
    {
        //campos
        string Id_usuario { get; set; }
        string Nombre { get; set; }
        string Apellido { get; set; }
        string Dni { get; set; }
        string Telefono { get; set; }
        string Email { get; set; }
        string Password { get; set; }
        string Id_cargo { get; set; }
        string Cargo_descripcion { get; set; }
        string Estado { get; set; }

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

        //metodos

        // conecta la interfaz de usuario con una fuente de datos
        void SetEmpleadoListBindingSource(BindingSource empleadoList);
        void Show();

    }
}
