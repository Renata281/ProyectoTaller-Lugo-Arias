using System.Data.SqlClient;
using ProyectoTaller_Lugo_Arias.Models;
using ProyectoTaller_Lugo_Arias.Repositories;
using ProyectoTaller_Lugo_Arias.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller_Lugo_Arias.Repositorio
{
    public class HabitacionRepositorio : BaseRepositorio, IHabitacionRepositorio
    {

        //constructor
        public HabitacionRepositorio(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IEnumerable<HabitacionesModels> GetAll()
        {
            var habList = new List<HabitacionesModels>();

            if (string.IsNullOrWhiteSpace(connectionString))
                throw new InvalidOperationException("La cadena de conexión (connectionString) no está configurada.");

            try
            {
                using (var connection = new SqlConnection(connectionString))
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM habitacion";
                    command.CommandType = CommandType.Text;

                    connection.Open(); // <-- aquí capturás la excepción si falla
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var habitacion = new HabitacionesModels
                            {
                                Nro_habitacion = reader["Nro_habitacion"] != DBNull.Value ? Convert.ToInt32(reader["Nro_habitacion"]) : 0,
                                Cant_camas = reader["Cant_camas"] != DBNull.Value ? Convert.ToInt32(reader["Cant_camas"]) : 0,
                                Precio_unitario = reader["Precio_unitario"] != DBNull.Value ? Convert.ToSingle(reader["Precio_unitario"]) : 0f,
                                Descripcion = reader["Descripcion"]?.ToString(),
                                Tipo = reader["Tipo"]?.ToString(),
                                Id_piso = reader["Id_piso"] != DBNull.Value ? Convert.ToInt32(reader["Id_piso"]) : 0,
                                Id_estado = reader["Id_estado"] != DBNull.Value ? Convert.ToInt32(reader["Id_estado"]) : 0
                            };

                            habList.Add(habitacion);
                        }
                    }
                }
            }
            catch (Microsoft.Data.SqlClient.SqlException sqlEx)
            {
                // Logueá o inspeccioná sqlEx.Number y sqlEx.Message
                Debug.WriteLine($"SQL Exception ({sqlEx.Number}): {sqlEx.Message}");
                throw; // o lanzar nueva excepción más descriptiva
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Exception en GetAll: {ex.GetType().Name} - {ex.Message}");
                throw;
            }

            return habList;
        }

        public void Add(HabitacionesModels habitacionesModels)
        {
            throw new NotImplementedException();
            /*
            using (var connection = new SqlConnection(connectionString))
            {

                using (var command = new SqlCommand("seleccionar", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "insertar los siguientes valores (@cant_camas, @precio_unitario, @Descripcion, @tipo)";
                    command.Parameters.Add("@cant_camas", SqlDbType.Int).Value = habitacionesModels.Cant_camas;
                    command.Parameters.Add("@precio_unitario", SqlDbType.Int).Value = habitacionesModels.Precio_unitario;
                    command.Parameters.Add("@descripcion" , SqlDbType.NVarChar).Value = habitacionesModels.Descripcion;
                    command.Parameters.Add("@tipo", SqlDbType.NVarChar).Value = habitacionesModels.Tipo;
                    command.ExecuteNonQuery();
                }
            }
            */
        }

        public void Delete(int id)
        {
            /*
            using (var connection = new SqlConnection(connectionString))
            {

                using (var command = new SqlCommand("seleccionar", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "eliminar nro_habitacion";
                    command.Parameters.Add("@nro_habitacion", SqlDbType.Int).Value = id;
                    command.ExecuteNonQuery();
                }
            }
            */
            throw new NotImplementedException();
        }

        public void Edit(HabitacionesModels habitacionesModels)
        {
            /*
            using (var connection = new SqlConnection(connectionString))
            {

                using (var command = new SqlCommand("seleccionar", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "Actualizar hab_camas = @cant_camas, hab_precio = @precio_unitario, hab_descripcion = @Descripcion, hab_tipo = @tipo)";
                    command.Parameters.Add("@cant_camas", SqlDbType.Int).Value = habitacionesModels.Cant_camas;
                    command.Parameters.Add("@precio_unitario", SqlDbType.Int).Value = habitacionesModels.Precio_unitario;
                    command.Parameters.Add("@descripcion", SqlDbType.NVarChar).Value = habitacionesModels.Descripcion;
                    command.Parameters.Add("@tipo", SqlDbType.NVarChar).Value = habitacionesModels.Tipo;
                    command.ExecuteNonQuery();
                }
            }
            */
            throw new NotImplementedException();
        }

      
        public IEnumerable<HabitacionesModels> GetByValue(string value)
        {
            var habList = new List<HabitacionesModels>();
            int NumeroHabitacion = int.TryParse(value, out var id) ? id : 0;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM habitacion WHERE nro_habitacion = @nro_habitacion";
                command.Parameters.Add("@nro_habitacion", SqlDbType.Int).Value = NumeroHabitacion;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var habitacion = new HabitacionesModels
                        {
                            Nro_habitacion = (int)reader["Nro_habitacion"],
                            Cant_camas = (int)reader["Cant_camas"],
                            Precio_unitario = reader["Precio_unitario"] != DBNull.Value ? Convert.ToSingle(reader["Precio_unitario"]) : 0,
                            Descripcion = reader["Descripcion"].ToString(),
                            Tipo = reader["Tipo"].ToString(),
                            Id_piso = (int)reader["Id_piso"],
                            Id_estado = (int)reader["Id_estado"]
                        };

                        habList.Add(habitacion);
                    }
                }

            }
            return habList;
        }

    }
}
