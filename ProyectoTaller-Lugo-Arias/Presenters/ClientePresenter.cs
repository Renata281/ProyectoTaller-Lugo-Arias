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
    public class ClientePresenter
    {
        private IClienteView view;
        private IClienteRepositorio clienteRepositorio;
        private BindingSource clientesBindingSource;
        private IEnumerable<ClienteModel> clientesList;

        public ClientePresenter(IClienteView view, IClienteRepositorio clienteRepositorio)
        {
            this.view = view;
            this.clientesBindingSource = new BindingSource();
            this.clienteRepositorio = clienteRepositorio;

            this.view.BuscarEvent += BuscarCliente;
            this.view.AgregarEvent += AgregarCliente;
            this.view.EditarEvent += LoadSelectedClienteToEdit;
            this.view.EliminarEvent += DeleteSelectedCliente;
            this.view.GuardarEvent += GuardarCliente;
            this.view.CancelarEvent += CancelarAction;

            this.view.SetClienteListBindingSource(this.clientesBindingSource);
            LoadAllClienteList();
            this.view.Show();

        }

        private void LoadAllClienteList()
        {
            clientesList = clienteRepositorio.GetAll();
            clientesBindingSource.DataSource = clientesList;
        }

        private void CancelarAction(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void GuardarCliente(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedCliente(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectedClienteToEdit(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AgregarCliente(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BuscarCliente(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
