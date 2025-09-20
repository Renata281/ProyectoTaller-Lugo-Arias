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
    public partial class TipoHabitacionView : Form, ITipoHabitacionView
    {
        public TipoHabitacionView()
        {
            InitializeComponent();
        }

        public string tipo {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public string Descripcion {
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

        public void SetTipoHabitacionListBindingSource(BindingSource tipoHabitacionList)
        {
           dataGridView1.DataSource = tipoHabitacionList;
        }

        //abre una unica instancia del formulario
        private static TipoHabitacionView instance;
        public static TipoHabitacionView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new TipoHabitacionView();
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
