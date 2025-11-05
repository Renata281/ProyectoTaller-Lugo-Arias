using ProyectoTaller_Lugo_Arias.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller_Lugo_Arias.Views
{
    public interface IReporteView
    {
        DateTime FechaInicio { get; set; }
        DateTime FechaFin { get; set; }

        // Valor seleccionado en el ComboBox
        string ReporteSeleccionado { get; }

        // evento del botón Generar
        event EventHandler GenerarReporteEvent;

        // Carga el RDLC
        void LoadReport(DataTable tabla);

        // Mostrar mensajes tipo error/alerta
        void ShowMessage(string mensaje);

        // Muestra el formulario de reportes
        void Show();
    }
}
