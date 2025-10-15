using System.Data.SqlClient;
using ProyectoTaller_Lugo_Arias.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Configuration;

namespace ProyectoTaller_Lugo_Arias.Repositorio
{
    public class ClienteRepositorio : BaseRepositorio, IClienteRepositorio
    {
        //constructor
        public ClienteRepositorio(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(ClienteModel cliente)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "insert into cliente(id_cliente,nombre, apellido, dni, telefono, email,) values(@id_cliente, @nombre, @apellido, @dni, @telefono, @email,)";
                command.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = cliente.Nombre;
                command.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = cliente.Apellido;
                command.Parameters.Add("@dni", SqlDbType.Int).Value = cliente.Dni;
                command.Parameters.Add("@telefono", SqlDbType.Int).Value = cliente.Telefono;
                command.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = cliente.Email;
                command.Parameters.Add("@id_cliente", SqlDbType.Int).Value = cliente.Id_cliente;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id_cliente)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update usuario
                                      set estado = @estado
                                      where id_usuario=@id ";
                command.Parameters.Add("@Id", SqlDbType.Int).Value = id_cliente;
                command.Parameters.Add("@estado", SqlDbType.VarChar, 100).Value = "Inactivo";
                command.ExecuteNonQuery();

            }
        }

        public void Edit(ClienteModel cliente)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;

                // Construir los campos SET dinámicamente
                var camposSet = new List<string>
        {
            "nombre = @nombre",
            "apellido = @apellido",
            "dni = @dni",
            "telefono = @telefono",
            "email = @email",
            "id_cliente = @id_cliente"
        };

                string query = $"UPDATE usuario SET {string.Join(", ", camposSet)} WHERE Id_cliente = @Id";
                command.CommandText = query;

                // Agregar parámetros comunes
                command.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = cliente.Nombre;
                command.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = cliente.Apellido;
                command.Parameters.Add("@dni", SqlDbType.Int).Value = cliente.Dni;
                command.Parameters.Add("@telefono", SqlDbType.Int).Value = cliente.Telefono;
                command.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = cliente.Email;
                command.Parameters.Add("@Id_cliente", SqlDbType.Int).Value = cliente.Id_cliente;
                command.Parameters.Add("@Id", SqlDbType.Int).Value = cliente.Id_cliente;

                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<ClienteModel> GetAll()
        {
            var clienteList = new List<ClienteModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                //selecciona todos los usuarios ordenados por id_usuario descendente
                command.CommandText = "SELECT * FROM cliente";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var clienteModel = new ClienteModel();
                        clienteModel.Id_cliente = reader["id_cliente"] is DBNull ? 0 : (int)reader["id_cliente"];
                        clienteModel.Telefono = reader["telefono"] is DBNull ? 0 : (int)reader["telefono"];
                        clienteModel.Dni = reader["dni"] is DBNull ? 0 : (int)reader["dni"];
                        clienteModel.Nombre = reader["nombre"] as string ?? string.Empty;
                        clienteModel.Apellido = reader["apellido"] as string ?? string.Empty;
                        clienteModel.Email = reader["email"] as string ?? string.Empty;
                        //agregar a la lista
                        clienteList.Add(clienteModel);
                    }
                }
            }
            return clienteList;
        }
        public ClienteModel GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClienteModel> GetByValue(string valorBusqueda)
        {
            var clienteList = new List<ClienteModel>();
            int Id_Cliente = int.TryParse(valorBusqueda, out var Id) ? Id : 0;
            string clienteNombre = valorBusqueda;

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                //selecciona todos los usuarios ordenados por id_usuario descendente
                command.CommandText = "SELECT * FROM cliente WHERE id_cliente=@id_cliente";

                command.Parameters.Add("@Id_cliente", SqlDbType.Int).Value = Id_Cliente;
                command.Parameters.Add("@nombre", SqlDbType.NVarChar, 50).Value = clienteNombre;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var clienteModel = new ClienteModel();
                        clienteModel.Id_cliente = reader["Id_cliente"] is DBNull ? 0 : (int)reader["Id_cliente"];
                        clienteModel.Telefono = reader["telefono"] is DBNull ? 0 : (int)reader["telefono"];
                        clienteModel.Dni = reader["dni"] is DBNull ? 0 : (int)reader["dni"];
                        clienteModel.Nombre = reader["nombre"] as string ?? string.Empty;
                        clienteModel.Apellido = reader["apellido"] as string ?? string.Empty;
                        clienteModel.Email = reader["email"] as string ?? string.Empty;
                        //agregar a la lista
                        clienteList.Add(clienteModel);
                    }
                }
            }
            return clienteList;
        }

        public IEnumerable<ClienteModel> GetAllActive()
        {
            var clienteList = new List<ClienteModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                //selecciona todos los clientes ordenados por Id_cliente descendente
                command.CommandText = "SELECT *, (SELECT TOP 1 c.descripcion FROM cargo c WHERE c.Id_cliente = u.Id_cliente) AS cargo_descripcion FROM usuario u WHERE u.estado = 'Activo' ORDER BY id_usuario DESC";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var clienteModel = new ClienteModel();
                        clienteModel.Id_cliente = reader["Id_cliente"] is DBNull ? 0 : (int)reader["Id_cliente"];
                        clienteModel.Nombre = reader["nombre"] as string ?? string.Empty;
                        clienteModel.Apellido = reader["apellido"] as string ?? string.Empty;
                        clienteModel.Dni = reader["dni"] is DBNull ? 0 : (int)reader["dni"];
                        clienteModel.Telefono = reader["telefono"] is DBNull ? 0 : (int)reader["telefono"];
                        clienteModel.Email = reader["email"] as string ?? string.Empty;
                        //agregar a la lista
                        clienteList.Add(clienteModel);
                    }
                }
            }
            return clienteList;
        }

        public IEnumerable<ClienteModel> GetAllInactive()
        {
            var clientesList = new List<ClienteModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                //selecciona todos los usuarios ordenados por id_usuario descendente
                command.CommandText = "SELECT *, (SELECT TOP 1 c.descripcion FROM cargo c WHERE c.Id_cliente = u.Id_cliente) AS cargo_descripcion FROM usuario u WHERE u.estado = 'Inactivo' ORDER BY id_usuario DESC";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var clienteModel = new ClienteModel();
                        clienteModel.Id_cliente = reader["id_usuario"] is DBNull ? 0 : (int)reader["id_usuario"];
                        clienteModel.Nombre = reader["nombre"] as string ?? string.Empty;
                        clienteModel.Apellido = reader["apellido"] as string ?? string.Empty;
                        clienteModel.Dni = reader["dni"] is DBNull ? 0 : (int)reader["dni"];
                        clienteModel.Telefono = reader["telefono"] is DBNull ? 0 : (int)reader["telefono"];
                        clienteModel.Email = reader["email"] as string ?? string.Empty;
                        //agregar a la lista
                        clientesList.Add(clienteModel);
                    }
                }
            }
            return clientesList;
        }

        public ClienteModel Login(string email, string password)
        {
            ClienteModel user = null;
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("ClienteLogin", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@pass", password);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        user = new ClienteModel();
                        while (reader.Read())
                        {
                            user.Id_cliente = reader["id_usuario"] is DBNull ? 0 : (int)reader["id_usuario"];
                            user.Nombre = reader["nombre"] as string ?? string.Empty;
                            user.Apellido = reader["apellido"] as string ?? string.Empty;
                            user.Dni = reader["dni"] is DBNull ? 0 : (int)reader["dni"];
                            user.Telefono = reader["telefono"] is DBNull ? 0 : (int)reader["telefono"];
                            user.Email = reader["email"] as string ?? string.Empty;
                        }
                        return user;
                    }

                }
            }
        }
    }
}
