using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoTaller_Lugo_Arias.Models;
using ProyectoTaller_Lugo_Arias.Views;
using System.Security.Cryptography;

namespace ProyectoTaller_Lugo_Arias.Presenters
{
    public class ReservaPresenter
    {
        //campos
        private IReservasView view;
        private IReservaRepositorio reservaRepositorio;
        private BindingSource reservasBindingSource;
        private IEnumerable<ReservaModel> reservasList;
        public ReservaPresenter(IReservasView view, IReservaRepositorio reservaRepositorio)
        {
            this.reservasBindingSource = new BindingSource();
            this.view = view;
            this.reservaRepositorio = reservaRepositorio;
            // suscribir eventos de la vista a los manejadores de eventos
            this.view.BuscarEvent += BuscarReserva;
            this.view.AgregarEvent += AgregarReserva;
            this.view.EditarEvent += LoadSelectedReservaToEdit;
            this.view.EliminarEvent += DeleteSelectedReserva;
            this.view.GuardarEvent += GuardarReserva;
            this.view.CancelarEvent += CancelarAction;
            //establecer el origen de datos del enlace
            this.view.SetReservaListBindingSource(reservasBindingSource);
            //cargar datos de la tabla empleados
            LoadAllReservasList();
            //mostrar la vista
            this.view.Show();
        }

        private void LoadAllReservasList()
        {
            reservasList = reservaRepositorio.GetAll();
            reservasBindingSource.DataSource = reservasList; //establece el origen de datos del enlace
        }

        private void CancelarAction(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void GuardarReserva(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedReserva(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectedReservaToEdit(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AgregarReserva(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BuscarReserva(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }

}
