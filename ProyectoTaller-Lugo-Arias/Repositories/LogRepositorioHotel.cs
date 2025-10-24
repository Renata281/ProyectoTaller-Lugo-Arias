using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoTaller_Lugo_Arias.Models;
using ProyectoTaller_Lugo_Arias.Repositorio;

namespace ProyectoTaller_Lugo_Arias.Repositories
{
    public class LogRepositorioHotel : BaseRepositorio, ILogRepositorioHotel
    {
        //constructor
        public LogRepositorioHotel(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(LogModelHotel log)
        {
            using (var connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                // Inserta en el historial en la base de datos
                string logQuery = "INSERT INTO backup_logs VALUES (@archivo, @admin_email, @fecha)";
                using (var logCommand = new SqlCommand(logQuery, connection))
                {
                    logCommand.Parameters.AddWithValue("@archivo", log.Archivo);
                    logCommand.Parameters.AddWithValue("@admin_email", log.UserEmail);
                    logCommand.Parameters.AddWithValue("@fecha", DateTime.Now);
                    logCommand.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int idlog)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LogModelHotel> GetAll()
        {
            var logsList = new List<LogModelHotel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand("SELECT id_log, archivo, admin_email, fecha FROM backup_logs ORDER BY id_log ASC", connection))                //"ORDER BY Id_usuario DESC", connection))
            {
                connection.Open();
                try
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var log = new LogModelHotel
                            {
                                Idlog = reader.GetInt32(reader.GetOrdinal("id_log")),
                                Archivo = reader.GetString(reader.GetOrdinal("archivo")),
                                UserEmail = reader.GetString(reader.GetOrdinal("admin_email")),
                                Fecha = reader.GetDateTime(reader.GetOrdinal("fecha"))
                            };
                            logsList.Add(log);
                        }
                    }
                }
                catch (Exception e)
                {

                }
            }
            return logsList;
        }

        public IEnumerable<LogModelHotel> GetByValue(string value)
        {
            throw new NotImplementedException();
        }
    }
}
