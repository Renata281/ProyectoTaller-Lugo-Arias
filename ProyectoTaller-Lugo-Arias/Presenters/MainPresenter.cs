using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoTaller_Lugo_Arias.Views;
using ProyectoTaller_Lugo_Arias.Models;
using ProyectoTaller_Lugo_Arias.Repositories;

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
            this.mainView.ShowEmpleadosView += OnShowEmpleadosView;
            this.mainView.ShowClientesView += OnShowClientesView;
            this.mainView.ShowReservasView += OnShowReservasView;
            this.mainView.ShowHabitacionesView += OnShowHabitacionesView;
            this.mainView.ShowTipoHabitacionView += OnShowTipoHabitacionView;
        }

        private void OnShowTipoHabitacionView(object? sender, EventArgs e)
        {
            ITipoHabitacionView view = TipoHabitacionView.GetInstance((MainView) mainView);
            ITipoHabitacionRepositorio tipoHabitacionRepositorio = new TipoHabitacionRepositorio(sqlConnectionString);
            new TipoHabitacionPresenter(view, tipoHabitacionRepositorio);
        }

        private void OnShowHabitacionesView(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnShowReservasView(object? sender, EventArgs e)
        {
            IReservasView view = ReservasView.GetInstance((MainView) mainView);
            IReservaRepositorio reservaRepositorio = new ReservaRepositorio(sqlConnectionString);
           /* IClienteRepositorio clienteRepositorio = new ClienteRepositorio(sqlConnectionString);
            IHabitacionRepositorio habitacionRepositorio = new HabitacionRepositorio(sqlConnectionString);
            IPagoRepositorio pagoRepositorio = new PagoRepositorio(sqlConnectionString);
            new ReservaPresenter(view, reservaRepositorio, clienteRepositorio, habitacionRepositorio, pagoRepositorio);
           */
            new ReservaPresenter(view, reservaRepositorio);
        }

        private void OnShowClientesView(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnShowEmpleadosView(object? sender, EventArgs e)
        {
            IEmpleadosView view = EmpleadosView.GetInstance((MainView) mainView);
            ICargoRepositorio cargoRepositorio = new CargoRepositorio(sqlConnectionString);
            IUsuarioRepositorio repositorio = new UsuarioRepositorio(sqlConnectionString);
            new EmpleadoPresenter(view, repositorio, cargoRepositorio);
        }
    }
}
