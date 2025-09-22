using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProyectoTaller_Lugo_Arias.Models;

namespace ProyectoTaller_Lugo_Arias.Repositories
{
    public class LoginRepositorio : BaseRepositorio, ILoginRepositorio
    {
        //constructor
        public LoginRepositorio(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public UsuarioModel GetUsuarioByEmail(string email)
        {
            UsuarioModel usuario = null;

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT id_usuario, nombre, apellido, dni, telefono, email, password, id_cargo FROM usuario WHERE email = @email";

                command.Parameters.AddWithValue("@email", email);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // If a user is found, create and populate the UsuarioModel object
                        usuario = new UsuarioModel
                        {
                            Id_usuario = reader["id_usuario"] is DBNull ? 0 : (int)reader["id_usuario"],
                            Nombre = reader["nombre"] as string ?? string.Empty,
                            Apellido = reader["apellido"] as string ?? string.Empty,
                            Dni = reader["Dni"] is DBNull ? 0 : (int)reader["Dni"],
                            Telefono = reader["telefono"] is DBNull ? 0 : (int)reader["telefono"],
                            Email = reader["email"] as string ?? string.Empty,
                            Password = reader["password"] as byte[] ?? Array.Empty<byte>(),
                            Id_cargo = reader["id_cargo"] is DBNull ? 0 : (int)reader["id_cargo"],
                        };
                    }
                }
            }
            return usuario;
        }
    }
}
