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
                command.CommandText = "insert into cliente(nombre, apellido, dni, telefono, email) values(@nombre, @apellido, @dni, @telefono, @email)";
                command.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = cliente.Nombre;
                command.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = cliente.Apellido;
                command.Parameters.Add("@dni", SqlDbType.Int).Value = cliente.Dni;
                command.Parameters.Add("@telefono", SqlDbType.Int).Value = cliente.Telefono;
                command.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = cliente.Email;
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
                command.CommandText = @"update cliente
                                      set estado = @estado
                                      where id_cliente = @id ";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id_cliente;
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
            "email = @email"
        };

                string query = $"UPDATE cliente SET {string.Join(", ", camposSet)} WHERE id_cliente = @id";
                command.CommandText = query;

                // Agregar parámetros comunes
                command.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = cliente.Nombre;
                command.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = cliente.Apellido;
                command.Parameters.Add("@dni", SqlDbType.Int).Value = cliente.Dni;
                command.Parameters.Add("@telefono", SqlDbType.Int).Value = cliente.Telefono;
                command.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = cliente.Email;
                command.Parameters.Add("@id", SqlDbType.Int).Value = cliente.Id_cliente;

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
                command.CommandText = "SELECT * FROM cliente ORDER BY id_cliente DESC";

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
                        clienteModel.Estado = reader["estado"] as string ?? string.Empty;
                        //agregar a la lista
                        clienteList.Add(clienteModel);
                    }
                }
            }
            return clienteList;
        }

        public IEnumerable<ClienteModel> GetByValue(string valorBusqueda)
        {
            var clienteList = new List<ClienteModel>();
            int id_cliente = int.TryParse(valorBusqueda, out var Id) ? Id : 0;
            string clienteNombre = valorBusqueda;

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                //selecciona todos los usuarios ordenados por id_cliente descendente
                command.CommandText = "SELECT c.* FROM cliente c WHERE (c.id_cliente=@id_cliente) OR (c.dni = @id) OR (c.telefono = @id) OR (c.nombre like @nombre + '%') OR (c.apellido like @nombre + '%') OR (c.email like @nombre + '%') ORDER BY u.id_cliente DESC";

                command.Parameters.Add("@id_cliente", SqlDbType.Int).Value = id_cliente;
                command.Parameters.Add("@nombre", SqlDbType.NVarChar, 50).Value = clienteNombre;

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
                        clienteModel.Estado = "Activo";
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
                command.CommandText = "SELECT * FROM cliente c WHERE c.estado = 'Activo' ORDER BY id_cliente DESC";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var clienteModel = new ClienteModel();
                        clienteModel.Id_cliente = reader["id_cliente"] is DBNull ? 0 : (int)reader["id_cliente"];
                        clienteModel.Nombre = reader["nombre"] as string ?? string.Empty;
                        clienteModel.Apellido = reader["apellido"] as string ?? string.Empty;
                        clienteModel.Dni = reader["dni"] is DBNull ? 0 : (int)reader["dni"];
                        clienteModel.Telefono = reader["telefono"] is DBNull ? 0 : (int)reader["telefono"];
                        clienteModel.Email = reader["email"] as string ?? string.Empty;
                        clienteModel.Estado = reader["estado"] as string ?? string.Empty;
                        //agregar a la lista
                        clienteList.Add(clienteModel);
                    }
                }
            }
            return clienteList;
        }

        public IEnumerable<ClienteModel> GetAllInactive()
        {
            var clienteList = new List<ClienteModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                //selecciona todos los clientes ordenados por Id_cliente descendente
                command.CommandText = "SELECT * FROM cliente c WHERE c.estado = 'Inactivo' ORDER BY id_cliente DESC";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var clienteModel = new ClienteModel();
                        clienteModel.Id_cliente = reader["id_cliente"] is DBNull ? 0 : (int)reader["id_cliente"];
                        clienteModel.Nombre = reader["nombre"] as string ?? string.Empty;
                        clienteModel.Apellido = reader["apellido"] as string ?? string.Empty;
                        clienteModel.Dni = reader["dni"] is DBNull ? 0 : (int)reader["dni"];
                        clienteModel.Telefono = reader["telefono"] is DBNull ? 0 : (int)reader["telefono"];
                        clienteModel.Email = reader["email"] as string ?? string.Empty;
                        clienteModel.Estado = reader["estado"] as string ?? string.Empty;
                        //agregar a la lista
                        clienteList.Add(clienteModel);
                    }
                }
            }
            return clienteList;
        }


     }
 }
        