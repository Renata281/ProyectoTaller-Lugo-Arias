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

        public void Delete(int id_tipo)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"delete from tipo_habitacion
                                      where id_tipo=@id_tipo ";
                command.Parameters.Add("@id_tipo", SqlDbType.Int).Value = id_tipo;
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
                        tipoHabitacionModel.Id_tipo = reader["id_tipo"] is DBNull ? 0 : (int)reader["id_tipo"];
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

                string query = $"UPDATE tipo_habitacion SET {string.Join(", ", camposSet)} WHERE id_tipo = @id_tipo";
                command.CommandText = query;
                command.Parameters.Add("@id_tipo", SqlDbType.Int).Value = tipohabitacionesModels.Id_tipo;
                command.Parameters.Add("@descripcion", SqlDbType.NVarChar, 300).Value = tipohabitacionesModels.Descripcion;
                command.Parameters.Add("@tipo", SqlDbType.NVarChar, 100).Value = tipohabitacionesModels.Tipo;
                command.ExecuteNonQuery();

            }

        }


        public IEnumerable<TipoHabitacionModel> GetByValue(string valorBusqueda)
        {
            var tipoHabitacionList = new List<TipoHabitacionModel>();
            string tipoHabitacion = valorBusqueda;
            int tipoId = int.TryParse(valorBusqueda, out var id) ? id : 0;

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT id_tipo, tipo, descripcion
                                        FROM tipo_habitacion t
                                        WHERE (t.id_tipo = @id) OR (t.tipo like @tipo + '%')";

                command.Parameters.Add("@id", SqlDbType.Int).Value = tipoId;
                command.Parameters.Add("@tipo", SqlDbType.NVarChar, 100).Value = tipoHabitacion;


                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var tipoHabitacionModel = new TipoHabitacionModel();
                        tipoHabitacionModel.Id_tipo = reader["id_tipo"] is DBNull ? 0 : (int)reader["id_tipo"];
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
