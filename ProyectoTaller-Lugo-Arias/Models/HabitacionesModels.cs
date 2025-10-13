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
    public class HabitacionesModels
    {
        private int nro_habitacion;
        private int cant_camas;
        private float precio_unitario;
        private string descripcion;
        private string tipo;
        private int id_piso;
        private int id_estado;
        private string estado_descripcion;
        private int cant_personas;

        [DisplayName ("Nro_habitacion")]
        [Required(ErrorMessage = "El número de habitación es obligatorio")]
        public int Nro_habitacion
        { 
            get { return nro_habitacion; }  
            set { nro_habitacion = value; }
        }

        [DisplayName("Cant_camas")]
        [Required(ErrorMessage = "El número de camas es obligatorio")]
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

        [DisplayName("Descripcion")]
        [Required(ErrorMessage = "La descripcion de la habitacion es obligatorio")]
        [StringLength (150, MinimumLength = 4, ErrorMessage = "El campo descripcion es de 4 a 150 caracteres ")]
        public string Descripcion 
        {
            get { return  descripcion; } 
            set { descripcion = value; } 
        }

        [DisplayName("Tipo")]
        [Required(ErrorMessage = "El tipo de habitación es obligatorio")]
        public string Tipo 
        { 
            get { return tipo; }
            set { tipo = value; } 
        }

        [DisplayName("Id_piso")]
        [Required(ErrorMessage = "El número de piso es obligatorio")]
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

        public string Estado_descripcion 
        { 
            get { return estado_descripcion; } 
            set { estado_descripcion = value; }
        }

        public int Cant_personas 
        { 
            get { return cant_personas; } 
            set { cant_personas = value; }
        }
    }
}
