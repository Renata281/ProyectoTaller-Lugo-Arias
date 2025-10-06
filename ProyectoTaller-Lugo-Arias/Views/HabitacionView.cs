using ProyectoTaller_Lugo_Arias.View;
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
    public partial class HabitacionView : Form, IHabitacionView
    {
        public HabitacionView()
        {
            InitializeComponent();
        }

        public string Nro_habitacion {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public string Cant_camas {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public string Precio_unitario {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public string Descripcion {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public string Tipo {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        
        }
        public string Id_piso {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public string Id_estado { 
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public string SearchValue {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public bool IsEdit { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public bool IsSuccessful {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException(); 
        }
        public string Message {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetListaHabitacionBindingSourse(BindingSource listaHab)
        {

            dataGridView3.DataSource = listaHab;
        }

       
        //abre una unica instancia del formulario
        private static HabitacionView instance;
        public static HabitacionView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new HabitacionView();
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
