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
    public class TipoHabitacionModel
    {
        //campos
        private string tipo;
        private string descripcion;


        [DisplayName("Tipo")]
        [Required(ErrorMessage = "Es obligatorio el tipo")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "El tipo no puede tener mas de 15 caracteres ni menos de 3")]
        public string Tipo
        {
            get => tipo;
            set => tipo = value;
        }

        [DisplayName("Descripcion")]
        [Required(ErrorMessage = "Es obligatorio la descripcion")]
        public string Descripcion
        {
            get => descripcion;
            set => descripcion = value;
        }

    }
}
