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
        private string mensaje;
        private bool isNuevo;
        private bool isEditar;
        private int id_cliente_seleccionado;
        public ClientesView()
        {
            InitializeComponent();
            asociarYgenerarVistaEventos();
            tabControl1.TabPages.Remove(tpNuevoCliente);
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
                tabControl1.TabPages.Add(tpNuevoCliente); // Muestra la pestaña "Nuevo cliente"
                tabControl1.TabPages.Remove(tpTodos); // Oculta la pestaña "todos"
                tabControl1.TabPages.Remove(tpActivos); // Oculta la pestaña "Activos"
                tabControl1.TabPages.Remove(tpInactivos); // Oculta la pestaña "Inactivos"
                tpNuevoCliente.Text = "Agregar nuevo cliente";

            };
            //editar
            bEditar.Click += delegate
            {
                EditarEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Add(tpNuevoCliente); // Muestra la pestaña "Nuevo cliente"
                tabControl1.TabPages.Remove(tpTodos); // Oculta la pestaña "todos"
                tabControl1.TabPages.Remove(tpActivos); // Oculta la pestaña "Activos"
                tabControl1.TabPages.Remove(tpInactivos); // Oculta la pestaña "Inactivos"
                tpNuevoCliente.Text = "Editar cliente";
            };
            //eliminar
            bEliminar.Click += delegate
            {
                var result = MessageBox.Show("¿Esta seguro que desea eliminar un cliente?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
                    tabControl1.TabPages.Remove(tpNuevoCliente); // Oculta la pestaña "Nuevo empleado"
                    tabControl1.TabPages.Add(tpTodos); // Muestra la pestaña "todos"
                    tabControl1.TabPages.Add(tpActivos); // Muestra la pestaña "Activos"
                    tabControl1.TabPages.Add(tpInactivos); // Muestra la pestaña "Inactivos"
                }
                MessageBox.Show(Mensaje);
            };
            //cancelar
            bCancelar.Click += delegate
            {
                CancelarEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tpNuevoCliente); // Oculta la pestaña "Nuevo empleado"
                tabControl1.TabPages.Add(tpTodos); // Muestra la pestaña "todos"
                tabControl1.TabPages.Add(tpActivos); // Muestra la pestaña "Activos"
                tabControl1.TabPages.Add(tpInactivos); // Muestra la pestaña "Inactivos"
            };
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

        public int Id_cliente {
            get { return id_cliente_seleccionado; }
            set { id_cliente_seleccionado = value; }
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

        public string Email
        {
            get { return tbEmail.Text; }
            set { tbEmail.Text = value; }
        }

        public long Dni
        {
            get { return long.Parse(tbDni.Text); }
            set { tbDni.Text = value.ToString(); }
        }

        public long Telefono
        {
            get { return long.Parse(tbTelefono.Text); }
            set { tbTelefono.Text = value.ToString(); }
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

        public event EventHandler BuscarEvent;
        public event EventHandler AgregarEvent;
        public event EventHandler EditarEvent;
        public event EventHandler EliminarEvent;
        public event EventHandler GuardarEvent;
        public event EventHandler CancelarEvent;

        public void SetClienteListBindingSource(BindingSource clientesList)
        {
            dataGridView3.DataSource = clientesList;
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

        public void SetClientesListBindingSourceActive(BindingSource clientesBindingSourceActived)
        {
            dataGridView2.DataSource = clientesBindingSourceActived;
        }

        public void SetClientesListBindingSourceInactive(BindingSource clientesBindingSourceDeleted)
        {
            dataGridView1.DataSource = clientesBindingSourceDeleted;
        }
    }
}
