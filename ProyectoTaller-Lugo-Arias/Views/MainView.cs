using ProyectoTaller_Lugo_Arias.Models;
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

namespace ProyectoTaller_Lugo_Arias.Views
{
    public partial class MainView : Form, IMainView
    {
        private UsuarioModel currentUser;
        public UsuarioModel CurrentUser
        {
            get { return this.currentUser; }
            set { this.currentUser = value; }
        }

        // Inicializar los eventos con delegados vacíos para evitar CS8618
        public event EventHandler ShowEmpleadosView = delegate { };
        public event EventHandler ShowClientesView = delegate { };
        public event EventHandler ShowReservasView = delegate { };
        public event EventHandler ShowHabitacionesView = delegate { };
        public event EventHandler ShowTipoHabitacionView = delegate { };
        public event EventHandler ShowSalir = delegate { };
        public event EventHandler ShowBackupView = delegate { };
        public event EventHandler ShowReportesView;

        public MainView(UsuarioModel user)
        {
            InitializeComponent();
            this.currentUser = user;
            RestrictAccessByRole();

            bEmpleados.Click += delegate { ShowEmpleadosView?.Invoke(this, EventArgs.Empty); };
            bClientes.Click += delegate { ShowClientesView?.Invoke(this, EventArgs.Empty); };
            bReservas.Click += delegate { ShowReservasView?.Invoke(this, EventArgs.Empty); };
            bHabitaciones.Click += delegate { ShowHabitacionesView?.Invoke(this, EventArgs.Empty); };
            bTipoHabitacion.Click += delegate { ShowTipoHabitacionView?.Invoke(this, EventArgs.Empty); };
            bBackUp.Click += delegate { ShowBackupView?.Invoke(this, EventArgs.Empty); };
            bReportes.Click += delegate {ShowReportesView?.Invoke(this, EventArgs.Empty); };

            bSalir.Click += delegate { Application.Exit(); };

        }

        public void RestrictAccessByRole()
        {


            switch (currentUser.Id_cargo)
            {
                case 1: // Recepcionista
                    // Acceso limitado: Solo operaciones de cliente y reserva
                    bClientes.Visible = true;
                    bEmpleados.Visible = false;
                    bReservas.Visible = true;
                    bHabitaciones.Visible = true;
                    bTipoHabitacion.Visible = false;
                    bBackUp.Visible = false;
                    bReportes.Visible = false;
                    break;

                case 2:// Gerente
                       // Acceso restringido: Oculta la gestión de empleados
                    bClientes.Visible = true;
                    bEmpleados.Visible = false; // El gerente no gestiona empleados directamente
                    bReservas.Visible = true;
                    bHabitaciones.Visible = true;
                    bTipoHabitacion.Visible = true;
                    bBackUp.Visible = true;
                    bReportes.Visible = true;
                    break;


                case 3: //programador
                    // Acceso completo: Muestra todas las operaciones
                    bClientes.Visible = true;
                    bEmpleados.Visible = true;
                    bReservas.Visible = true;
                    bHabitaciones.Visible = true;
                    bTipoHabitacion.Visible = true;
                    bBackUp.Visible = true;
                    bReportes.Visible = false;
                    break;

                case 4: // Administrador
                    // Acceso completo: Muestra todas las operaciones
                    bClientes.Visible = true;
                    bEmpleados.Visible = true;
                    bReservas.Visible = true;
                    bHabitaciones.Visible = true;
                    bTipoHabitacion.Visible = true;
                    bBackUp.Visible = true;
                    bReportes.Visible = true;
                    break;

            }
        }

       
    }
}
