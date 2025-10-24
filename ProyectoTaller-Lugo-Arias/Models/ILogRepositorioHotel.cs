using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller_Lugo_Arias.Models
{
    public interface ILogRepositorioHotel
    {
        void Add(LogModelHotel log);
        void Delete(int idlog);
        IEnumerable<LogModelHotel> GetAll();
        IEnumerable<LogModelHotel> GetByValue(string value);
    }
}
