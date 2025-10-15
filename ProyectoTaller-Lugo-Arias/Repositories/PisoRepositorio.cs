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
    public class PisoRepositorio : BaseRepositorio, IPisoRepositorio
    {
        //constructor
        public PisoRepositorio(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IEnumerable<PisoModel> GetAll()
        {
            var pisoList = new List<PisoModel>();
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
                        var pisoModel = new PisoModel();
                        pisoModel.Id_piso = reader["id_piso"] is DBNull ? 0 : (int)reader["id_piso"];
                        pisoModel.Descripcion = reader["descripcion"] as string ?? string.Empty;
                        //agregar a la lista
                        pisoList.Add(pisoModel);
                    }
                }
            }
            return pisoList;
        }
    }
}
