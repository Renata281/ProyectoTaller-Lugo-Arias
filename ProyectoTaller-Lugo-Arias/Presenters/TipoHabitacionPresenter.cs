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
    public class TipoHabitacionPresenter
    {
        //campos
        private ITipoHabitacionView view;
        private ITipoHabitacionRepositorio tipoHabitacionRepositorio;
        private BindingSource tipoHabitacionBindingSource;
        private IEnumerable<TipoHabitacionModel> tipoHabitacionList;
        public TipoHabitacionPresenter(ITipoHabitacionView view, ITipoHabitacionRepositorio tipoHabitacionRepositorio)
        {
            this.tipoHabitacionBindingSource = new BindingSource();
            this.view = view;
            this.tipoHabitacionRepositorio = tipoHabitacionRepositorio;
            // suscribir eventos de la vista a los manejadores de eventos
            this.view.BuscarEvent += BuscarTipoHabitacion;
            this.view.AgregarEvent += AgregarTipoHabitacion;
            this.view.EditarEvent += LoadSelectedTipoHabitacionToEdit;
            this.view.EliminarEvent += DeleteSelectedTipoHabitacion;
            this.view.GuardarEvent += GuardarTipoHabitacion;
            this.view.CancelarEvent += CancelarAction;
            //establecer el origen de datos del enlace
            this.view.SetTipoHabitacionListBindingSource(tipoHabitacionBindingSource);
            //cargar datos de la tabla empleados
            LoadAllTipoHabitacionList();
            //mostrar la vista
            this.view.Show();
        }

        private void LoadAllTipoHabitacionList()
        {
            tipoHabitacionList = tipoHabitacionRepositorio.GetAll();
            tipoHabitacionBindingSource.DataSource = tipoHabitacionList; //establece el origen de datos del enlace
        }

        private void CancelarAction(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void GuardarTipoHabitacion(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedTipoHabitacion(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectedTipoHabitacionToEdit(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AgregarTipoHabitacion(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BuscarTipoHabitacion(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
