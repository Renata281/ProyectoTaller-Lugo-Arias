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
using System.Data.SqlClient;
using System.Configuration;
using ProyectoTaller_Lugo_Arias.Models;

namespace ProyectoTaller_Lugo_Arias.Views
{
    public partial class ReservasView : Form, IReservasView
    {
        public ReservasView()
        {
            InitializeComponent();
        }

        public string nro_reserva
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public DateTime fecha_ingreso
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public DateTime fecha_salida
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public decimal monto_total
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public int id_cliente
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public int nro_habitacion
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public int id_piso
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public int id_pago
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public string descripcion
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public string Buscar
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public bool IsEditar
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public bool IsNuevo
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public string Mensaje
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public string Nro_reserva { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime Fecha_ingreso { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime Fecha_salida { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float Monto_total { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Id_cliente { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Nro_habitacion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int I_piso { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Id_pago { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Cant_personas { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Estado { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Tipo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ClienteBusqueda { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Id_cliente_Seleccionado { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event EventHandler BuscarEvent;
        public event EventHandler AgregarEvent;
        public event EventHandler EditarEvent;
        public event EventHandler EliminarEvent;
        public event EventHandler GuardarEvent;
        public event EventHandler CancelarEvent;
        public event EventHandler SelectedTabChanged;
        public event EventHandler CriteriosBusquedaHabitacionChanged;
        public event EventHandler HabitacionSeleccionadaChanged;
        public event EventHandler ClienteBusquedaChanged;
        public event EventHandler ClienteSeleccionadoEvent;

        public void SetReservasListBindingSource(BindingSource reservasList)
        {
            throw new NotImplementedException();
        }

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
            dgvFinalizadas.DataSource = reservasList;
        }

        public void SetReservasListBindingSourceActivas(BindingSource reservasBindingSource)
        {
            throw new NotImplementedException();
        }

        public void SetReservasListBindingSourceFinalizadas(BindingSource reservasBindingSource)
        {
            throw new NotImplementedException();
        }

        public void SetReservasListBindingSourcePendientes(BindingSource reservasBindingSource)
        {
            throw new NotImplementedException();
        }

        public void SetPagosListComboBox(IEnumerable<FormaPagoModel> pagoList)
        {
            throw new NotImplementedException();
        }

        public void SetTiposHabitacionListComboBox(IEnumerable<TipoHabitacionModel> tipoHabitacionList)
        {
            throw new NotImplementedException();
        }

        public void SetClientesBusquedaBindingSource(BindingSource clienteBindingSource)
        {
            throw new NotImplementedException();
        }

        public void SetHabitacionesDisponiblesListComboBox(BindingSource habitacionesDisponiblesBindingSource)
        {
            throw new NotImplementedException();
        }
    }
}
