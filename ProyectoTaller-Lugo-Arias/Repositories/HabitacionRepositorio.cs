using Microsoft.Data.SqlClient;
using ProyectoTaller_Lugo_Arias.Models;
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
    public class HabitacionRepositorio : BaseRepository, IHabitacionRepositorio
    {
        private object command;
        private object sqlDbType;

        //constructor
        public HabitacionRepositorio(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IEnumerable<HabitacionesModels> GetAll()
        {
            var habList = new List<HabitacionesModels>();

            // Usa _connectionString para crear la conexión
            using (var connection = new SqlConnection(connectionString))
            {
                
                using (var command = new SqlCommand("seleccionar", connection))
                {
                    command.CommandType = CommandType.StoredProcedure; // Indica que es un procedimiento almacenado
                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        // Usa un bucle 'while' para leer cada fila de la base de datos
                        while (reader.Read())
                        {
                            var habitacion = new HabitacionesModels();
    
    // Lee los datos por nombre de columna, es más seguro y legible
    habitacion.Nro_habitacion = (int)reader["Nro_habitacion"];
    habitacion.Cant_camas = (int)reader["Cant_camas"];

    // Usa una validación para evitar errores de conversión con valores nulos
    if (reader["Precio_unitario"] != DBNull.Value)
    {
        // Si la propiedad es float, usa Convert.ToSingle()
        // Si la propiedad es decimal, usa Convert.ToDecimal()
        habitacion.Precio_unitario = Convert.ToSingle(reader["Precio_unitario"]);
    }
    else
    {
        // Si el valor es nulo en la base de datos, asigna 0 o el valor por defecto que necesites
        habitacion.Precio_unitario = 0;
    }

    habitacion.Descripcion = reader["Descripcion"].ToString();
    habitacion.Tipo = reader["Tipo"].ToString();
    habitacion.Id_piso = (int)reader["Id_piso"];
    habitacion.Id_estado = (int)reader["Id_estado"];
    
    habList.Add(habitacion);
                        }
                    }
                }
            }
            return habList;
        }
        public void Add(HabitacionesModels habitacionesModels)
        {
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
        }

        public void Delete(int id)
        {
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
        }

        public void Edit(HabitacionesModels habitacionesModels)
        {
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
        }

      
        public IEnumerable<HabitacionesModels> GetByValue(string value)
        {
            var habList = new List<HabitacionesModels>();
            int NumeroHabitacion = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string tipoHabitacion = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "seleccionar";
                command.Parameters.Add("@numero", SqlDbType.Int).Value = NumeroHabitacion;
                command.Parameters.Add("@tipo", SqlDbType.NVarChar).Value = tipoHabitacion;

                using (var reader = command.ExecuteReader())
                {
                    var HabitacionesModels = new HabitacionesModels();
                    HabitacionesModels.Nro_habitacion = (int)reader[0];
                    HabitacionesModels.Cant_camas = (int)reader[1];
                    HabitacionesModels.Precio_unitario = (float)reader[2];
                    HabitacionesModels.Descripcion = reader[3].ToString();
                    HabitacionesModels.Tipo = reader[4].ToString();
                    HabitacionesModels.Id_piso = (int)reader[5];
                    HabitacionesModels.Id_estado = (int)reader[6];
                    habList.Add(HabitacionesModels);
                }
            }
            return habList;
        }

        public IEnumerable<HabitacionesModels> GetValue(int value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<HabitacionesModels> GetValue()
        {
            throw new NotImplementedException();
        }
    }
}
