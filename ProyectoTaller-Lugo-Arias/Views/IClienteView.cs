using ProyectoTaller_Lugo_Arias.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller_Lugo_Arias.Views
{
    public interface IClienteView
    {
        //campos
        int Id_cliente { get; set; }
        string Nombre { get; set; }
        string Apellido { get; set; }
        string Email { get; set; }
        int Telefono { get; set; }
        int Dni { get; set; }

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

        void SetClienteListBindingSource(BindingSource clienteBindingSource);
        void SetClientesListBindingSource(BindingSource clientesList);
        void Show();
    }
}
