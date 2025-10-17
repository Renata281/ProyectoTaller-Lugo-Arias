using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace ProyectoTaller_Lugo_Arias.Views
{
    public partial class TipoHabitacionView : Form, ITipoHabitacionView
    {
        private string mensaje;
        private bool isNuevo;
        private bool isEditar;

        public TipoHabitacionView()
        {
            InitializeComponent();
            asociarYgenerarVistaEventos();
            tTipoHabitacion.TabPages.Remove(tNuevaHabit);
        }

        private void asociarYgenerarVistaEventos()
        {
            //asociar eventos a los botones

            //buscar
            bBuscar.Click += delegate { BuscarEvent?.Invoke(this, EventArgs.Empty); };
            //clickea el boton enter
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    BuscarEvent?.Invoke(this, EventArgs.Empty);
                    e.Handled = true;
                    e.SuppressKeyPress = true; // Evita el sonido de "ding"
                }
            };

            txtSearch.TextChanged += (s, e) =>
            {
                BuscarEvent?.Invoke(this, EventArgs.Empty);
            };

            //agregar
            bNuevo.Click += delegate
            {
                AgregarEvent?.Invoke(this, EventArgs.Empty);
                tTipoHabitacion.TabPages.Add(tNuevaHabit); // Muestra 
                tTipoHabitacion.TabPages.Remove(tTodos); // Oculta 
                tNuevaHabit.Text = "Agregar nuevo tipo de habitación";

            };
            //editar
            bEditar.Click += delegate
            {
                EditarEvent?.Invoke(this, EventArgs.Empty);
                tTipoHabitacion.TabPages.Add(tNuevaHabit); // Muestra 
                tTipoHabitacion.TabPages.Remove(tTodos); // Oculta 
                tNuevaHabit.Text = "Editar tipo de habitación";
            };
            //eliminar
            bEliminar.Click += delegate
            {
                var result = MessageBox.Show("¿Esta seguro que desea eliminar un tipo de habitación?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    EliminarEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Mensaje);
                }
            };
            //guardar
            bGuardar.Click += delegate
            {
                GuardarEvent?.Invoke(this, EventArgs.Empty);
                //si guarda correctamente ejecuta el if
                if (isNuevo)
                {
                    tTipoHabitacion.TabPages.Remove(tNuevaHabit); // Oculta 
                    tTipoHabitacion.TabPages.Add(tTodos); // Muestra 
                }
                MessageBox.Show(Mensaje);
            };
            //cancelar
            bCancelar.Click += delegate
            {
                CancelarEvent?.Invoke(this, EventArgs.Empty);
                tTipoHabitacion.TabPages.Remove(tNuevaHabit); // Oculta 
                tTipoHabitacion.TabPages.Add(tTodos); // Muestra 
            };
        }

        public string tipo {
            get { return tbNombre.Text; }
            set { tbNombre.Text = value; }
        }
        public string Descripcion {
            get { return tbDescripcion.Text; }
            set { tbNombre.Text = value; }
        }
        public string Buscar
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }
        public bool IsEditar
        {
            get { return isEditar; }
            set { isEditar = value; }
        }
        public bool IsNuevo
        {
            get { return isNuevo; }
            set { isNuevo = value; }
        }

        public string Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
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
