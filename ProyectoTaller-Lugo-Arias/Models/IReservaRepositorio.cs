using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller_Lugo_Arias.Models
{
    public interface IReservaRepositorio
    {
        void Add(ReservaModel reserva);
        void Edit(ReservaModel reserva);
        void Delete(int nro_reserva);
        //retorna todas las reservas
        IEnumerable<ReservaModel> GetAll();
        //retorna una reserva por su nro_reserva
         IEnumerable<ReservaModel> GetByValue(string valorBusqueda); //buscador
    }
}
