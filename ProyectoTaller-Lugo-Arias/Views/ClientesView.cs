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
    public partial class ClientesView : Form, IClienteView
    {
        public ClientesView()
        {
            InitializeComponent();
        }

        public int id_cliente {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public string nombre {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public string apellido {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public string email {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public int telefono {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public int dni {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public string Buscar {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public bool IsEditar {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public bool IsNuevo { 
            get => throw new NotImplementedException();
            set => throw new NotImplementedException(); 
        }
        public string Mensaje { 
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public event EventHandler BuscarEvent;
        public event EventHandler AgregarEvent;
        public event EventHandler EditarEvent;
        public event EventHandler EliminarEvent;
        public event EventHandler GuardarEvent;
        public event EventHandler CancelarEvent;

        public void SetClienteListBindingSource(BindingSource clienteBindingSource)
        {
            dataGridView3.DataSource = clienteBindingSource;
        }

        public void SetClientesListBindingSource(BindingSource clientesList)
        {
            throw new NotImplementedException();
        }

        //abre una unica instancia del formulario
        private static ClientesView instance;
        public static ClientesView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ClientesView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }
    }
}
