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
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            bEmpleados.Click += delegate { ShowEmpleadosView?.Invoke(this, EventArgs.Empty); };
            bClientes.Click += delegate { ShowClientesView?.Invoke(this, EventArgs.Empty); };
            bReservas.Click += delegate { ShowReservasView?.Invoke(this, EventArgs.Empty); };
            bHabitaciones.Click += delegate { ShowHabitacionesView?.Invoke(this, EventArgs.Empty); };
            bTipoHabitacion.Click += delegate { ShowTipoHabitacionView?.Invoke(this, EventArgs.Empty); };
            bSalir.Click += delegate { Application.Exit(); };
        }

        public event EventHandler ShowEmpleadosView;
        public event EventHandler ShowClientesView;
        public event EventHandler ShowReservasView;
        public event EventHandler ShowHabitacionesView;
        public event EventHandler ShowTipoHabitacionView;

        private void bEmpleados_Click(object sender, EventArgs e)
        {

        }

        private void bTipoHabitacion_Click(object sender, EventArgs e)
        {

        }
    }
}
