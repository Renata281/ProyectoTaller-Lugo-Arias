using ProyectoTaller_Lugo_Arias.Models;
using ProyectoTaller_Lugo_Arias.Repositorio;
using ProyectoTaller_Lugo_Arias.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller_Lugo_Arias.Presenters
{
    public class ReportePresenter
    {
        private IReporteView view;
        private IReporteRepositorio repo;

        public ReportePresenter(IReporteView view, IReporteRepositorio repo)
        {
            this.view = view;
            this.repo = repo;

            this.view.GenerarReporteEvent += GenerarReporte;

            this.view.Show();
        }

        private void GenerarReporte(object sender, EventArgs e)
        {
            switch (view.ReporteSeleccionado)
            {
                case "Habitaciones más reservadas":
                    view.LoadReport(repo.GetHabitacionesMasReservadas(view.FechaInicio, view.FechaFin));
                    break;

                case "Tipos de habitaciones más reservadas":
                    view.LoadReport(repo.GetTiposMasReservados(view.FechaInicio, view.FechaFin));
                    break;

                case "Facturación":
                    view.LoadReport(repo.GetFacturacion(view.FechaInicio, view.FechaFin));
                    break;

                case "Pago más usado":
                    view.LoadReport(repo.GetMetodoPagoMasUsado(view.FechaInicio, view.FechaFin));
                    break;

                default:
                    view.ShowMessage("Seleccione un reporte válido.");
                    break;
            }
        }


    }
}
