using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller_Lugo_Arias.Views
{
    public partial class EmpleadosView : Form, IEmpleadosView
    {
        public EmpleadosView()
        {
            InitializeComponent();
        }

        public string Id_usuario { 
            get => throw new NotImplementedException();
            set => throw new NotImplementedException(); }

        public string Nombre { 
            get => throw new NotImplementedException();
            set => throw new NotImplementedException(); }

        public string Apellido {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException(); }

        public string Dni { 
            get => throw new NotImplementedException();
            set => throw new NotImplementedException(); }

        public string Telefono { 
            get => throw new NotImplementedException();
            set => throw new NotImplementedException(); }

        public string Email {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException(); }

        public string Password {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException(); }

        public string Id_cargo { 
            get => throw new NotImplementedException();
            set => throw new NotImplementedException(); }

        public string Cargo_descripcion { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); }

        public string Estado { 
            get => throw new NotImplementedException();
            set => throw new NotImplementedException(); }

        public string Buscar {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException(); }

        public bool IsEditar {
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); }

        public bool IsNuevo { 
            get => throw new NotImplementedException();
            set => throw new NotImplementedException(); }

        public string Mensaje {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException(); }

        public event EventHandler BuscarEvent;
        public event EventHandler AgregarEvent;
        public event EventHandler EditarEvent;
        public event EventHandler EliminarEvent;
        public event EventHandler GuardarEvent;
        public event EventHandler CancelarEvent;

        public void SetEmpleadoListBindingSource(BindingSource empleadoList)
        {
            throw new NotImplementedException();
        }
    }
}
