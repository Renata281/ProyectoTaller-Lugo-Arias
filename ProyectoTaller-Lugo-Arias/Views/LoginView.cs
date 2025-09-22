using ProyectoTaller_Lugo_Arias.Models;
using ProyectoTaller_Lugo_Arias.Views;
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
    public partial class LoginView : Form, ILoginView
    {
        public LoginView()
        {
            InitializeComponent();
            bLogin.Click += (sender, e) => LoginAttempt?.Invoke(this, EventArgs.Empty);
        }

        public string Email => tbCorreo.Text;

        public string Password => tbPass.Text;

        public event EventHandler LoginAttempt;


        public void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
