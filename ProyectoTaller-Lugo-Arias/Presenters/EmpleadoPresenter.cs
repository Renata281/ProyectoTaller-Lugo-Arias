using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoTaller_Lugo_Arias.Models;
using ProyectoTaller_Lugo_Arias.Views;

namespace ProyectoTaller_Lugo_Arias.Presenters
{
    public class EmpleadoPresenter
    {
        //campos
        private IEmpleadosView view;
        private IUsuarioRepositorio usuarioRepositorio;
        private BindingSource empleadosBindingSource;
        private IEnumerable<UsuarioModel> empleadosList;

        public EmpleadoPresenter(IEmpleadosView view, IUsuarioRepositorio usuarioRepositorio)
        {
            this.empleadosBindingSource = new BindingSource();
            this.view = view;
            this.usuarioRepositorio = usuarioRepositorio;
            // suscribir eventos de la vista a los manejadores de eventos
            this.view.BuscarEvent += BuscarEmpleado;
            this.view.AgregarEvent += AgregarEmpleado;
            this.view.EditarEvent += LoadSelectedEmpleadoToEdit;
            this.view.EliminarEvent += DeleteSelectedEmpleado;
            this.view.GuardarEvent += GuardarEmpleado;
            this.view.CancelarEvent += CancelarAction;

            //establecer el origen de datos del enlace
            this.view.SetEmpleadoListBindingSource(empleadosBindingSource);
            //cargar datos de la tabla empleados
            LoadAllEmpleadosList();
            //mostrar la vista
            this.view.Show();

        }

        private void LoadAllEmpleadosList()
        {
            empleadosList = usuarioRepositorio.GetAll();
            empleadosBindingSource.DataSource = empleadosList; //establece el origen de datos del enlace

        }

        private void BuscarEmpleado(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.Buscar);
            if(emptyValue == false)
            {
                empleadosList = usuarioRepositorio.GetByValue(this.view.Buscar);
            }
            else
            {
                empleadosList = usuarioRepositorio.GetAll();
                empleadosBindingSource.DataSource = empleadosList;
            }
        }

        private void CancelarAction(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void GuardarEmpleado(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedEmpleado(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectedEmpleadoToEdit(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AgregarEmpleado(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        
    }
}
