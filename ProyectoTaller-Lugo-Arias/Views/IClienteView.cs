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
        int id_cliente { get; set; }
        string nombre { get; set; }
        string apellido { get; set; }
        string email { get; set; }
        int telefono { get; set; }
        int dni { get; set; }

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
