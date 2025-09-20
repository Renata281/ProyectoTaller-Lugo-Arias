using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;


namespace ProyectoTaller_Lugo_Arias.Models
{
    public class ReservaModel
    {
        //campos
        private int nro_reserva;
        private DateTime fecha_ingreso;
        private DateTime fecha_salida;
        private decimal monto_total;
        private int id_cliente;
        private int dni; //cliente dni
        private int nro_habitacion;
        private int id_piso;
        private string estado;

        [DisplayName("ID Reserva")]
        public int Nro_reserva
        {
            get => nro_reserva;
            set => nro_reserva = value;
        }

        [DisplayName("Fecha Ingreso")]
        [Required(ErrorMessage = "La fecha de ingreso es obligatoria.")]
        [DataType(DataType.Date)]
        public DateTime Fecha_ingreso
        {
            get => fecha_ingreso;
            set => fecha_ingreso = value;
        }

        [DisplayName("Fecha Egreso")]
        [Required(ErrorMessage = "La fecha de egreso es obligatoria.")]
        [DataType(DataType.Date)]
        public DateTime Fecha_salida
        {
            get => fecha_salida;
            set => fecha_salida = value;
        }

        public decimal Monto_total
        {
            get => monto_total;
            set => monto_total = value;
        }

        [DisplayName("ID Habitación")]
        [Required(ErrorMessage = "El ID de la habitación es obligatorio.")]
        public int Nro_habitacion
        {
            get => nro_habitacion;
            set => nro_habitacion = value;
        }

        public int Id_piso
        {
            get => id_piso;
            set => id_piso = value;
        }

        [DisplayName("ID Cliente")]
        [Required(ErrorMessage = "El ID del cliente es obligatorio.")]
        public int Id_cliente
        {
            get => id_cliente;
            set => id_cliente = value;
        }

        public int Dni
        {
            get => dni;
            set => dni = value;
        }

        [DisplayName("Estado")]
        [Required(ErrorMessage = "El estado es obligatorio.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "El estado no puede tener más de 20 caracteres ni menos de 3")]
        public string Estado
        {
            get => estado;
            set => estado = value;
        }

    }
}
