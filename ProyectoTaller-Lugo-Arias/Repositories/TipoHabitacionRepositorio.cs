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
    public class TipoHabitacionRepositorio : BaseRepositorio, ITipoHabitacionRepositorio
    {
        //constructor
        public TipoHabitacionRepositorio(string connectionString)
        {
            this.connectionString = connectionString;
        }

        //metodos
        public void Add(TipoHabitacionModel tipoHabitacion)
        {
            throw new NotImplementedException();
        }

        public void Update(TipoHabitacionModel tipoHabitacion)
        {
            throw new NotImplementedException();
        }

        public void Delete(string tipo)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TipoHabitacionModel> GetAll()
        {
            var tipoHabitacionList = new List<TipoHabitacionModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                //selecciona todos los usuarios ordenados por id_usuario descendente
                command.CommandText = "SELECT * FROM tipo_habitacion";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var tipoHabitacionModel = new TipoHabitacionModel();
                        tipoHabitacionModel.Tipo = reader["tipo"] as string ?? string.Empty;
                        tipoHabitacionModel.Descripcion = reader["descripcion"] as string ?? string.Empty;
                        //agregar a la lista
                        tipoHabitacionList.Add(tipoHabitacionModel);
                    }
                }
            }
            return tipoHabitacionList;
        }

        public IEnumerable<TipoHabitacionModel> GetByValue(string valorBusqueda)
        {
            var tipoHabitacionList = new List<TipoHabitacionModel>();
            string tipoHabitacion = valorBusqueda;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT tipo, descripcion
                                        FROM tipo_habitacion
                                        WHERE tipo like @tipo + '%'";

                command.Parameters.Add("@tipo", SqlDbType.NVarChar).Value = tipoHabitacion;


                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var tipoHabitacionModel = new TipoHabitacionModel();
                        tipoHabitacionModel.Tipo = reader["tipo"] as string ?? string.Empty;
                        tipoHabitacionModel.Descripcion = reader["descripcion"] as string ?? string.Empty;
                        //agregar a la lista
                        tipoHabitacionList.Add(tipoHabitacionModel);
                    }
                }
            }
            return tipoHabitacionList;
        }

    }
}
