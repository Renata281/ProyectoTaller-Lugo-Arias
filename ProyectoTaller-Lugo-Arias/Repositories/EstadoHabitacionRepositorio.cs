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
    public class EstadoHabitacionRepositorio : BaseRepositorio, IEstadoHabitacionRepositorio
    {
        //constructor
        public EstadoHabitacionRepositorio(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IEnumerable<EstadoHabitacionModel> GetAll()
        {
            var estadoHabtList = new List<EstadoHabitacionModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                //selecciona todos los cargos
                command.CommandText = "SELECT * FROM estado_habitacion";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var estadoHabModel = new EstadoHabitacionModel();
                        estadoHabModel.Id_estado = reader["id_estado"] is DBNull ? 0 : (int)reader["id_estado"];
                        estadoHabModel.Descripcion = reader["descripcion"] as string ?? string.Empty;
                        //agregar a la lista
                        estadoHabtList.Add(estadoHabModel);
                    }
                }
            }
            return estadoHabtList;
        }
    }
}
