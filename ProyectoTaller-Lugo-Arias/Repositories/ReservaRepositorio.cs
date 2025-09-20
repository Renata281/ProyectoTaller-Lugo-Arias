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
    public class ReservaRepositorio : BaseRepositorio, IReservaRepositorio
    {
        //constructor
        public ReservaRepositorio(string connectionString)
        {
            this.connectionString = connectionString;
        }

        //metodos
        public void Add(ReservaModel reserva)
        {
            throw new NotImplementedException();
        }

        public void Delete(int nro_reserva)
        {
            throw new NotImplementedException();
        }

        public void Edit(ReservaModel reserva)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReservaModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReservaModel> GetByValue(string valorBusqueda)
        {
            throw new NotImplementedException();
        }
    }
}
