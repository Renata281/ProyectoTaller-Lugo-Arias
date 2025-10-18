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
        long Telefono { get; set; }
        long Dni { get; set; }

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

        void SetClienteListBindingSource(BindingSource clientesList);
        void SetClientesListBindingSourceActive(BindingSource clientesBindingSourceActived);
        void SetClientesListBindingSourceInactive(BindingSource clientesBindingSourceDeleted);
        void Show();
    }
}
