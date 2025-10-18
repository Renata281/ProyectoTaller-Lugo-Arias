using ProyectoTaller_Lugo_Arias.Models;
using ProyectoTaller_Lugo_Arias.View;
using ProyectoTaller_Lugo_Arias.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ProyectoTaller_Lugo_Arias.Repositorio;

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
            CleanViewFields();
        }

        private void CleanViewFields()
        {
            view.tipo = " ";
            view.Descripcion = " ";

        }

        private void GuardarTipoHabitacion(object? sender, EventArgs e)
        {
            var model = new TipoHabitacionModel();
            try
            {

                model.Tipo = view.tipo;
                model.Descripcion = view.Descripcion;
                 

                if (view.IsEditar)
                {
                    new Common.ModelDataValidation().Validate(model);
                    tipoHabitacionRepositorio.Edit(model);
                    view.Mensaje = "Tipo de habitación actualizada correctamente.";
                }
                else
                {
                    new Common.ModelDataValidation().Validate(model);
                    tipoHabitacionRepositorio.Add(model);
                    view.Mensaje = "Tipo de habitación agregada correctamente.";
                }

                view.IsNuevo = true;
                LoadAllTipoHabitacionList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsNuevo = false;
                view.Mensaje =ex.Message;
            }
        }

        private void DeleteSelectedTipoHabitacion(object? sender, EventArgs e)
        {
            try
            {
                var tipoHabitacion = (TipoHabitacionModel)tipoHabitacionBindingSource.Current;
                tipoHabitacionRepositorio.Delete(tipoHabitacion.Tipo);
                view.IsNuevo = true;
                view.Mensaje = "Tipo habitación eliminada correctamente";
                LoadAllTipoHabitacionList();
            }
            catch (Exception ex)
            {
                view.IsNuevo = false;
                view.Mensaje = "Ocurrio un error, no se pudo eliminar el tipo de habitación ";
            }
        }

        private void LoadSelectedTipoHabitacionToEdit(object? sender, EventArgs e)
        {
            var tipoHabitacion = (TipoHabitacionModel)tipoHabitacionBindingSource.Current;

            view.tipo = tipoHabitacion.Tipo;
            view.Descripcion = tipoHabitacion.Descripcion;
            view.IsEditar = true;
        }

        private void AgregarTipoHabitacion(object? sender, EventArgs e)
        { 
            view.IsEditar = false;
        }

        private void BuscarTipoHabitacion(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.Buscar);

            if (!emptyValue)
            {
                tipoHabitacionList = tipoHabitacionRepositorio.GetByValue(this.view.Buscar);
            }
            else
            {
                tipoHabitacionList = tipoHabitacionRepositorio.GetAll();
            }

            tipoHabitacionBindingSource.DataSource = tipoHabitacionList;
        }
    }
}
