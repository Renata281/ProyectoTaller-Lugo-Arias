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
        private int rowsAffected;

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
                 INNER JOIN tipo_habitacion t ON t.id_tipo = h.id_tipo
                 INNER JOIN estado_habitacion e ON e.id_estado = h.id_estado
                 INNER JOIN piso p ON p.id_piso = h.id_piso
                 ORDER BY tipo_habitacion DESC;";
                using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                        var habitacion = new HabitacionesModels();

                        habitacion.Nro_habitacion = reader["nro_habitacion"] is DBNull ? 0 : (int)reader["nro_habitacion"];
                        habitacion.Cant_camas = reader["cant_camas"] is DBNull ? 0 : (int)reader["cant_camas"];
                        habitacion.Precio_unitario = reader["precio_unitario"] != DBNull.Value ? Convert.ToDecimal(reader["precio_unitario"]) : 0m;
                        habitacion.Id_tipo = reader["id_tipo"] is DBNull ? 0 : (int)reader["id_tipo"];
                        habitacion.Tipo_descripcion = reader["tipo_habitacion"] as string ?? string.Empty;
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
            if (habitacion.Cant_personas <= 0)
                throw new Exception("La cantidad de personas debe ser mayor que 0.");

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into habitacion(nro_habitacion, cant_camas, precio_unitario, id_tipo, id_piso, id_estado, cant_personas) values(@nro_habitacion, @cant_camas, @precio_unitario, @id_tipo, @id_piso, @id_estado, @cant_personas)";
                command.Parameters.Add("@nro_habitacion", SqlDbType.Int).Value = habitacion.Nro_habitacion;
                command.Parameters.Add("@cant_camas", SqlDbType.Int).Value = habitacion.Cant_camas;
                command.Parameters.Add("@precio_unitario", SqlDbType.Decimal).Value = habitacion.Precio_unitario;
                command.Parameters.Add("@id_tipo", SqlDbType.Int).Value = habitacion.Id_tipo;
                command.Parameters.Add("@id_piso", SqlDbType.Int).Value = habitacion.Id_piso;
                command.Parameters.Add("@cant_personas", SqlDbType.Int).Value = habitacion.Cant_personas;
                command.Parameters.Add("@id_estado", SqlDbType.Int).Value = habitacion.Id_estado;
                command.ExecuteNonQuery();

            }
        }

        public void Delete(int id, int idPiso)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"delete from habitacion
                                      where nro_habitacion=@nro_habitacion AND id_piso = @id_piso";
                command.Parameters.Add("@nro_habitacion", SqlDbType.Int).Value = id;
                command.Parameters.Add("@id_piso", SqlDbType.Int).Value = idPiso;
                command.ExecuteNonQuery();

            }
        }

        public void Edit(HabitacionesModels habitacionesModels)
        {
            if (habitacionesModels.Cant_personas <= 0)
                throw new Exception("La cantidad de personas debe ser mayor que 0.");

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                var camposSet = new List<string>{
            "cant_camas = @cant_camas",
            "precio_unitario = @precio_unitario",
            "id_tipo = @id_tipo",
            "id_estado = @id_estado",
            "cant_personas = @cant_personas"
        };

                string query = $"UPDATE habitacion SET {string.Join(", ", camposSet)} WHERE nro_habitacion = @nro_habitacion AND id_piso = @id_piso";
                command.CommandText = query;

                command.Parameters.Add("@nro_habitacion", SqlDbType.Int).Value = habitacionesModels.Nro_habitacion;
                command.Parameters.Add("@cant_camas", SqlDbType.Int).Value = habitacionesModels.Cant_camas;
                command.Parameters.Add("@precio_unitario", SqlDbType.Decimal).Value = habitacionesModels.Precio_unitario;
                command.Parameters.Add("@id_tipo", SqlDbType.Int).Value = habitacionesModels.Id_tipo;
                command.Parameters.Add("@id_piso", SqlDbType.Int).Value = habitacionesModels.Id_piso;
                command.Parameters.Add("@cant_personas", SqlDbType.Int).Value = habitacionesModels.Cant_personas;
                command.Parameters.Add("@id_estado", SqlDbType.Int).Value = habitacionesModels.Id_estado;

                int rowsAffected = command.ExecuteNonQuery(); // <- aquí asignamos correctamente
                if (rowsAffected == 0)
                {
                    throw new Exception($"No se encontró la habitación {habitacionesModels.Nro_habitacion} en el piso {habitacionesModels.Id_piso} para actualizar.");
                }
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
            INNER JOIN tipo_habitacion t ON t.id_tipo = h.id_tipo
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
                        habitacion.Precio_unitario = reader["precio_unitario"] != DBNull.Value ? Convert.ToDecimal(reader["precio_unitario"]) : 0m;
                        habitacion.Id_tipo = reader["id_tipo"] is DBNull ? 0 : (int)reader["id_tipo"];
                        habitacion.Tipo_descripcion = reader["tipo_habitacion"] as string ?? string.Empty;
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
                 INNER JOIN tipo_habitacion t ON t.id_tipo = h.id_tipo
                 INNER JOIN estado_habitacion e ON e.id_estado = h.id_estado
                 INNER JOIN piso p ON p.id_piso = h.id_piso
                 WHERE h.id_estado = 1
                 ORDER BY t.tipo DESC;";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var habitacion = new HabitacionesModels();

                        habitacion.Nro_habitacion = reader["nro_habitacion"] is DBNull ? 0 : (int)reader["nro_habitacion"];
                        habitacion.Cant_camas = reader["cant_camas"] is DBNull ? 0 : (int)reader["cant_camas"];
                        habitacion.Precio_unitario = reader["precio_unitario"] != DBNull.Value ? Convert.ToDecimal(reader["precio_unitario"]) : 0m;
                        habitacion.Id_tipo = reader["id_tipo"] is DBNull ? 0 : (int)reader["id_tipo"];
                        habitacion.Tipo_descripcion = reader["tipo_habitacion"] as string ?? string.Empty;
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
                 INNER JOIN tipo_habitacion t ON t.id_tipo = h.id_tipo
                 INNER JOIN estado_habitacion e ON e.id_estado = h.id_estado
                 INNER JOIN piso p ON p.id_piso = h.id_piso
                 WHERE h.id_estado = 3
                 ORDER BY t.tipo DESC;";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var habitacion = new HabitacionesModels();

                        habitacion.Nro_habitacion = reader["nro_habitacion"] is DBNull ? 0 : (int)reader["nro_habitacion"];
                        habitacion.Cant_camas = reader["cant_camas"] is DBNull ? 0 : (int)reader["cant_camas"];
                        habitacion.Precio_unitario = reader["precio_unitario"] != DBNull.Value ? Convert.ToDecimal(reader["precio_unitario"]) : 0m;
                        habitacion.Id_tipo = reader["id_tipo"] is DBNull ? 0 : (int)reader["id_tipo"];
                        habitacion.Tipo_descripcion = reader["tipo_habitacion"] as string ?? string.Empty;
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
                 INNER JOIN tipo_habitacion t ON t.id_tipo = h.id_tipo
                 INNER JOIN estado_habitacion e ON e.id_estado = h.id_estado
                 INNER JOIN piso p ON p.id_piso = h.id_piso
                 WHERE h.id_estado = 2
                 ORDER BY t.tipo DESC;";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var habitacion = new HabitacionesModels();

                        habitacion.Nro_habitacion = reader["nro_habitacion"] is DBNull ? 0 : (int)reader["nro_habitacion"];
                        habitacion.Cant_camas = reader["cant_camas"] is DBNull ? 0 : (int)reader["cant_camas"];
                        habitacion.Precio_unitario = reader["precio_unitario"] != DBNull.Value ? Convert.ToDecimal(reader["precio_unitario"]) : 0m;
                        habitacion.Id_tipo = reader["id_tipo"] is DBNull ? 0 : (int)reader["id_tipo"];
                        habitacion.Tipo_descripcion = reader["tipo_habitacion"] as string ?? string.Empty;
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

        public void ActualizarEstado(int nroHabitacion, int idPiso, int idEstado)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand(
                "UPDATE habitacion SET id_estado = @id_estado WHERE nro_habitacion = @nro_habitacion AND id_piso = @id_piso",
                connection))
            {
                command.Parameters.Add("@id_estado", SqlDbType.Int).Value = idEstado;
                command.Parameters.Add("@nro_habitacion", SqlDbType.Int).Value = nroHabitacion;
                command.Parameters.Add("@id_piso", SqlDbType.Int).Value = idPiso;

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<HabitacionesModels> GetHabitacionesDisponibles(int idTipo, int cantPersonas, DateTime fechaIngreso, DateTime fechaSalida)
        {
            var habitaciones = new List<HabitacionesModels>();
            using var connection = new SqlConnection(connectionString);
            using var command = new SqlCommand(@"
            SELECT h.nro_habitacion, h.id_tipo, t.tipo, h.cant_personas, h.precio_unitario, h.id_piso
            FROM habitacion h
            INNER JOIN tipo_habitacion t ON h.id_tipo = t.id_tipo
            WHERE h.id_tipo = @idTipo
              AND h.cant_personas >= @cantPersonas
              AND h.nro_habitacion NOT IN (
                    SELECT r.nro_habitacion 
                    FROM reserva r
                    WHERE r.fecha_ingreso < @fechaSalida
                      AND r.fecha_salida > @fechaIngreso
              )", connection);

            command.Parameters.AddWithValue("@idTipo", idTipo);
            command.Parameters.AddWithValue("@cantPersonas", cantPersonas);
            command.Parameters.AddWithValue("@fechaIngreso", fechaIngreso);
            command.Parameters.AddWithValue("@fechaSalida", fechaSalida);

            connection.Open();
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                habitaciones.Add(new HabitacionesModels
                {
                    Nro_habitacion = Convert.ToInt32(reader["nro_habitacion"]),
                    Tipo_descripcion = reader["tipo"].ToString(),
                    Cant_personas = Convert.ToInt32(reader["cant_personas"]),
                    Precio_unitario = Convert.ToDecimal(reader["precio_unitario"]),
                    Id_piso = Convert.ToInt32(reader["id_piso"])
                });
            }
            return habitaciones;
        }

    }
}
