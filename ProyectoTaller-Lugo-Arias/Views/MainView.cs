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
        // Inicializar los eventos con delegados vacíos para evitar CS8618
        public event EventHandler ShowEmpleadosView = delegate { };
        public event EventHandler ShowClientesView = delegate { };
        public event EventHandler ShowReservasView = delegate { };
        public event EventHandler ShowHabitacionesView = delegate { };
        public event EventHandler ShowTipoHabitacionView = delegate { };
        public event EventHandler ShowSalir = delegate { };

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
    }
}
