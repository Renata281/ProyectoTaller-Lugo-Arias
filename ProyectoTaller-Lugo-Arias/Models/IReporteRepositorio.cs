using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoTaller_Lugo_Arias.Models
{
    public interface IReporteRepositorio
    {
        DataTable GetMetodoPagoMasUsado(DateTime fechaInicio, DateTime fechaFin);
        DataTable GetFacturacion(DateTime fechaInicio, DateTime fechaFin);
        DataTable GetHabitacionesMasReservadas(DateTime fechaInicio, DateTime fechaFin);
        DataTable GetTiposMasReservados(DateTime fechaInicio, DateTime fechaFin);
    }
}
