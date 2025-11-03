using ProyectoTaller_Lugo_Arias.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Navigation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProyectoTaller_Lugo_Arias.Views
{
    public partial class ReservasView : Form, IReservasView
    {
        private string mensaje;
        private bool isNuevo;
        private bool isEditar;
        private string nro_reserva_seleccionado;

        public ReservasView()
        {
            InitializeComponent();
            asociarYgenerarVistaEventos();
            tabControl1.TabPages.Remove(tpNuevaReserva);
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
                tabControl1.TabPages.Add(tpNuevaReserva); // Muestra la pestaña "Nuevo empleado"
                tabControl1.TabPages.Remove(tpTodos); // Oculta la pestaña "todos"
                tabControl1.TabPages.Remove(tpActivos); // Oculta la pestaña "Activos"
                tabControl1.TabPages.Remove(tpFinalizados); // Oculta la pestaña "Finalizados"
                tabControl1.TabPages.Remove(tpPendientes); // Oculta la pestaña "Pendientes"

                tpNuevaReserva.Text = "Agregar nueva reserva";

            };
            //editar
            bEditar.Click += delegate
            {
                EditarEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Add(tpNuevaReserva); // Muestra la pestaña "Nuevo empleado"
                tabControl1.TabPages.Remove(tpTodos); // Oculta la pestaña "todos"
                tabControl1.TabPages.Remove(tpActivos); // Oculta la pestaña "Activos"
                tabControl1.TabPages.Remove(tpFinalizados); // Oculta la pestaña "Finalizados"
                tabControl1.TabPages.Remove(tpPendientes); // Oculta la pestaña "Pendientes"

                tpNuevaReserva.Text = "Editar reserva";
            };
            //eliminar
            bEliminar.Click += delegate
            {
                var result = MessageBox.Show("¿Esta seguro que desea eliminar una reserva?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    EliminarEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Mensaje);
                }
            };
            //guardar
            bConfirmar.Click += delegate
            {
                GuardarEvent?.Invoke(this, EventArgs.Empty);
                //si guarda correctamente ejecuta el if
                if (isNuevo)
                {
                    tabControl1.TabPages.Remove(tpNuevaReserva); // Oculta la pestaña "Nuevo empleado"
                    tabControl1.TabPages.Add(tpTodos); // Muestra la pestaña "todos"
                    tabControl1.TabPages.Add(tpActivos); // Muestra la pestaña "Activos"
                    tabControl1.TabPages.Add(tpFinalizados);
                    tabControl1.TabPages.Add(tpPendientes); 
                }
                MessageBox.Show(Mensaje);
            };
            //cancelar
            bCancelar.Click += delegate
            {
                CancelarEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tpNuevaReserva); // Oculta la pestaña "Nuevo empleado"
                tabControl1.TabPages.Add(tpTodos); // Muestra la pestaña "todos"
                tabControl1.TabPages.Add(tpActivos); // Muestra la pestaña "Activos"
                tabControl1.TabPages.Add(tpFinalizados);
                tabControl1.TabPages.Add(tpPendientes);
            };

            // Eventos adicionales para actualización dinámica
            nudCantPersonas.ValueChanged += (s, e) => CriteriosBusquedaHabitacionChanged?.Invoke(this, EventArgs.Empty);
            dtpIngreso.ValueChanged += (s, e) => CriteriosBusquedaHabitacionChanged?.Invoke(this, EventArgs.Empty);
            dtpSalida.ValueChanged += (s, e) => CriteriosBusquedaHabitacionChanged?.Invoke(this, EventArgs.Empty);
            cbTipoHab.SelectedIndexChanged += (s, e) => CriteriosBusquedaHabitacionChanged?.Invoke(this, EventArgs.Empty);
            cbHab.SelectedIndexChanged += (s, e) => {
                // 1. Obtener el objeto HabitacionesModels seleccionado (asumiendo que es el tipo en el BindingSource)
                var selectedItem = cbHab.SelectedItem;
                if (selectedItem is HabitacionesModels habitacion)
                {
                    // 2. Asignar el Id_piso a la propiedad de la vista
                    this.Id_piso = habitacion.Id_piso;
                }
                HabitacionSeleccionadaChanged?.Invoke(this, EventArgs.Empty);
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

        public string Nro_reserva {
            get { return nro_reserva_seleccionado; }
            set { nro_reserva_seleccionado = value; }
        }
        public DateTime Fecha_ingreso {
            get => dtpIngreso.Value;
            set => dtpIngreso.Value = value;
        }
        public DateTime Fecha_salida {
            get => dtpSalida.Value;
            set => dtpSalida.Value = value;
        }
        public decimal Monto_total {
            get
            {
                decimal.TryParse(txtMonto.Text, out var monto);
                return monto;
            }
            set => txtMonto.Text = value.ToString("0.00");
        }
        public int Id_cliente {
            get => comboBoxClientes.SelectedValue != null ? Convert.ToInt32(comboBoxClientes.SelectedValue) : 0;
            set => comboBoxClientes.SelectedValue = value;
        }
        public int Nro_habitacion {
            get => cbHab.SelectedValue != null ? Convert.ToInt32(cbHab.SelectedValue) : 0;
            set => cbHab.SelectedValue = value;
        }
        public int Id_pago {
            get => cbFPago.SelectedValue != null ? Convert.ToInt32(cbFPago.SelectedValue) : 0;
            set => cbFPago.SelectedValue = value;
        }
        public int Cant_personas {
            get => (int)nudCantPersonas.Value;
            set => nudCantPersonas.Value = value;
        }
        public string Estado { get; set; }
        public int Id_tipo
        {
            get => cbTipoHab.SelectedValue != null ? Convert.ToInt32(cbTipoHab.SelectedValue) : 0;
            set => cbTipoHab.SelectedValue = value;
        }
        public int Id_piso { get; set; }
    

        public event EventHandler BuscarEvent;
        public event EventHandler AgregarEvent;
        public event EventHandler EditarEvent;
        public event EventHandler EliminarEvent;
        public event EventHandler GuardarEvent;
        public event EventHandler CancelarEvent;
        public event EventHandler SelectedTabChanged;
        public event EventHandler CriteriosBusquedaHabitacionChanged;
        public event EventHandler HabitacionSeleccionadaChanged;

        //abre una unica instancia del formulario
        private static ReservasView instance;
        public static ReservasView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ReservasView();
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

        public void SetReservaListBindingSource(BindingSource reservasList)
        {
            dgvTodos.DataSource = reservasList;
        }

        public void SetReservasListBindingSourceActivas(BindingSource reservasBindingSource)
        {
            dgvActivos.DataSource = reservasBindingSource;
        }

        public void SetReservasListBindingSourceFinalizadas(BindingSource reservasBindingSource)
        {
            dgvFinalizadas.DataSource = reservasBindingSource;
        }

        public void SetReservasListBindingSourcePendientes(BindingSource reservasBindingSource)
        {
            dgvPendientes.DataSource = reservasBindingSource;
        }

        public void SetPagosListComboBox(IEnumerable<FormaPagoModel> pagoList)
        {
            //limpia el combobox
            cbFPago.DataSource = null;
            cbFPago.Items.Clear();

            //crea una lista de pares clave-valor (Id_pago, descripcion), para mostrar la descripcion pero guardar el id
            var pago = pagoList.Select(c => new KeyValuePair<int, string>(c.Id_pago, c.Descripcion)).ToList();

            //enlazamos la lista al combobox
            cbFPago.DataSource = new BindingSource(pago, null);

            cbFPago.DisplayMember = "Value"; // lo que se muestra en el combobox
            cbFPago.ValueMember = "Key"; // lo que se guarda (Id_pago)
        }

        public void SetTiposHabitacionListComboBox(IEnumerable<TipoHabitacionModel> tipoHabitacionList)
        {
            cbTipoHab.DataBindings.Clear();
            cbTipoHab.DataSource = null;
            cbTipoHab.Items.Clear();

            cbTipoHab.DataSource = tipoHabitacionList.ToList();
            cbTipoHab.DisplayMember = "Tipo";         // se muestra el tipo (ej: "Suite")
            cbTipoHab.ValueMember = "Id_tipo";    
        }


        public void SetHabitacionesDisponiblesListComboBox(BindingSource habitacionesDisponiblesBindingSource)
        {
            cbHab.DataSource = habitacionesDisponiblesBindingSource;
            cbHab.DisplayMember = "Nro_habitacion";
            cbHab.ValueMember = "Nro_habitacion";
        }

        public void SetClientesListComboBox(IEnumerable<ClienteModel> clienteList)
        {
            // Filtrar solo los clientes activos
            var clientesActivos = clienteList
                .Where(c => c.Estado == "Activo")
                .Select(c => new
                {
                    Id = c.Id_cliente,
                    Dni = c.Dni.ToString() // Mostrar el DNI en el combo
                })
                .ToList();

            // Limpiar el ComboBox antes de cargar
            comboBoxClientes.DataSource = null;
            comboBoxClientes.Items.Clear();

            // Asignar la lista filtrada
            comboBoxClientes.DataSource = clientesActivos;
            comboBoxClientes.DisplayMember = "Dni"; // Lo que se muestra
            comboBoxClientes.ValueMember = "Id";    // Lo que se guarda
        }

    }
}
