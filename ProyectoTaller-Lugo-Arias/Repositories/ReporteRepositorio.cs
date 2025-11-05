using ProyectoTaller_Lugo_Arias.Repositorio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Data.SqlClient;
using ProyectoTaller_Lugo_Arias.Models;

namespace ProyectoTaller_Lugo_Arias.Repositories
{
    public class ReporteRepositorio: BaseRepositorio, IReporteRepositorio
    {
        public ReporteRepositorio(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public DataTable GetMetodoPagoMasUsado(DateTime fechaInicio, DateTime fechaFin)
        {
            string query = @"SELECT fp.descripcion AS 'Forma de pago', COUNT(*) AS Cantidad
                            FROM reserva r
                            INNER JOIN forma_pago fp ON r.id_pago = fp.id_pago
                            WHERE r.fecha_ingreso BETWEEN @inicio AND @fin
                            GROUP BY fp.descripcion
                            ORDER BY Cantidad DESC";

            return EjecutarConsulta(query, fechaInicio, fechaFin);
        }

        public DataTable GetFacturacion(DateTime fechaInicio, DateTime fechaFin)
        {
            string query = @"
        SELECT r.nro_reserva, r.fecha_ingreso, r.fecha_salida, r.monto_total, c.nombre AS Cliente
        FROM reserva r
        INNER JOIN cliente c ON r.id_cliente = c.id_cliente
        WHERE r.fecha_ingreso BETWEEN @inicio AND @fin
        ORDER BY r.fecha_ingreso";

            DataTable tabla = EjecutarConsulta(query, fechaInicio, fechaFin);

            // Permitir nulls en las columnas que usaremos para la fila total
            string[] columnasPermitidasNull = { "nro_reserva", "fecha_ingreso", "fecha_salida" };
            foreach (string col in columnasPermitidasNull)
            {
                if (tabla.Columns.Contains(col))
                    tabla.Columns[col].AllowDBNull = true;
            }

            // Agregar fila con total
            if (tabla.Rows.Count > 0)
            {
                decimal total = 0;
                foreach (DataRow row in tabla.Rows)
                {
                    total += Convert.ToDecimal(row["monto_total"]);
                }

                DataRow totalRow = tabla.NewRow();
                totalRow["nro_reserva"] = DBNull.Value;
                totalRow["fecha_ingreso"] = DBNull.Value;
                totalRow["fecha_salida"] = DBNull.Value;
                totalRow["monto_total"] = total;
                totalRow["Cliente"] = "TOTAL RECAUDADO";
                tabla.Rows.Add(totalRow);
            }

            return tabla;
        }



        public DataTable GetHabitacionesMasReservadas(DateTime fechaInicio, DateTime fechaFin)
        {
            string query = @"
                SELECT TOP(10) h.nro_habitacion, h.id_piso, COUNT(*) AS CantidadReservas
                FROM reserva r
                INNER JOIN habitacion h 
                    ON r.nro_habitacion = h.nro_habitacion AND r.id_piso = h.id_piso
                WHERE r.fecha_ingreso BETWEEN @inicio AND @fin
                GROUP BY h.nro_habitacion, h.id_piso
                ORDER BY CantidadReservas DESC";

            return EjecutarConsulta(query, fechaInicio, fechaFin);
        }

        public DataTable GetTiposMasReservados(DateTime fechaInicio, DateTime fechaFin)
        {
            string query = @"
                SELECT TOP(10) t.tipo, COUNT(*) AS CantidadReservas
                FROM reserva r
                INNER JOIN habitacion h ON r.nro_habitacion = h.nro_habitacion AND r.id_piso = h.id_piso
                INNER JOIN tipo_habitacion t ON h.id_tipo = t.id_tipo
                WHERE r.fecha_ingreso BETWEEN @inicio AND @fin
                GROUP BY t.tipo
                ORDER BY CantidadReservas DESC";

            return EjecutarConsulta(query, fechaInicio, fechaFin);
        }

        private DataTable EjecutarConsulta(string query, DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable tabla = new DataTable();

            using (var con = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@inicio", fechaInicio);
                cmd.Parameters.AddWithValue("@fin", fechaFin);

                con.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    tabla.Load(reader); // Crea las columnas automáticamente
                }
            }

            return tabla;
        }
    }
}
