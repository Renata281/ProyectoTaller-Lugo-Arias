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
    public class ClienteRepositorio: BaseRepositorio, IClienteRepositorio
    {
        //constructor
        public ClienteRepositorio(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(ClienteModel reserva)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id_cliente)
        {
            throw new NotImplementedException();
        }

        public void Edit(ClienteModel reserva)
        {
            throw new NotImplementedException();
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

        public IEnumerable<ClienteModel> GetByValue(string valorBusqueda)
        {
            var clienteList = new List<ClienteModel>();
            int idCliente = int.TryParse(valorBusqueda, out var id) ? id : 0;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                //selecciona todos los usuarios ordenados por id_usuario descendente
                command.CommandText = "SELECT * FROM cliente WHERE id_cliente=@id_cliente";

                command.Parameters.Add("@id_cliente", SqlDbType.Int).Value = idCliente;

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
    }
}
