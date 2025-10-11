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

        public event EventHandler BuscarEvent;
        public event EventHandler AgregarEvent;
        public event EventHandler EditarEvent;
        public event EventHandler EliminarEvent;
        public event EventHandler GuardarEvent;
        public event EventHandler CancelarEvent;

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

        
    }
}
