using System.Data.SqlClient;
using ProyectoTaller_Lugo_Arias.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProyectoTaller_Lugo_Arias.Repositorio
{
    public class ReservaRepositorio : BaseRepositorio, IReservaRepositorio
    {
        //constructor
        public ReservaRepositorio(string connectionString)
        {
            this.connectionString = connectionString;
        }

        //metodos
        public void Add(ReservaModel reserva)
        {
            reserva.ValidarFechas();
            reserva.CalcularEstado();
            reserva.Monto_total = CalcularMontoTotal(reserva.Nro_habitacion, reserva.Fecha_ingreso, reserva.Fecha_salida);
            if (reserva.Monto_total <= 0)
                throw new Exception("El monto total calculado no puede ser cero o negativo.");

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"
                    INSERT INTO reserva
                        (fecha_ingreso, fecha_salida, monto_total, id_cliente, nro_habitacion, id_piso, id_pago, cant_personas, estado)
                    VALUES
                        (@fecha_ingreso, @fecha_salida, @monto_total, @id_cliente, @nro_habitacion, @id_piso, @id_pago, @cant_personas, 'Pendiente');";
                command.Parameters.Add("@fecha_ingreso", SqlDbType.Date).Value = reserva.Fecha_ingreso;
                command.Parameters.Add("@fecha_salida", SqlDbType.Date).Value = reserva.Fecha_salida;
                command.Parameters.Add("@monto_total", SqlDbType.Decimal).Value = reserva.Monto_total;
                command.Parameters.Add("@id_cliente", SqlDbType.Int).Value = reserva.Id_cliente;
                command.Parameters.Add("@nro_habitacion", SqlDbType.Int).Value = reserva.Nro_habitacion;
                command.Parameters.Add("@id_piso", SqlDbType.Int).Value = reserva.Id_piso;
                command.Parameters.Add("@id_pago", SqlDbType.Int).Value = reserva.Id_pago;
                command.Parameters.Add("@cant_personas", SqlDbType.Int).Value = reserva.Cant_personas;
                command.ExecuteNonQuery();

            }
        }

        public void Delete(int nro_reserva)
        {
            using var connection = new SqlConnection(connectionString);
            using var command = new SqlCommand
            {
                Connection = connection,
                CommandText = "DELETE FROM reserva WHERE nro_reserva = @nro_reserva"
            };

            command.Parameters.Add("@nro_reserva", SqlDbType.Int).Value = nro_reserva;
            connection.Open();
            command.ExecuteNonQuery();
        }

        public void Edit(ReservaModel reserva)
        {
            reserva.ValidarFechas();
            reserva.CalcularEstado();
            reserva.Monto_total = CalcularMontoTotal(reserva.Nro_habitacion, reserva.Fecha_ingreso, reserva.Fecha_salida);
            if (reserva.Monto_total <= 0)
                throw new Exception("El monto total calculado no puede ser cero o negativo.");

            using var connection = new SqlConnection(connectionString);
            using var command = new SqlCommand();
            connection.Open();
            command.Connection = connection;

            // Construir campos SET dinámicamente
            var camposSet = new List<string>
            {
                 "fecha_ingreso = @fecha_ingreso",
                 "fecha_salida = @fecha_salida",
                 "id_cliente = @id_cliente",
                 "nro_habitacion = @nro_habitacion",
                 "id_piso = @id_piso",
                 "cant_personas = @cant_personas"
             };

            // Actualizar monto_total solo si tiene valor > 0
            if (reserva.Monto_total > 0)
                camposSet.Add("monto_total = @monto_total");

            // Actualizar estado si no es null o vacío
            if (!string.IsNullOrEmpty(reserva.Estado))
                camposSet.Add("estado = @estado");

            // Actualizar id_pago solo si es diferente de 0
            if (reserva.Id_pago != 0)
                camposSet.Add("id_pago = @id_pago");

            string query = $"UPDATE reserva SET {string.Join(", ", camposSet)} WHERE nro_reserva = @nro_reserva";
            command.CommandText = query;

            // Parámetros comunes
            command.Parameters.Add("@fecha_ingreso", SqlDbType.Date).Value = reserva.Fecha_ingreso;
            command.Parameters.Add("@fecha_salida", SqlDbType.Date).Value = reserva.Fecha_salida;
            command.Parameters.Add("@id_cliente", SqlDbType.Int).Value = reserva.Id_cliente;
            command.Parameters.Add("@nro_habitacion", SqlDbType.Int).Value = reserva.Nro_habitacion;
            command.Parameters.Add("@id_piso", SqlDbType.Int).Value = reserva.Id_piso;
            command.Parameters.Add("@cant_personas", SqlDbType.Int).Value = reserva.Cant_personas;
            command.Parameters.Add("@nro_reserva", SqlDbType.Int).Value = reserva.Nro_reserva;

            if (camposSet.Contains("monto_total = @monto_total"))
                command.Parameters.Add("@monto_total", SqlDbType.Decimal).Value = reserva.Monto_total;

            if (camposSet.Contains("estado = @estado"))
                command.Parameters.Add("@estado", SqlDbType.VarChar, 50).Value = reserva.Estado;

            if (camposSet.Contains("id_pago = @id_pago"))
                command.Parameters.Add("@id_pago", SqlDbType.Int).Value = reserva.Id_pago;

            command.ExecuteNonQuery();
        }

        public IEnumerable<ReservaModel> GetAll()
        {
            var reservas = new List<ReservaModel>();
            using var connection = new SqlConnection(connectionString);
            using var command = new SqlCommand("SELECT * FROM reserva ORDER BY nro_reserva DESC", connection);
            connection.Open();

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                reservas.Add(MapToReserva(reader));
            }

            return reservas;
        }

        private ReservaModel MapToReserva(SqlDataReader reader)
        {
            return new ReservaModel
            {
                Nro_reserva = Convert.ToInt32(reader["nro_reserva"]),
                Fecha_ingreso = Convert.ToDateTime(reader["fecha_ingreso"]),
                Fecha_salida = Convert.ToDateTime(reader["fecha_salida"]),
                Cant_personas = Convert.ToInt32(reader["cant_personas"]),
                Monto_total = Convert.ToSingle(reader["monto_total"]),
                Id_cliente = Convert.ToInt32(reader["id_cliente"]),
                Nro_habitacion = Convert.ToInt32(reader["nro_habitacion"]),
                Id_pago = Convert.ToInt32(reader["id_pago"]),
                Estado = reader["estado"].ToString(),
                Id_piso = Convert.ToInt32(reader["id_piso"])
            };
        }


        public ReservaModel GetById(int nro_reserva)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand("SELECT * FROM reserva WHERE nro_reserva = @nro_reserva", connection))
            {
                command.Parameters.Add("@nro_reserva", SqlDbType.Int).Value = nro_reserva;
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                        return MapToReserva(reader);
                }
            }
            return null;
        }

        public IEnumerable<ReservaModel> GetByValue(string valorBusqueda)
        {
            var reservas = new List<ReservaModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand(
                "SELECT * FROM reserva r INNER JOIN cliente c ON r.id_cliente = c.id_cliente " +
                "WHERE c.nombre LIKE @valor OR c.apellido LIKE @valor", connection))
            {
                command.Parameters.Add("@valor", SqlDbType.VarChar, 100).Value = $"%{valorBusqueda}%";
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        reservas.Add(MapToReserva(reader));
                }
            }
            return reservas;
        }

        public IEnumerable<HabitacionesModels> GetHabitacionesDisponibles(string tipo, int cant_personas, DateTime fecha_ingreso, DateTime fecha_salida)
        {
            var habitaciones = new List<HabitacionesModels>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand(@"
                SELECT * FROM habitacion h
                WHERE h.tipo = @tipo
                  AND h.cant_personas >= @cant_personas
                  AND h.nro_habitacion NOT IN (
                        SELECT nro_habitacion FROM reserva
                        WHERE fecha_ingreso < @fecha_salida
                          AND fecha_salida > @fecha_ingreso
                  )", connection))
            {
                command.Parameters.Add("@tipo", SqlDbType.VarChar, 50).Value = tipo;
                command.Parameters.Add("@cant_personas", SqlDbType.Int).Value = cant_personas;
                command.Parameters.Add("@fecha_ingreso", SqlDbType.Date).Value = fecha_ingreso;
                command.Parameters.Add("@fecha_salida", SqlDbType.Date).Value = fecha_salida;

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        habitaciones.Add(new HabitacionesModels
                        {
                            Nro_habitacion = Convert.ToInt32(reader["nro_habitacion"]),
                            Tipo_descripcion = reader["tipo"].ToString(),
                            Cant_personas = Convert.ToInt32(reader["cant_personas"]),
                            Precio_unitario = Convert.ToSingle(reader["precio_unitario"]),
                            Id_piso = Convert.ToInt32(reader["id_piso"])
                        });
                    }
                }
            }
            
            
            return habitaciones;
        }

        public float CalcularMontoTotal(int nro_habitacion, DateTime fecha_ingreso, DateTime fecha_salida)
        {
            float precioUnitario = 0;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand("SELECT precio_unitario FROM habitacion WHERE nro_habitacion = @nro", connection))
            {
                command.Parameters.Add("@nro", SqlDbType.Int).Value = nro_habitacion;
                connection.Open();
                var result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                    precioUnitario = Convert.ToSingle(result);
            }
            int dias = (fecha_salida - fecha_ingreso).Days;
            if (dias <= 0) dias = 1;
            return precioUnitario * dias;
        }

        public IEnumerable<ReservaModel> GetAllActivas()
        {
            string query = @"
        SELECT * FROM reserva
        WHERE fecha_ingreso <= @hoy AND fecha_salida >= @hoy
        ORDER BY nro_reserva DESC";

            return EjecutarConsultaReserva(query, new SqlParameter("@hoy", DateTime.Today));
        }

        public IEnumerable<ReservaModel> GetAllPendientes()
        {
            string query = @"
        SELECT * FROM reserva
        WHERE fecha_ingreso > @hoy
        ORDER BY nro_reserva DESC";

            return EjecutarConsultaReserva(query, new SqlParameter("@hoy", DateTime.Today));
        }

        public IEnumerable<ReservaModel> GetAllFinalizadas()
        {
            string query = @"
        SELECT * FROM reserva
        WHERE fecha_salida < @hoy
        ORDER BY nro_reserva DESC";

            return EjecutarConsultaReserva(query, new SqlParameter("@hoy", DateTime.Today));
        }

        // Método auxiliar privado que ejecuta cualquier query de reserva
        private List<ReservaModel> EjecutarConsultaReserva(string query, params SqlParameter[] parametros)
        {
            var reservas = new List<ReservaModel>();
            using var connection = new SqlConnection(connectionString);
            using var command = new SqlCommand(query, connection);

            if (parametros != null && parametros.Length > 0)
                command.Parameters.AddRange(parametros);

            connection.Open();
            using var reader = command.ExecuteReader();
            while (reader.Read())
                reservas.Add(MapToReserva(reader));

            return reservas;
        }

    }
}
