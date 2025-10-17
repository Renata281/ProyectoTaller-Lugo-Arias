using System.Data.SqlClient;
using ProyectoTaller_Lugo_Arias.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ProyectoTaller_Lugo_Arias.Repositorio;


namespace ProyectoTaller_Lugo_Arias.Repositorio
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
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into  tipo_habitacion(descripcion, tipo) values( @descripcion, @tipo)";
                command.Parameters.Add("@descripcion", SqlDbType.VarChar, 300).Value = tipoHabitacion.Descripcion;
                command.Parameters.Add("@tipo", SqlDbType.VarChar, 100).Value = tipoHabitacion.Tipo;
                command.ExecuteNonQuery();

            }
        }

        public void Delete(string tipo)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"delete from tipo_habitacion
                                      where tipo=@tipo ";
                command.Parameters.Add("@tipo", SqlDbType.VarChar, 100).Value = tipo;
                command.ExecuteNonQuery();

            }
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
        public void Edit(TipoHabitacionModel tipohabitacionesModels)
        {

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                var camposSet = new List<string>{

                    "tipo = @tipo",
                    "descripcion = @descripcion"
                     };

                string query = $"UPDATE tipo_habitacion SET {string.Join(", ", camposSet)} WHERE tipo = @tipo";
                command.CommandText = query;
;
                command.Parameters.Add("@descripcion", SqlDbType.NVarChar, 300).Value = tipohabitacionesModels.Descripcion;
                command.Parameters.Add("@tipo", SqlDbType.NVarChar, 100).Value = tipohabitacionesModels.Tipo;
                command.ExecuteNonQuery();

            }

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
