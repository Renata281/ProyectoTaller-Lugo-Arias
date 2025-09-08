using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Navigation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProyectoTaller_Lugo_Arias.Views
{
    public partial class EmpleadosView : Form, IEmpleadosView
    {
        //campos
        private string mensaje;
        private bool isNuevo;
        private bool isEditar;

        //constructor
        public EmpleadosView()
        {
            InitializeComponent();
            asociarYgenerarVistaEventos();
            tabControl1.TabPages.Remove(tpNuevoEmpleado); // Oculta la pestaña "Nuevo CLiente"
            bCerrar.Click += delegate { this.Close(); };
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

            //agregar
            bNuevo.Click += delegate {
                AgregarEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Add(tpNuevoEmpleado); // Muestra la pestaña "Nuevo empleado"
                tabControl1.TabPages.Remove(tpTodos); // Oculta la pestaña "todos"
                tabControl1.TabPages.Remove(tpActivos); // Oculta la pestaña "Activos"
                tabControl1.TabPages.Remove(tpInactivos); // Oculta la pestaña "Inactivos"
                tpNuevoEmpleado.Text = "Agregar nuevo empleado";

            };
            //editar
            bEditar.Click += delegate {
                EditarEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Add(tpNuevoEmpleado); // Muestra la pestaña "Nuevo empleado"
                tabControl1.TabPages.Remove(tpTodos); // Oculta la pestaña "todos"
                tabControl1.TabPages.Remove(tpActivos); // Oculta la pestaña "Activos"
                tabControl1.TabPages.Remove(tpInactivos); // Oculta la pestaña "Inactivos"
                tpNuevoEmpleado.Text = "Editar empleado";
            };
            //eliminar
            bEliminar.Click += delegate
            {
                var result = MessageBox.Show("¿Esta seguro que desea eliminar un empleado?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    EliminarEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Mensaje);
                }
            };
            //guardar
            bGuardar.Click += delegate {
                GuardarEvent?.Invoke(this, EventArgs.Empty);
                //si guarda correctamente ejecuta el if
                if (isNuevo)
                {
                    tabControl1.TabPages.Remove(tpNuevoEmpleado); // Oculta la pestaña "Nuevo empleado"
                    tabControl1.TabPages.Add(tpTodos); // Muestra la pestaña "todos"
                    tabControl1.TabPages.Add(tpActivos); // Muestra la pestaña "Activos"
                    tabControl1.TabPages.Add(tpInactivos); // Muestra la pestaña "Inactivos"
                }
                MessageBox.Show(Mensaje);
            };
            //cancelar
            bCancelar.Click += delegate {
                CancelarEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tpNuevoEmpleado); // Oculta la pestaña "Nuevo empleado"
                tabControl1.TabPages.Add(tpTodos); // Muestra la pestaña "todos"
                tabControl1.TabPages.Add(tpActivos); // Muestra la pestaña "Activos"
                tabControl1.TabPages.Add(tpInactivos); // Muestra la pestaña "Inactivos"
            };
        }

        //propiedades
        public string Id_usuario
        {
            get { return tbUsername.Text; }
            set { tbUsername.Text = value; }
        }

        public string Nombre
        {
            get { return tbNombre.Text; }
            set { tbNombre.Text = value; }
        }

        public string Apellido
        {
            get { return tbApellido.Text; }
            set { tbApellido.Text = value; }
        }

        // Reemplazar las propiedades Dni y Telefono para que sean de tipo string, como exige la interfaz.
        // Agregar los setters para Cargo_descripcion y Estado, como exige la interfaz.

        public string Dni
        {
            get { return tbDni.Text; }
            set { tbDni.Text = value; }
        }

        public string Telefono
        {
            get { return tbTelefono.Text; }
            set { tbTelefono.Text = value; }
        }

        public string Email
        {
            get { return tbEmail.Text; }
            set { tbEmail.Text = value; }
        }

        public string Password
        {
            get { return tbPass.Text; }
            set { tbPass.Text = value; }
        }

        public string Id_cargo
        {
            get
            {
                // Si SelectedValue es null, devuelve string.Empty
                return cbCargo.SelectedValue?.ToString() ?? string.Empty;
            }
            set
            {
                // Intenta convertir el string a int si es posible, para asignar SelectedValue
                if (int.TryParse(value, out int intValue))
                {
                    cbCargo.SelectedValue = intValue;
                }
                else
                {
                    cbCargo.SelectedValue = value;
                }
            }
        }

        public string Cargo_descripcion
        {
            get
            {
                if (cbCargo.SelectedItem != null)
                {
                    return cbCargo.Text;
                }
                return string.Empty;
            }
            set
            {
                cbCargo.Text = value;
            }
        }

        public string Estado
        {
            get { return "Activo"; }
            set
            {
                // Si necesitas almacenar el estado, puedes agregar un campo privado.
                // Por ahora, simplemente ignora el setter ya que el valor es fijo.
            }
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

        public void SetEmpleadoListBindingSource(BindingSource empleadoList)
        {
            dataGridView1.DataSource = empleadoList;
        }

        //abre una unica instancia del formulario
        private static EmpleadosView instance;
        public static EmpleadosView GetInstance(Form parentContainer)
        {
            if(instance == null || instance.IsDisposed)
            {
                instance = new EmpleadosView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if(instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal; 
                }
                instance.BringToFront();
            }
            return instance;
        }

    }
}
