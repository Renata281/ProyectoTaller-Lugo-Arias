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
            CleanViewFields();
        }

        private void GuardarEmpleado(object? sender, EventArgs e)
        {
            int idUsuario, dni, telefono;
            int.TryParse(this.view.Id_usuario, out idUsuario);
            int.TryParse(this.view.Dni, out dni);
            int.TryParse(this.view.Telefono, out telefono);

            var model = new UsuarioModel();
            model.Id_usuario = idUsuario;
            model.Nombre = view.Nombre;
            model.Apellido = view.Apellido;
            model.Dni = dni;
            model.Telefono = telefono;
            model.Email = view.Email;
            model.Password = !string.IsNullOrWhiteSpace(this.view.Password)
                ? Convert.FromBase64String(this.view.Password)
                : Array.Empty<byte>(); // Solución: usar un array vacío en vez de null
            model.Id_cargo = Convert.ToInt32(this.view.Id_cargo);
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if(view.IsEditar) //editar
                {
                    usuarioRepositorio.Edit(model);
                    view.Mensaje = "Empleado editado correctamente";
                }
                else //nuevo
                {
                    usuarioRepositorio.Add(model);
                    view.Mensaje = "Empleado agregado correctamente";
                }
                view.IsNuevo = true;
                LoadAllEmpleadosList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsNuevo = false;
                view.Mensaje = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.Id_usuario = "0";
            view.Nombre =" ";
            view.Apellido = " ";
            view.Dni = "0";
            view.Telefono = "0";
            view.Email = " ";
            view.Password = " ";
            view.Id_cargo = "0";
        }

        private void DeleteSelectedEmpleado(object? sender, EventArgs e)
        {
            try
            {
                var empleado = (UsuarioModel)empleadosBindingSource.Current;
                usuarioRepositorio.Delete(empleado.Id_usuario);
                view.IsNuevo = true;
                view.Mensaje = "Empleado eliminado correctamente";
                LoadAllEmpleadosList();
            }
            catch (Exception ex)
            {
                view.IsNuevo = false;
                view.Mensaje = "Ocurrio un error, no se pudo eliminar al empleado";
            }
        }

        private void LoadSelectedEmpleadoToEdit(object? sender, EventArgs e)
        {
            var empleado = (UsuarioModel)empleadosBindingSource.Current;
            
            view.Id_usuario = empleado.Id_usuario.ToString();
            view.Nombre = empleado.Nombre;
            view.Apellido = empleado.Apellido;
            view.Dni = empleado.Dni.ToString();
            view.Telefono = empleado.Telefono.ToString();
            view.Email = empleado.Email;
            view.Password = empleado.Password != null ? Convert.ToBase64String(empleado.Password) : string.Empty;
            view.Id_cargo = empleado.Id_cargo.ToString();
            view.IsEditar = true;
        }

        private void AgregarEmpleado(object? sender, EventArgs e)
        {
            view.IsEditar = false;
        }

        
    }
}
