using ProyectoTaller_Lugo_Arias.Models;
using ProyectoTaller_Lugo_Arias.Repositorio;
using ProyectoTaller_Lugo_Arias.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
    
  namespace ProyectoTaller_Lugo_Arias.Presenters
   {
        public class LoginPresenter
        {
            private readonly ILoginView view;
            private readonly IUsuarioRepositorio repositorio;
        private string sqlConnection;
            public LoginPresenter(ILoginView view, IUsuarioRepositorio repositorio, string sqlConnection)
            {
                this.view = view;
                this.repositorio = repositorio;
                this.sqlConnection = sqlConnection;

                this.view.LoginAttempt += OnLoginAttempt;
            }

            private void OnLoginAttempt(object sender, EventArgs e)
            {
                var email = view.Email;
                var pass = view.Password;
                if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(pass))
                {
                    //ESCRIBIR ADVERTENCIA DE COMPLETAR CAMPOS
                }
                else
                {
                    var user = repositorio.Login(email, pass);
                    if (user.Nombre != null)
                    {
                        IMainView main = new MainView(user);
                        new MainPresenter(main, sqlConnection);
                        main.Show();
                        ((Form)view).Hide();

                    }
                    else
                    {
                        view.ShowErrorMessage("Tus credenciales son incorrectas");
                    }
                }
             }
         }
   }
 
