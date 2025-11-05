using System.Data.SqlClient;
using ProyectoTaller_Lugo_Arias.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ProyectoTaller_Lugo_Arias.Repositorio
{
    public class ReservaRepositorio : BaseRepositorio, IReservaRepositorio
    {
        // Constructor
        public ReservaRepositorio(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // --- CRUD RESERVAS ---

        public void Add(ReservaModel reserva)
        {
            reserva.ValidarFechas();
            if (reserva.Id_tipo <= 0)
                throw new Exception("Debe seleccionar un tipo de habitación válido.");
            reserva.CalcularEstado();
            reserva.Monto_total = CalcularMontoTotal(reserva.Nro_habitacion, reserva.Fecha_ingreso, reserva.Fecha_salida);
            if (reserva.Monto_total <= 0)
                throw new Exception("El monto total calculado no puede ser cero o negativo.");

            using var connection = new SqlConnection(connectionString);
            using var command = new SqlCommand
            {
                Connection = connection,
                CommandText = @"
                    INSERT INTO reserva
                        (fecha_ingreso, fecha_salida, monto_total, id_cliente, nro_habitacion, id_piso, id_pago, cant_personas, estado, id_tipo)
                    VALUES
                        (@fecha_ingreso, @fecha_salida, @monto_total, @id_cliente, @nro_habitacion, @id_piso, @id_pago, @cant_personas, @estado, @id_tipo);"
            };

            command.Parameters.Add("@fecha_ingreso", SqlDbType.Date).Value = reserva.Fecha_ingreso;
            command.Parameters.Add("@fecha_salida", SqlDbType.Date).Value = reserva.Fecha_salida;
            command.Parameters.Add("@monto_total", SqlDbType.Decimal).Value = reserva.Monto_total;
            command.Parameters.Add("@id_cliente", SqlDbType.Int).Value = reserva.Id_cliente;
            command.Parameters.Add("@nro_habitacion", SqlDbType.Int).Value = reserva.Nro_habitacion;
            command.Parameters.Add("@id_piso", SqlDbType.Int).Value = reserva.Id_piso;
            command.Parameters.Add("@id_pago", SqlDbType.Int).Value = reserva.Id_pago;
            command.Parameters.Add("@cant_personas", SqlDbType.Int).Value = reserva.Cant_personas;
            command.Parameters.Add("@estado", SqlDbType.VarChar).Value = reserva.Estado;
            command.Parameters.Add("@id_tipo", SqlDbType.Int).Value = reserva.Id_tipo;

            connection.Open();
            command.ExecuteNonQuery();
        }

        public void Edit(ReservaModel reserva)
        {
            reserva.ValidarFechas();
            if (reserva.Id_tipo <= 0)
                throw new Exception("Debe seleccionar un tipo de habitación válido.");
            reserva.CalcularEstado();
            reserva.Monto_total = CalcularMontoTotal(reserva.Nro_habitacion, reserva.Fecha_ingreso, reserva.Fecha_salida);
            if (reserva.Monto_total <= 0)
                throw new Exception("El monto total calculado no puede ser cero o negativo.");

            using var connection = new SqlConnection(connectionString);
            using var command = new SqlCommand { Connection = connection };

            var camposSet = new List<string>
            {
                "fecha_ingreso = @fecha_ingreso",
                "fecha_salida = @fecha_salida",
                "id_cliente = @id_cliente",
                "nro_habitacion = @nro_habitacion",
                "id_piso = @id_piso",
                "cant_personas = @cant_personas",
                "monto_total = @monto_total",
                "estado = @estado",
                "id_pago = @id_pago",
                "id_tipo = @id_tipo"
            };

            command.CommandText = $"UPDATE reserva SET {string.Join(", ", camposSet)} WHERE nro_reserva = @nro_reserva";

            command.Parameters.Add("@fecha_ingreso", SqlDbType.Date).Value = reserva.Fecha_ingreso;
            command.Parameters.Add("@fecha_salida", SqlDbType.Date).Value = reserva.Fecha_salida;
            command.Parameters.Add("@id_cliente", SqlDbType.Int).Value = reserva.Id_cliente;
            command.Parameters.Add("@nro_habitacion", SqlDbType.Int).Value = reserva.Nro_habitacion;
            command.Parameters.Add("@id_piso", SqlDbType.Int).Value = reserva.Id_piso;
            command.Parameters.Add("@cant_personas", SqlDbType.Int).Value = reserva.Cant_personas;
            command.Parameters.Add("@monto_total", SqlDbType.Decimal).Value = reserva.Monto_total;
            command.Parameters.Add("@estado", SqlDbType.VarChar, 50).Value = reserva.Estado;
            command.Parameters.Add("@id_pago", SqlDbType.Int).Value = reserva.Id_pago;
            command.Parameters.Add("@nro_reserva", SqlDbType.Int).Value = reserva.Nro_reserva;
            command.Parameters.Add("@id_tipo", SqlDbType.Int).Value = reserva.Id_tipo;

            connection.Open();
            command.ExecuteNonQuery();
        }

        public void Delete(int nro_reserva)
        {
            using var connection = new SqlConnection(connectionString);
            using var command = new SqlCommand("DELETE FROM reserva WHERE nro_reserva = @nro_reserva", connection);
            command.Parameters.Add("@nro_reserva", SqlDbType.Int).Value = nro_reserva;
            connection.Open();
            command.ExecuteNonQuery();
        }

        public ReservaModel GetById(int nro_reserva)
        {
            using var connection = new SqlConnection(connectionString);
            using var command = new SqlCommand("SELECT * FROM reserva WHERE nro_reserva = @nro_reserva", connection);
            command.Parameters.Add("@nro_reserva", SqlDbType.Int).Value = nro_reserva;
            connection.Open();

            using var reader = command.ExecuteReader();
            if (reader.Read())
                return MapToReserva(reader);

            return null;
        }

        public IEnumerable<ReservaModel> GetAll()
        {
            return EjecutarConsultaReserva("SELECT * FROM reserva ORDER BY nro_reserva DESC");
        }

        public IEnumerable<ReservaModel> GetByValue(string valorBusqueda)
        {
            string query = @"
                            SELECT r.*
                            FROM reserva r
                            INNER JOIN cliente c ON r.id_cliente = c.id_cliente
                            WHERE 
                                (
                                    CAST(r.nro_reserva AS NVARCHAR) LIKE @valor
                                    OR CAST(c.dni AS NVARCHAR) LIKE @valor
                                )
                            ORDER BY r.nro_reserva ASC";

            return EjecutarConsultaReserva(query, new SqlParameter("@valor", "%" + valorBusqueda + "%"));
        }

        public IEnumerable<ReservaModel> GetAllActivas()
        {
            string query = "SELECT * FROM reserva WHERE fecha_ingreso <= @hoy AND fecha_salida >= @hoy ORDER BY nro_reserva DESC";
            return EjecutarConsultaReserva(query, new SqlParameter("@hoy", DateTime.Today));
        }

        public IEnumerable<ReservaModel> GetAllPendientes()
        {
            string query = "SELECT * FROM reserva WHERE fecha_ingreso > @hoy ORDER BY nro_reserva DESC";
            return EjecutarConsultaReserva(query, new SqlParameter("@hoy", DateTime.Today));
        }

        public IEnumerable<ReservaModel> GetAllFinalizadas()
        {
            string query = "SELECT * FROM reserva WHERE fecha_salida < @hoy ORDER BY nro_reserva DESC";
            return EjecutarConsultaReserva(query, new SqlParameter("@hoy", DateTime.Today));
        }

        // --- HABITACIONES DISPONIBLES ---

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

            command.Parameters.Add("@idTipo", SqlDbType.Int).Value = idTipo;
            command.Parameters.Add("@cantPersonas", SqlDbType.Int).Value = cantPersonas;
            command.Parameters.Add("@fechaIngreso", SqlDbType.Date).Value = fechaIngreso;
            command.Parameters.Add("@fechaSalida", SqlDbType.Date).Value = fechaSalida;

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

        public decimal CalcularMontoTotal(int nro_habitacion, DateTime fecha_ingreso, DateTime fecha_salida)
        {
            decimal precioUnitario = 0;
            using var connection = new SqlConnection(connectionString);
            using var command = new SqlCommand("SELECT precio_unitario FROM habitacion WHERE nro_habitacion = @nro", connection);
            command.Parameters.Add("@nro", SqlDbType.Int).Value = nro_habitacion;
            connection.Open();

            var result = command.ExecuteScalar();
            if (result != null && result != DBNull.Value)
                precioUnitario = Convert.ToDecimal(result);

            int dias = (fecha_salida - fecha_ingreso).Days;
            if (dias <= 0) dias = 1;
            return precioUnitario * dias;
        }

        // --- MÉTODOS AUXILIARES ---

        private ReservaModel MapToReserva(SqlDataReader reader)
        {
            return new ReservaModel
            {
                Nro_reserva = Convert.ToInt32(reader["nro_reserva"]),
                Fecha_ingreso = Convert.ToDateTime(reader["fecha_ingreso"]),
                Fecha_salida = Convert.ToDateTime(reader["fecha_salida"]),
                Cant_personas = Convert.ToInt32(reader["cant_personas"]),
                Monto_total = Convert.ToDecimal(reader["monto_total"]),
                Id_cliente = Convert.ToInt32(reader["id_cliente"]),
                Nro_habitacion = Convert.ToInt32(reader["nro_habitacion"]),
                Id_pago = Convert.ToInt32(reader["id_pago"]),
                Estado = reader["estado"].ToString(),
                Id_piso = Convert.ToInt32(reader["id_piso"]),
                Id_tipo = Convert.ToInt32(reader["id_tipo"])
            };
        }

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

