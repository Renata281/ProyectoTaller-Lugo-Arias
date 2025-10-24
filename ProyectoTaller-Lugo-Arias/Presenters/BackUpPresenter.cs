using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using System.Reflection;
using ProyectoTaller_Lugo_Arias.Models;
using ProyectoTaller_Lugo_Arias.Repositories;
using ProyectoTaller_Lugo_Arias.Views;
using ProyectoTaller_Lugo_Arias.Presenters;
using ProyectoTaller_Lugo_Arias.Presenters.Common;

namespace ProyectoTaller_Lugo_Arias.Presenters
{
    public class BackUpPresenter
    {
        private IBackUpView view;
        private string connectionString;
        private string currentEmail;
        private ILogRepositorioHotel repositorio;
        private BindingSource logsBindingSource;
        private IEnumerable<LogModelHotel> logsList;

        public BackUpPresenter(IBackUpView view, string connectionString, string currentEmail, ILogRepositorioHotel repositorio)
        {
            this.view = view;
            this.connectionString = connectionString;
            this.currentEmail = currentEmail;
            this.repositorio = repositorio;
            this.logsBindingSource = new BindingSource();
            LoadAllLogs();
            this.view.SaveEvent += View_SaveEvent;
            this.view.RestoreEvent += View_RestoreEvent;
            this.view.SetLogsListBindingSource(logsBindingSource);
            this.view.Show();
        }

        private void View_SaveEvent(object sender, EventArgs e)
        {
            string path = view.SavePath;

            if (!string.IsNullOrEmpty(path))
            {
                try
                {
                    // Obtener nombre real de la base desde la cadena de conexión
                    var builder = new SqlConnectionStringBuilder(connectionString);
                    string dbName = builder.InitialCatalog;

                    string fileName = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + $"-BKUP_{dbName}.bak";
                    string fullPath = Path.Combine(path, fileName);

                    string query = $"BACKUP DATABASE [{dbName}] TO DISK = N'{fullPath}' WITH NOFORMAT, NOINIT, SKIP, STATS = 10";

                    using (var connection = new SqlConnection(connectionString))
                    using (var command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }

                    // Guardar log
                    repositorio.Add(new LogModelHotel { Archivo = fileName, UserEmail = currentEmail });
                    LoadAllLogs();

                    MessageBox.Show($"Backup creado: {fileName}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al crear backup: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una ruta válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void View_RestoreEvent(object sender, EventArgs e)
        {
            string path = view.RestorePath;

            if (!string.IsNullOrEmpty(path))
            {
                try
                {
                    // Obtener nombre real de la base desde la cadena de conexión
                    var builder = new SqlConnectionStringBuilder(connectionString);
                    string dbName = builder.InitialCatalog;

                    string query = $@"
                USE master;
                ALTER DATABASE [{dbName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                RESTORE DATABASE [{dbName}] FROM DISK = N'{path}' WITH REPLACE;
                ALTER DATABASE [{dbName}] SET MULTI_USER;";

                    using (var connection = new SqlConnection(connectionString))
                    using (var command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show($"Base de datos '{dbName}' restaurada desde: {path}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al restaurar backup: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un archivo válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void LoadAllLogs()
        {
            logsList = repositorio.GetAll();
            logsBindingSource.DataSource = logsList;
        }
    }
}
