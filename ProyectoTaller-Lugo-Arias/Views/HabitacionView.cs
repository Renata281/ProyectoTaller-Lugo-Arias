using ProyectoTaller_Lugo_Arias.Models;
using ProyectoTaller_Lugo_Arias.View;
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
    public partial class HabitacionView : Form, IHabitacionView
    {
        //campos
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        
        public HabitacionView()
        {
            InitializeComponent();
            asociarYgenerarVistaEventos();
            tabControl1.TabPages.Remove(tpNuevaHabt);
        }

        private void asociarYgenerarVistaEventos()
        {
            //asociar eventos a los botones
            //buscar
            bBuscar.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            //clickea el boton enter
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                    e.Handled = true;
                    e.SuppressKeyPress = true; // Evita el sonido de "ding"
                }
            };

            txtSearch.TextChanged += (s, e) =>
            {
                SearchEvent?.Invoke(this, EventArgs.Empty);
            };

            //agregar

            bNuevo.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Add(tpNuevaHabt); // Muestra la pestaña "Nueva habitacion"
                tabControl1.TabPages.Remove(tpTodos); // Oculta la pestaña "todos"
                tabControl1.TabPages.Remove(tpDisponible); // Oculta la pestaña "Disponible"
                tabControl1.TabPages.Remove(tpOcupadas); // Oculta la pestaña "Ocupados"
                tabControl1.TabPages.Remove(tpMantenimiento); // Oculta la pestaña "Mantenimiento"
                tpNuevaHabt.Text = "Agregar nueva habitación";

            };

            //editar
            bEditar.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Add(tpNuevaHabt); // Muestra la pestaña "Nueva habitacion"
                tabControl1.TabPages.Remove(tpTodos); // Oculta la pestaña "todos"
                tabControl1.TabPages.Remove(tpDisponible); // Oculta la pestaña "Disponible"
                tabControl1.TabPages.Remove(tpOcupadas); // Oculta la pestaña "Ocupados"
                tabControl1.TabPages.Remove(tpMantenimiento); // Oculta la pestaña "Mantenimiento"
                tpNuevaHabt.Text = "Editar habitación";
            };

            //eliminar
            bEliminar.Click += delegate
            {
                var result = MessageBox.Show("¿Esta seguro que desea eliminar una habitación?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

            //guardar
            bGuardar.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    tabControl1.TabPages.Remove(tpNuevaHabt); // Oculta la pestaña "Nueva habitacion"
                    tabControl1.TabPages.Add(tpTodos); // Muestra la pestaña "todos"
                    tabControl1.TabPages.Add(tpDisponible); // Muestra la pestaña "Disponible"
                    tabControl1.TabPages.Add(tpOcupadas); // Muestra la pestaña "Ocupados"
                    tabControl1.TabPages.Add(tpMantenimiento); // Muestra la pestaña "Mantenimiento"
                }
                MessageBox.Show(Message);
            };

            //cancelar
            bCancelar.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tpNuevaHabt); // Oculta la pestaña "Nueva habitacion"
                tabControl1.TabPages.Add(tpTodos); // Muestra la pestaña "todos"
                tabControl1.TabPages.Add(tpDisponible); // Muestra la pestaña "Disponible"
                tabControl1.TabPages.Add(tpOcupadas); // Muestra la pestaña "Ocupados"
                tabControl1.TabPages.Add(tpMantenimiento); // Muestra la pestaña "Mantenimiento"
            };

        }

        public string Nro_habitacion
        {
            get { return tbNro.Text; }
            set { tbNro.Text = value; }
        }
        public string Cant_camas
        {
            get { return tbCamas.Text; }
            set { tbCamas.Text = value; }
        }
        public string Precio_unitario
        {
            get { return tbPrecio.Text; }
            set { tbPrecio.Text = value; }
        }
        public string Descripcion
        {
            get { return tbDescripcion.Text; }
            set { tbDescripcion.Text = value; }
        }
        public string Tipo
        {
            get { return cbTipo.SelectedItem?.ToString() ?? string.Empty; }
            set { cbTipo.SelectedItem = value; }
        }
        
        public string Id_piso
        {
            get { return cbPiso.SelectedValue?.ToString() ?? string.Empty; }
            set { cbPiso.SelectedValue = value; }
        }
        
        public string Id_estado
        {
            get { return cbEstado.SelectedValue?.ToString() ?? string.Empty; }
            set { cbEstado.SelectedValue = value; }
        }

        public string Estado_descripcion
        {
            get
            {
                if (cbEstado.SelectedItem != null)
                {
                    return cbEstado.Text;
                }
                return string.Empty;
            }
            set
            {
                cbEstado.Text = value;
            }
        }

        public string SearchValue
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }
        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public string Cant_personas {
            get { return tbMaxPers.Text; }
            set { tbMaxPers.Text = value; }
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

        public void SetListaHabitacionBindingSourseDisponibles(BindingSource habitacionesBindingSourceDisponibles)
        {
            dataGridView2.DataSource = habitacionesBindingSourceDisponibles;
        }

        public void SetListaHabitacionBindingSourseMantenimiento(BindingSource habitacionesBindingSourceMantenimiento)
        {
            dataGridView4.DataSource = habitacionesBindingSourceMantenimiento;
        }

        public void SetListaHabitacionBindingSourseOcupadas(BindingSource habitacionesBindingSourceOcupadas)
        {
            dataGridView1.DataSource = habitacionesBindingSourceOcupadas;
        }

        public void SetTipoHabitacionListComboBox(IEnumerable<TipoHabitacionModel> tipoList)
        {
            cbTipo.DataBindings.Clear();
            cbTipo.DataSource = null;
            cbTipo.Items.Clear();

            cbTipo.DataSource = tipoList.ToList();
            cbTipo.DisplayMember = "Tipo";         // se muestra el tipo (ej: "Suite")
            cbTipo.ValueMember = "Descripcion";    // opcionalmente podés guardar la descripción
        }

        public void SetPisosListComboBox(IEnumerable<PisoModel> pisoList)
        {
            cbPiso.DataSource = null; // Limpia por si ya tenía algo cargado
            cbPiso.DataSource = pisoList.ToList();
            cbPiso.DisplayMember = "Id_piso";
            cbPiso.ValueMember = "Id_piso";       
        }

        public void SetEstadoHabitacionListComboBox(IEnumerable<EstadoHabitacionModel> estadoList)
        {
            //limpia el combobox
            cbEstado.DataSource = null;
            cbEstado.Items.Clear();

            //crea una lista de pares clave-valor (id_estado, descripcion), para mostrar la descripcion pero guardar el id
            var estado = estadoList.Select(e => new KeyValuePair<int, string>(e.Id_estado, e.Descripcion)).ToList();

            //enlazamos la lista al combobox
            cbEstado.DataSource = new BindingSource(estado, null);

            cbEstado.DataSource = new BindingSource(estado, null);
            cbEstado.DisplayMember = "Value"; // lo que se muestra en el combobox
            cbEstado.ValueMember = "Key"; // lo que se guarda (id_estado)
        }

    }
}
