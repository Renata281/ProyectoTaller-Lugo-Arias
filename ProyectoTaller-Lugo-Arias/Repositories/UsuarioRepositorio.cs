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
            using(var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into Usuarios values(@nombre, @apellido, @dni, @telefono, @email, @password, @id_cargo, @cargo_descripcion )";
                command.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = usuario.Nombre;
                command.Parameters.Add("@apellido", SqlDbType.NVarChar).Value = usuario.Apellido;
                command.Parameters.Add("@dni", SqlDbType.Int).Value = usuario.Dni;
                command.Parameters.Add("@telefono", SqlDbType.Int).Value = usuario.Telefono;
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = usuario.Email;
                command.Parameters.Add("@password", SqlDbType.VarBinary).Value = usuario.Password;
                command.Parameters.Add("@id_cargo", SqlDbType.Int).Value = usuario.Id_cargo;
                command.Parameters.Add("@cargo_descripcion", SqlDbType.NVarChar).Value = usuario.Cargo_descripcion;
                command.ExecuteNonQuery();

            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "delete from Usuarios where id_usuario=@id ";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();

            }
        }
        public void Edit(UsuarioModel usuario)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update Usuarios 
                                      set Usuarios_nombre = @nombre,Usuarios_apellido = @apellido,Usuarios_dni = @dni,Usuarios_telefono = @telefono,Usuarios_email = @email,Usuarios_pass = @password,Usuarios_id_cargo = @id_cargo,Usuarios_cargo_descripcion = @cargo_descripcion
                                      where Usuarios_id_usuario =@id";
                command.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = usuario.Nombre;
                command.Parameters.Add("@apellido", SqlDbType.NVarChar).Value = usuario.Apellido;
                command.Parameters.Add("@dni", SqlDbType.Int).Value = usuario.Dni;
                command.Parameters.Add("@telefono", SqlDbType.Int).Value = usuario.Telefono;
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = usuario.Email;
                command.Parameters.Add("@password", SqlDbType.VarBinary).Value = usuario.Password;
                command.Parameters.Add("@id_cargo", SqlDbType.Int).Value = usuario.Id_cargo;
                command.Parameters.Add("@cargo_descripcion", SqlDbType.NVarChar).Value = usuario.Cargo_descripcion;
                command.Parameters.Add("@id", SqlDbType.Int).Value = usuario.Id_usuario;
                command.ExecuteNonQuery();

            }
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
