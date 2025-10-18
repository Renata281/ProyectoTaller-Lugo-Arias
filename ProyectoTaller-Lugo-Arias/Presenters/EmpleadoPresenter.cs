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
    public class EmpleadoPresenter
    {
        //campos
        private IEmpleadosView view;
        private IUsuarioRepositorio usuarioRepositorio;
        //binding source para enlazar datos entre la vista y el modelo
        private BindingSource empleadosBindingSource;
        private IEnumerable<UsuarioModel> empleadosList;

        private BindingSource empleadosBindingSourceActived;
        private IEnumerable<UsuarioModel> empleadosListActived;
        private BindingSource empleadosBindingSourceDeleted;
        private IEnumerable<UsuarioModel> empleadosListDeleted;

        public EmpleadoPresenter(IEmpleadosView view, IUsuarioRepositorio usuarioRepositorio, ICargoRepositorio cargoRepositorio)
        {
           
            this.view = view;
            this.usuarioRepositorio = usuarioRepositorio;
            this.empleadosBindingSource = new BindingSource();
            this.empleadosBindingSourceActived = new BindingSource();
            this.empleadosBindingSourceDeleted = new BindingSource();
            this.view.SetEmpleadoListBindingSource(empleadosBindingSource);
            this.view.SetEmpleadoListBindingSourceActive(empleadosBindingSourceActived);
            this.view.SetEmpleadoListBindingSourceInactive(empleadosBindingSourceDeleted);


            //cargar datos de la tabla empleados
            LoadAllEmpleadosList();
            // suscribir eventos de la vista a los manejadores de eventos
            this.view.BuscarEvent += BuscarEmpleado;
            this.view.AgregarEvent += AgregarEmpleado;
            this.view.EditarEvent += LoadSelectedEmpleadoToEdit;
            this.view.EliminarEvent += DeleteSelectedEmpleado;
            this.view.GuardarEvent += GuardarEmpleado;
            this.view.CancelarEvent += CancelarAction;

            this.view.SetCargosListComboBox(cargoRepositorio.GetAll());

            
            //mostrar la vista
            this.view.Show();


        }

        private void LoadAllEmpleadosList()
        {
            empleadosList = usuarioRepositorio.GetAll();
            empleadosBindingSource.DataSource = empleadosList; //establece el origen de datos del enlace

            empleadosListActived = usuarioRepositorio.GetAllActive();
            empleadosBindingSourceActived.DataSource = empleadosListActived;

            empleadosListDeleted = usuarioRepositorio.GetAllInactive();
            empleadosBindingSourceDeleted.DataSource = empleadosListDeleted;

        }

        private void BuscarEmpleado(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.Buscar);

            if (!emptyValue)
            {
                empleadosList = usuarioRepositorio.GetByValue(this.view.Buscar);
            }
            else
            {
                empleadosList = usuarioRepositorio.GetAll();
            }

            empleadosBindingSource.DataSource = empleadosList;
        }



        private void CancelarAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void GuardarEmpleado(object? sender, EventArgs e)
        {
            int idUsuario;
            int.TryParse(this.view.Id_usuario, out idUsuario);

            var model = new UsuarioModel();

            try
            {
                model.Id_usuario = idUsuario;
                model.Nombre = view.Nombre;
                model.Apellido = view.Apellido;
                model.Dni = view.Dni;
                model.Telefono = view.Telefono;
                model.Email = view.Email;
                model.Id_cargo = view.Id_cargo;

                // **Lógica clave para el campo contraseña**
                if (view.IsEditar) // Lógica de Edición
                {
                    if (!string.IsNullOrWhiteSpace(this.view.Password))
                    {
                        // Si el usuario ingresó una nueva contraseña, la hashea
                        model.Password = HashPassword(this.view.Password);
                    }
                    else
                    {
                        // Si la contraseña está vacía, no la hashea y el repositorio debe saber cómo manejarlo
                        model.Password = null;
                    }

                    new Common.ModelDataValidation().Validate(model);

                    // Llama al repositorio para editar. El repositorio debe manejar el caso de 'password' nulo.
                    usuarioRepositorio.Edit(model);
                    view.Mensaje = "Empleado editado correctamente";
                }
                else // Lógica de Nuevo Empleado
                {
                    // La contraseña es obligatoria para un nuevo empleado
                    model.Password = HashPassword(this.view.Password);

                    new Common.ModelDataValidation().Validate(model);

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

        private static byte[] HashPassword(string password)
        {
            using (SHA512 sha512 = SHA512.Create())
            {
                byte[] bytes = sha512.ComputeHash(Encoding.UTF8.GetBytes(password));
                return bytes;
            }
        }

        private void CleanViewFields()
        {
            view.Id_usuario = "0";
            view.Nombre =" ";
            view.Apellido = " ";
            view.Dni = 0;
            view.Telefono = 0;
            view.Email = " ";
            view.Password = " ";
            view.Id_cargo = 1;
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
            view.Dni = empleado.Dni;
            view.Telefono = empleado.Telefono;
            view.Email = empleado.Email;
            view.Password = empleado.Password != null ? Convert.ToBase64String(empleado.Password) : string.Empty;
            view.Id_cargo = empleado.Id_cargo;
            view.IsEditar = true;
        }

        private void AgregarEmpleado(object? sender, EventArgs e)
        {
            view.IsEditar = false;
        }

        
    }
}
