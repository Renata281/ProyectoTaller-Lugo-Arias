using System;
using ProyectoTaller_Lugo_Arias.Models;
using ProyectoTaller_Lugo_Arias.Views;
using ProyectoTaller_Lugo_Arias.Repositories;
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
        }
    }
}