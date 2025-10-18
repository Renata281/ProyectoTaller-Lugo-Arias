using ProyectoTaller_Lugo_Arias.Models;
using ProyectoTaller_Lugo_Arias.Repositorio;
using ProyectoTaller_Lugo_Arias.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller_Lugo_Arias.Presenters
{
    public class ClientePresenter
    {
        private IClienteView view;
        private IClienteRepositorio clienteRepositorio;
        private BindingSource clientesBindingSource;
        private IEnumerable<ClienteModel> clientesList;

        private BindingSource clientesBindingSourceActived;
        private BindingSource clientesBindingSourceDeleted;
        private IEnumerable<ClienteModel> clientesListActived;
        private IEnumerable<ClienteModel> clientesListDeleted;
  

        public ClientePresenter(IClienteView view, IClienteRepositorio clienteRepositorio)
        {
            this.view = view;
            this.clientesBindingSource = new BindingSource();
            this.clienteRepositorio = clienteRepositorio;
            this.clientesBindingSourceActived = new BindingSource();
            this.clientesBindingSourceDeleted = new BindingSource();

            //cargar datos de la tabla empleados
            LoadAllClientesList();
            // suscribir eventos de la vista a los manejadores de eventos
            this.view.BuscarEvent += BuscarCliente;
            this.view.AgregarEvent += AgregarCliente;
            this.view.EditarEvent += LoadSelectedClienteToEdit;
            this.view.EliminarEvent += DeleteSelectedCliente;
            this.view.GuardarEvent += GuardarCliente;
            this.view.CancelarEvent += CancelarAction;

            this.view.SetClienteListBindingSource(this.clientesBindingSource);
            this.view.SetClientesListBindingSourceActive(this.clientesBindingSourceActived);
            this.view.SetClientesListBindingSourceInactive(this.clientesBindingSourceDeleted);


            //mostrar la vista
            this.view.Show();

        }

        private void LoadAllClientesList()
        {
            clientesList = clienteRepositorio.GetAll();
            clientesBindingSource.DataSource = clientesList;

            clientesListActived = clienteRepositorio.GetAllActive();
            clientesBindingSourceActived.DataSource = clientesListActived;

            clientesListDeleted = clienteRepositorio.GetAllInactive();
            clientesBindingSourceDeleted.DataSource = clientesListDeleted;
        }

        private void CancelarAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void CleanViewFields()
        {
            view.Id_cliente = 0;
            view.Nombre = " ";
            view.Apellido = " ";
            view.Dni = 0;
            view.Telefono = 0;
            view.Email = " ";
        }

        private void GuardarCliente(object? sender, EventArgs e)
        {
        
            int idcliente = view.Id_cliente;

            var model = new ClienteModel();

            try
            {
                model.Id_cliente = idcliente;
                model.Nombre = view.Nombre;
                model.Apellido = view.Apellido;
                model.Dni = view.Dni;
                model.Telefono = view.Telefono;
                model.Email = view.Email;

                if (view.IsEditar) // Lógica de Edición
                {
                    new Common.ModelDataValidation().Validate(model);

                    // Llama al repositorio para editar.
                    clienteRepositorio.Edit(model);
                    view.Mensaje = "Cliente editado correctamente";
                }
                else // Lógica de Nuevo Empleado
                {

                    new Common.ModelDataValidation().Validate(model);

                    clienteRepositorio.Add(model);
                    view.Mensaje = "Cliente agregado correctamente";
                }
                view.IsNuevo = true;
                LoadAllClientesList();
                CleanViewFields();
            }

            catch (Exception ex)
            {
                view.IsNuevo = false;
                view.Mensaje = ex.Message;
            }

        }


        private void DeleteSelectedCliente(object? sender, EventArgs e)
        {
            try
            {
                var cliente = (ClienteModel)clientesBindingSource.Current;
                clienteRepositorio.Delete(cliente.Id_cliente);
                view.IsNuevo = true;
                view.Mensaje = "Cliente eliminado correctamente";
                LoadAllClientesList();
            }
            catch (Exception ex)
            {
                view.IsNuevo = false;
                view.Mensaje = "Ocurrio un error, no se pudo eliminar al cliente";
            }
        }

        private void LoadSelectedClienteToEdit(object? sender, EventArgs e)
        {
            var cliente = (ClienteModel)clientesBindingSource.Current;

            view.Id_cliente = cliente.Id_cliente;
            view.Nombre = cliente.Nombre;
            view.Apellido = cliente.Apellido;
            view.Dni = cliente.Dni;
            view.Telefono = cliente.Telefono;
            view.Email = cliente.Email;
            view.IsEditar = true;
        }

        private void AgregarCliente(object? sender, EventArgs e)
        {
            view.IsEditar = false;

        }

        private void BuscarCliente(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.Buscar);

            if (!emptyValue)
            {
                clientesList = clienteRepositorio.GetByValue(this.view.Buscar);
            }
            else
            {
                clientesList = clienteRepositorio.GetAll();
            }

            clientesBindingSource.DataSource = clientesList;
        }
    }
}
