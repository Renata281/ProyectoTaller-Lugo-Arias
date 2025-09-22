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
        //retorna todas las reservas
        IEnumerable<ClienteModel> GetAll();
        //retorna una reserva por su nro_reserva
        IEnumerable<ClienteModel> GetByValue(string valorBusqueda); //buscador
    }
}
