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
        void Delete(int id);
        IEnumerable<HabitacionesModels> GetAll();
        IEnumerable<HabitacionesModels> GetValue(int value);
        IEnumerable<HabitacionesModels> GetByValue(string searchValue);
        IEnumerable<HabitacionesModels> GetValue();
    }
}
