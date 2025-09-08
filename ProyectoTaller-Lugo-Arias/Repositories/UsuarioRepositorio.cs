using Microsoft.Data.SqlClient;
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
    public class UsuarioRepositorio : BaseRepositorio, IUsuarioRepositorio
    {
        //constructor
        public UsuarioRepositorio(string connectionString)
        {
            this.connectionString = connectionString;
        }


        //metodos
        public void Add(UsuarioModel usuario)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(UsuarioModel usuario)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UsuarioModel> GetAll()
        {
            var usuariosList = new List<UsuarioModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                //selecciona todos los usuarios ordenados por id_usuario descendente
                command.CommandText = "SELECT * FROM Usuarios ORDER BY id_usuario DESC"; 

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var usuarioModel = new UsuarioModel();
                        usuarioModel.Id_usuario = reader["id_usuario"] is DBNull ? 0 : (int)reader["id_usuario"];
                        usuarioModel.Nombre = reader["nombre"] as string ?? string.Empty;
                        usuarioModel.Apellido = reader["apellido"] as string ?? string.Empty;
                        usuarioModel.Dni = reader["Dni"] is DBNull ? 0 : (int)reader["Dni"];
                        usuarioModel.Telefono = reader["telefono"] is DBNull ? 0 : (int)reader["telefono"];
                        usuarioModel.Email = reader["email"] as string ?? string.Empty;
                        // usuarioModel.Password = reader["password"] as byte[] ?? Array.Empty<byte>();
                        // usuarioModel.Id_cargo = reader["id_cargo"] is DBNull ? 0 : (int)reader["id_cargo"];
                        usuarioModel.Cargo_descripcion = reader["cargo_descripcion"] as string ?? string.Empty;
                        usuarioModel.Estado = reader["estado"] as string ?? string.Empty;
                        //agregar a la lista
                        usuariosList.Add(usuarioModel);
                    }
                }
            }
            return usuariosList;
        }

        public UsuarioModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UsuarioModel> GetByValue(string valorBusqueda)
        {
            var usuariosList = new List<UsuarioModel>();
            int usuarioId = int.TryParse(valorBusqueda, out var id) ? id : 0;
            string usuarioNombre = valorBusqueda;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Usuarios
                                      WHERE id_usuario=@id or nombre like @nombre+'%' 
                                      ORDER BY id_usuario DESC ";

                command.Parameters.Add("@id", SqlDbType.Int).Value = usuarioId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = usuarioNombre;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var usuarioModel = new UsuarioModel();
                        usuarioModel.Id_usuario = reader["id_usuario"] is DBNull ? 0 : (int)reader["id_usuario"];
                        usuarioModel.Nombre = reader["nombre"] as string ?? string.Empty;
                        usuarioModel.Apellido = reader["apellido"] as string ?? string.Empty;
                        usuarioModel.Dni = reader["Dni"] is DBNull ? 0 : (int)reader["Dni"];
                        usuarioModel.Telefono = reader["telefono"] is DBNull ? 0 : (int)reader["telefono"];
                        usuarioModel.Email = reader["email"] as string ?? string.Empty;
                        // usuarioModel.Password = reader["password"] as byte[] ?? Array.Empty<byte>();
                        // usuarioModel.Id_cargo = reader["id_cargo"] is DBNull ? 0 : (int)reader["id_cargo"];
                        usuarioModel.Cargo_descripcion = reader["cargo_descripcion"] as string ?? string.Empty;
                        usuarioModel.Estado = reader["estado"] as string ?? string.Empty;
                        //agregar a la lista
                        usuariosList.Add(usuarioModel);
                    }
                }
            }
            return usuariosList;
        }
    }
}
