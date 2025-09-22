using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProyectoTaller_Lugo_Arias.Models
{
    public class HabitacionesModels
    {
        private int nro_habitacion;
        private int cant_camas;
        private float precio_unitario;
        private string descripcion;
        private string tipo;
        private int id_piso;
        private int id_estado;

        [DisplayName ("Nro_habitacion")]
        [Required(ErrorMessage = "El numero de habitacion es obligatorio")]
        public int Nro_habitacion
        { 
            get { return nro_habitacion; }  
            set { nro_habitacion = value; }
        }

        [DisplayName("Cant_camas")]
        [Required(ErrorMessage = "El numero de camas es obligatorio")]
        public int Cant_camas
        {
            get { return cant_camas; }
            set { cant_camas = value; }
        
        }

        [DisplayName("Precio_unitario")]
        [Required(ErrorMessage = "El precio unitario es obligatorio")]
        public float Precio_unitario 
        {
            get { return precio_unitario; }
            set { precio_unitario = value; } 
        }

        [DisplayName("Descrpcion")]
        [Required(ErrorMessage = "La descripcion de la habitacion es obligatorio")]
        [StringLength (100, MinimumLength = 4, ErrorMessage = "El campo descripcion es de 4 a 100 caracteres ")]
        public string Descripcion 
        {
            get { return  descripcion; } 
            set { descripcion = value; } 
        }

        [DisplayName("Tipo")]
        [Required(ErrorMessage = "El de la habitacion es obligatorio")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "El campo tipo es de 4 a 100 caracteres ")]
        public string Tipo 
        { 
            get { return tipo; }
            set { tipo = value; } 
        }

        [DisplayName("Id_piso")]
        [Required(ErrorMessage = "El numero de piso es obligatorio")]
        public int Id_piso 
        {
            get { return id_piso; } 
            set { id_piso = value; }
        }

        [DisplayName("Id_estado")]
        [Required(ErrorMessage = "El tipo de estado es obligatorio")]
        public int Id_estado 
        {
            get { return id_estado; } 
            set { id_estado = value; }
        }
    }
}
