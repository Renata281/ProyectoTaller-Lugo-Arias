using System;
using ProyectoTaller_Lugo_Arias.Models;
using ProyectoTaller_Lugo_Arias.Views;
using ProyectoTaller_Lugo_Arias.Repositorio;
using ProyectoTaller_Lugo_Arias.Presenters;
using System.Configuration;


namespace ProyectoTaller_Lugo_Arias
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            //cadena de conexion a la base de datos, en catalog poner el nombre de la bd
            //el . se refiere al servidor sql server local
            //integrated security true utiliza la autenticacion de windows para conectarse a sql server (tod esta en app.config)
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["MiConexionBD"].ConnectionString;
            IMainView view = new MainView();
            new MainPresenter(view, sqlConnectionString);
            Application.Run((Form)view);

            */
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Obtiene la cadena de conexión de la base de datos desde el archivo App.config.
            string connectionString = ConfigurationManager.ConnectionStrings["MiConexionBD"].ConnectionString;

            // 1. Crea la instancia del repositorio. Este objeto manejará las operaciones con la base de datos.
            IUsuarioRepositorio repositorio = new UsuarioRepositorio(connectionString);

            // 2. Crea la vista de login. Este es el primer formulario que el usuario verá.
            LoginView loginView = new LoginView();

            // 3. Crea el presentador de login e inyecta la vista y el repositorio.
            // Esto conecta la lógica (presentador) con la interfaz de usuario (vista) y los datos (repositorio).
            LoginPresenter loginPresenter = new LoginPresenter(loginView, repositorio, connectionString);

            // 4. Inicia la aplicación, comenzando con el formulario de login.
            Application.Run(loginView);

            
        }
    }
}