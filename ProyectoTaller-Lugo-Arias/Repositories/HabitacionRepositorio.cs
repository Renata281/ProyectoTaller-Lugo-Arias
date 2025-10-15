using System.Data.SqlClient;
using ProyectoTaller_Lugo_Arias.Models;
using ProyectoTaller_Lugo_Arias.Repositorio;
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
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"
                 SELECT h.*, 
                 t.tipo AS tipo_habitacion,
                 e.descripcion AS estado_habitacion,
                 p.id_piso AS piso_habitacion
                 FROM habitacion h
                 INNER JOIN tipo_habitacion t ON t.tipo = h.tipo
                 INNER JOIN estado_habitacion e ON e.id_estado = h.id_estado
                 INNER JOIN piso p ON p.id_piso = h.id_piso
                 ORDER BY h.tipo DESC;";
                using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                        var habitacion = new HabitacionesModels();

                        habitacion.Nro_habitacion = reader["nro_habitacion"] is DBNull ? 0 : (int)reader["nro_habitacion"];
                        habitacion.Cant_camas = reader["cant_camas"] is DBNull ? 0 : (int)reader["cant_camas"];
                        habitacion.Precio_unitario = reader["precio_unitario"] != DBNull.Value ? Convert.ToSingle(reader["precio_unitario"]) : 0f;
                        habitacion.Descripcion = reader["descripcion"] as string ?? string.Empty;
                        habitacion.Tipo = reader["tipo_habitacion"] as string ?? string.Empty;
                        habitacion.Id_piso = reader["piso_habitacion"] is DBNull ? 0 : (int)reader["piso_habitacion"];
                        habitacion.Id_estado = reader["id_estado"] is DBNull ? 0 : (int)reader["id_estado"];
                        habitacion.Cant_personas= reader["cant_personas"] is DBNull ? 0 : (int)reader["cant_personas"];
                        habitacion.Estado_descripcion = reader["estado_habitacion"] as string ?? string.Empty;

                        habList.Add(habitacion);
                        }
                    }
                }
            return habList;
        }
        

        public void Add(HabitacionesModels habitacion)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into habitacion(nro_habitacion, cant_camas, precio_unitario, descripcion, tipo, id_piso, id_estado, cant_personas) values(@nro_habitacion, @cant_camas, @precio_unitario, @descripcion, @tipo, @id_piso, @id_estado, @cant_personas)";
                command.Parameters.Add("@nro_habitacion", SqlDbType.Int).Value = habitacion.Nro_habitacion;
                command.Parameters.Add("@cant_camas", SqlDbType.Int).Value = habitacion.Cant_camas;
                command.Parameters.Add("@precio_unitario", SqlDbType.Float).Value = habitacion.Precio_unitario;
                command.Parameters.Add("@descripcion", SqlDbType.VarChar, 100).Value = habitacion.Descripcion;
                command.Parameters.Add("@tipo", SqlDbType.VarChar, 100).Value = habitacion.Tipo;
                command.Parameters.Add("@id_piso", SqlDbType.Int).Value = habitacion.Id_piso;
                command.Parameters.Add("@cant_personas", SqlDbType.Int).Value = habitacion.Id_piso;
                command.Parameters.Add("@id_estado", SqlDbType.Int).Value = habitacion.Id_estado;
                command.ExecuteNonQuery();

            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"delete from habitacion
                                      where nro_habitacion=@nro_habitacion ";
                command.Parameters.Add("@nro_habitacion", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();

            }
        }

        public void Edit(HabitacionesModels habitacionesModels)
        {
           
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;

                var camposSet = new List<string>{
                
                    "cant_camas = @cant_camas",
                    "precio_unitario = @precio_unitario",
                    "tipo = @tipo",
                    "id_piso = @id_piso",
                    "descripcion = @descripcion",
                    "id_estado = @id_estado"
                     };

                string query = $"UPDATE habitacion SET {string.Join(", ", camposSet)} WHERE nro_habitacion = @nro_habitacion";
                command.CommandText = query;

                command.Parameters.Add("@nro_habitacion", SqlDbType.Int).Value = habitacionesModels.Nro_habitacion;
                command.Parameters.Add("@cant_camas", SqlDbType.Int).Value = habitacionesModels.Cant_camas;
                command.Parameters.Add("@precio_unitario", SqlDbType.Float).Value = habitacionesModels.Precio_unitario;
                command.Parameters.Add("@descripcion", SqlDbType.NVarChar, 200).Value = habitacionesModels.Descripcion;
                command.Parameters.Add("@tipo", SqlDbType.NVarChar, 100).Value = habitacionesModels.Tipo;
                command.Parameters.Add("@id_piso", SqlDbType.Int).Value = habitacionesModels.Id_piso;
                command.Parameters.Add("@cant_personas", SqlDbType.Int).Value = habitacionesModels.Id_piso;
                command.Parameters.Add("@id_estado", SqlDbType.Int).Value = habitacionesModels.Id_estado;
                command.ExecuteNonQuery();

                }
            
        }

      
        public IEnumerable<HabitacionesModels> GetByValue(string value)
        {
            var habList = new List<HabitacionesModels>();
            int nroHabitacion = int.TryParse(value, out var id) ? id : 0;
            string habitacionNro = value;

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"
            SELECT h.*, 
                   t.tipo AS tipo_habitacion,
                   e.descripcion AS estado_habitacion,
                   p.id_piso AS piso_habitacion
            FROM habitacion h
            INNER JOIN tipo_habitacion t ON t.tipo = h.tipo
            INNER JOIN estado_habitacion e ON e.id_estado = h.id_estado
            INNER JOIN piso p ON p.id_piso = h.id_piso
            WHERE h.nro_habitacion = @nro_habitacion";

                command.Parameters.Add("@nro_habitacion", SqlDbType.Int).Value = nroHabitacion;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var habitacion = new HabitacionesModels();
                        habitacion.Nro_habitacion = reader["nro_habitacion"] is DBNull ? 0 : (int)reader["nro_habitacion"];
                        habitacion.Cant_camas = reader["cant_camas"] is DBNull ? 0 : (int)reader["cant_camas"];
                        habitacion.Precio_unitario = reader["precio_unitario"] != DBNull.Value ? Convert.ToSingle(reader["precio_unitario"]) : 0f;
                        habitacion.Descripcion = reader["descripcion"] as string ?? string.Empty;
                        habitacion.Tipo = reader["tipo_habitacion"] as string ?? string.Empty;
                        habitacion.Id_piso = reader["piso_habitacion"] is DBNull ? 0 : (int)reader["piso_habitacion"];
                        habitacion.Id_estado = reader["id_estado"] is DBNull ? 0 : (int)reader["id_estado"];
                        habitacion.Cant_personas = reader["cant_personas"] is DBNull ? 0 : (int)reader["cant_personas"];
                        habitacion.Estado_descripcion = reader["estado_habitacion"] as string ?? string.Empty;

                        habList.Add(habitacion);
                    }
                }

            }
            return habList;
        }


        public IEnumerable<HabitacionesModels> GetAllDisponible()
        {
            var habList = new List<HabitacionesModels>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"
                 SELECT h.*, 
                 t.tipo AS tipo_habitacion,
                 e.descripcion AS estado_habitacion,
                 p.id_piso AS piso_habitacion
                 FROM habitacion h
                 INNER JOIN tipo_habitacion t ON t.tipo = h.tipo
                 INNER JOIN estado_habitacion e ON e.id_estado = h.id_estado
                 INNER JOIN piso p ON p.id_piso = h.id_piso
                 WHERE h.id_estado = 1
                 ORDER BY h.tipo DESC;";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var habitacion = new HabitacionesModels();

                        habitacion.Nro_habitacion = reader["nro_habitacion"] is DBNull ? 0 : (int)reader["nro_habitacion"];
                        habitacion.Cant_camas = reader["cant_camas"] is DBNull ? 0 : (int)reader["cant_camas"];
                        habitacion.Precio_unitario = reader["precio_unitario"] != DBNull.Value ? Convert.ToSingle(reader["precio_unitario"]): 0f;

                        habitacion.Descripcion = reader["descripcion"] as string ?? string.Empty;
                        habitacion.Tipo = reader["tipo_habitacion"] as string ?? string.Empty;
                        habitacion.Id_piso = reader["piso_habitacion"] is DBNull ? 0 : (int)reader["piso_habitacion"];
                        habitacion.Id_estado = reader["id_estado"] is DBNull ? 0 : (int)reader["id_estado"];
                        habitacion.Cant_personas = reader["cant_personas"] is DBNull ? 0 : (int)reader["cant_personas"];
                        habitacion.Estado_descripcion = reader["estado_habitacion"] as string ?? string.Empty;

                        habList.Add(habitacion);
                    }
                }
            }
            return habList;
        }

        public IEnumerable<HabitacionesModels> GetAllOcupadas()
        {
            var habList = new List<HabitacionesModels>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"
                 SELECT h.*, 
                 t.tipo AS tipo_habitacion,
                 e.descripcion AS estado_habitacion,
                 p.id_piso AS piso_habitacion
                 FROM habitacion h
                 INNER JOIN tipo_habitacion t ON t.tipo = h.tipo
                 INNER JOIN estado_habitacion e ON e.id_estado = h.id_estado
                 INNER JOIN piso p ON p.id_piso = h.id_piso
                 WHERE h.id_estado = 3
                 ORDER BY h.tipo DESC;";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var habitacion = new HabitacionesModels();

                        habitacion.Nro_habitacion = reader["nro_habitacion"] is DBNull ? 0 : (int)reader["nro_habitacion"];
                        habitacion.Cant_camas = reader["cant_camas"] is DBNull ? 0 : (int)reader["cant_camas"];
                        habitacion.Precio_unitario = reader["precio_unitario"] != DBNull.Value ? Convert.ToSingle(reader["precio_unitario"]) : 0f;

                        habitacion.Descripcion = reader["descripcion"] as string ?? string.Empty;
                        habitacion.Tipo = reader["tipo_habitacion"] as string ?? string.Empty;
                        habitacion.Id_piso = reader["piso_habitacion"] is DBNull ? 0 : (int)reader["piso_habitacion"];
                        habitacion.Id_estado = reader["id_estado"] is DBNull ? 0 : (int)reader["id_estado"];
                        habitacion.Cant_personas = reader["cant_personas"] is DBNull ? 0 : (int)reader["cant_personas"];
                        habitacion.Estado_descripcion = reader["estado_habitacion"] as string ?? string.Empty;

                        habList.Add(habitacion);
                    }
                }
            }
            return habList;
        }

        public IEnumerable<HabitacionesModels> GetAllMantenimiento()
        {
            var habList = new List<HabitacionesModels>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"
                 SELECT h.*, 
                 t.tipo AS tipo_habitacion,
                 e.descripcion AS estado_habitacion,
                 p.id_piso AS piso_habitacion
                 FROM habitacion h
                 INNER JOIN tipo_habitacion t ON t.tipo = h.tipo
                 INNER JOIN estado_habitacion e ON e.id_estado = h.id_estado
                 INNER JOIN piso p ON p.id_piso = h.id_piso
                 WHERE h.id_estado = 2
                 ORDER BY h.tipo DESC;";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var habitacion = new HabitacionesModels();

                        habitacion.Nro_habitacion = reader["nro_habitacion"] is DBNull ? 0 : (int)reader["nro_habitacion"];
                        habitacion.Cant_camas = reader["cant_camas"] is DBNull ? 0 : (int)reader["cant_camas"];
                        habitacion.Precio_unitario = reader["precio_unitario"] != DBNull.Value ? Convert.ToSingle(reader["precio_unitario"]) : 0f;

                        habitacion.Descripcion = reader["descripcion"] as string ?? string.Empty;
                        habitacion.Tipo = reader["tipo_habitacion"] as string ?? string.Empty;
                        habitacion.Id_piso = reader["piso_habitacion"] is DBNull ? 0 : (int)reader["piso_habitacion"];
                        habitacion.Id_estado = reader["id_estado"] is DBNull ? 0 : (int)reader["id_estado"];
                        habitacion.Cant_personas = reader["cant_personas"] is DBNull ? 0 : (int)reader["cant_personas"];
                        habitacion.Estado_descripcion = reader["estado_habitacion"] as string ?? string.Empty;

                        habList.Add(habitacion);
                    }
                }
            }
            return habList;
        }
    }
        }
