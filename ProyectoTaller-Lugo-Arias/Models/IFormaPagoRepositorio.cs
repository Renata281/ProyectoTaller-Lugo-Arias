using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller_Lugo_Arias.Models
{
    internal interface IFormaPagoRepositorio
    {
        IEnumerable<FormaPagoModel> GetAll();
    }
}
