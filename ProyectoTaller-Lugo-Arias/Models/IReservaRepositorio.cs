using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller_Lugo_Arias.Models
{
    public interface IReservaRepositorio
    {
        void Add(ReservaModel reserva);
        void Edit(ReservaModel reserva);
        void Delete(int nro_reserva);
        //retorna todas las reservas
        IEnumerable<ReservaModel> GetAll();
        //retorna una reserva por su nro_reserva
        IEnumerable<ReservaModel> GetByValue(string valorBusqueda); //buscador

        IEnumerable<ReservaModel> GetAllActivas();
        IEnumerable<ReservaModel> GetAllPendientes();
        IEnumerable<ReservaModel> GetAllFinalizadas();
        // Obtener reserva por ID
        ReservaModel GetById(int nro_reserva);

        // Consultar habitaciones disponibles según criterios
        /*
        IEnumerable<HabitacionesModels> GetHabitacionesDisponibles(
            int tipo,
            int cant_personas,
            DateTime fecha_ingreso,
            DateTime fecha_salida
        );*/

        // Calcular monto total (puede usarse para mostrar antes de guardar)
        decimal CalcularMontoTotal(int nro_habitacion, DateTime fecha_ingreso, DateTime fecha_salida);
    }
}
