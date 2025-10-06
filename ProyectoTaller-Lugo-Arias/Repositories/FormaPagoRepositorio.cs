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
    internal class FormaPagoRepositorio : BaseRepositorio, IFormaPagoRepositorio
    {
        //constructor
        public FormaPagoRepositorio(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IEnumerable<FormaPagoModel> GetAll()
        {
            var pagoList = new List<FormaPagoModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                //selecciona todos los cargos
                command.CommandText = "SELECT * FROM piso";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var pagoModel = new FormaPagoModel();
                        pagoModel.Id_pago = reader["id_pago"] is DBNull ? 0 : (int)reader["id_pago"];
                        pagoModel.Descripcion = reader["descripcion"] as string ?? string.Empty;
                        //agregar a la lista
                        pagoList.Add(pagoModel);
                    }
                }
            }
            return pagoList;
        }
    }
}
