using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller_Lugo_Arias.Models
{
    public interface ITipoHabitacionRepositorio
    {
        void Add(TipoHabitacionModel tipoHabitacion);
        void Edit(TipoHabitacionModel tipoHabitacion);
        void Delete(string tipo);

        IEnumerable<TipoHabitacionModel> GetAll();
        IEnumerable<TipoHabitacionModel> GetByValue(string valorBusqueda); //buscador


    }
}
