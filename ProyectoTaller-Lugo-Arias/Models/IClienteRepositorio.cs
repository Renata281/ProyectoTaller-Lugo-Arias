using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller_Lugo_Arias.Models
{
    public interface IClienteRepositorio
    {
        void Add(ClienteModel reserva);
        void Edit(ClienteModel reserva);
        void Delete(int id_cliente);

        //retorna todos los usuarios
        IEnumerable<ClienteModel> GetAll();
        IEnumerable<ClienteModel> GetAllActive();
        IEnumerable<ClienteModel> GetAllInactive();

        //retorna un usuario por su id
        ClienteModel GetById(int Id);

        //retorna un usuario
        IEnumerable<ClienteModel> GetByValue(string valorBusqueda); //buscador
        ClienteModel Login(string email, string password);
    }
}
