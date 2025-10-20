using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller_Lugo_Arias.Models
{
    public interface IHabitacionRepositorio
    {
        void Add(HabitacionesModels habitacionesModels);
        void Edit(HabitacionesModels habitacionesModels);
        void Delete(int id, int idPiso);
        IEnumerable<HabitacionesModels> GetAll();
        IEnumerable<HabitacionesModels> GetByValue(string valorBusqueda);

        IEnumerable<HabitacionesModels> GetAllDisponible();
        IEnumerable<HabitacionesModels> GetAllOcupadas();
        IEnumerable<HabitacionesModels> GetAllMantenimiento();
    }
}