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
    public class CargoRepositorio : BaseRepositorio, ICargoRepositorio
    {
        //constructor
        public CargoRepositorio(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IEnumerable<CargoModel> GetAll()
        {
            var cargoList = new List<CargoModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                //selecciona todos los cargos
                command.CommandText = "SELECT * FROM cargo";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var cargoModel = new CargoModel();
                        cargoModel.Id_cargo = reader["id_cargo"] is DBNull ? 0 : (int)reader["id_cargo"];
                        cargoModel.Cargo_descripcion = reader["descripcion"] as string ?? string.Empty;
                        //agregar a la lista
                        cargoList.Add(cargoModel);
                    }
                }
            }
            return cargoList;
        }
    }
}
