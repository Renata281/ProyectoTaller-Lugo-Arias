using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoTaller_Lugo_Arias.Views;
using ProyectoTaller_Lugo_Arias.Models;
//using ProyectoTaller_Lugo_Arias.Repositories;

namespace ProyectoTaller_Lugo_Arias.Presenters
{
    public class MainPresenter
    {
        private IMainView mainView;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;
        }
    }
}
