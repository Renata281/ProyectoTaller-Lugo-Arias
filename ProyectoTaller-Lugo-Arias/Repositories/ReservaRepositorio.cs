using System.Data.SqlClient;
using ProyectoTaller_Lugo_Arias.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProyectoTaller_Lugo_Arias.Repositories
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
            throw new NotImplementedException();
        }

        public void Delete(int nro_reserva)
        {
            throw new NotImplementedException();
        }

        public void Edit(ReservaModel reserva)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReservaModel> GetAll()
        {
            var reservaList = new List<ReservaModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                //selecciona todos los usuarios ordenados por id_usuario descendente
                command.CommandText = "SELECT * FROM reserva";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var reservaModel = new ReservaModel();
                        reservaModel.Nro_reserva = reader["nro_reserva"] is DBNull ? 0 : (int)reader["nro_reserva"];
                        reservaModel.Fecha_ingreso = reader["fecha_ingreso"] is DBNull ? DateTime.MinValue : (DateTime)reader["fecha_ingreso"];
                        reservaModel.Fecha_salida = reader["fecha_salida"] is DBNull ? DateTime.MinValue : (DateTime)reader["fecha_salida"];
                        reservaModel.Monto_total = reader["monto_total"] is DBNull ? 0 : (decimal)reader["monto_total"];
                        reservaModel.Id_cliente = reader["id_cliente"] is DBNull ? 0 : (int)reader["id_cliente"];
                        reservaModel.Dni = reader["dni"] is DBNull ? 0 : (int)reader["dni"];
                        reservaModel.Nro_habitacion = reader["nro_habitacion"] is DBNull ? 0 : (int)reader["nro_habitacion"];
                        reservaModel.Id_piso = reader["id_piso"] is DBNull ? 0 : (int)reader["id_piso"];
                        reservaModel.Estado = reader["estado"] as string ?? string.Empty;
                        //agregar a la lista
                        reservaList.Add(reservaModel);
                    }
                }
            }
            return reservaList;
        }

        public IEnumerable<ReservaModel> GetByValue(string valorBusqueda)
        {
            var reservaList = new List<ReservaModel>();
            int reservaNro = int.TryParse(valorBusqueda, out var id) ? id : 0;
            string reserva = valorBusqueda;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM reserva
                                      WHERE nro_reserva=@id ";

                command.Parameters.Add("@id", SqlDbType.Int).Value = reservaNro;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var reservaModel = new ReservaModel();
                        reservaModel.Nro_reserva = reader["nro_reserva"] is DBNull ? 0 : (int)reader["nro_reserva"];
                        reservaModel.Fecha_ingreso = reader["fecha_ingreso"] is DBNull ? DateTime.MinValue : (DateTime)reader["fecha_ingreso"];
                        reservaModel.Fecha_salida = reader["fecha_salida"] is DBNull ? DateTime.MinValue : (DateTime)reader["fecha_salida"];
                        reservaModel.Monto_total = reader["monto_total"] is DBNull ? 0 : (decimal)reader["monto_total"];
                        reservaModel.Id_cliente = reader["id_cliente"] is DBNull ? 0 : (int)reader["id_cliente"];
                        reservaModel.Dni = reader["dni"] is DBNull ? 0 : (int)reader["dni"];
                        reservaModel.Nro_habitacion = reader["nro_habitacion"] is DBNull ? 0 : (int)reader["nro_habitacion"];
                        reservaModel.Id_piso = reader["id_piso"] is DBNull ? 0 : (int)reader["id_piso"];
                        reservaModel.Estado = reader["estado"] as string ?? string.Empty;
                        //agregar a la lista
                        reservaList.Add(reservaModel);
                    }
                }
            }
             return reservaList;
        }
    }
}
