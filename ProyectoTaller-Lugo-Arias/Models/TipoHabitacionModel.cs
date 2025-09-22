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

        public string Tipo
        {
            get => tipo;
            set => tipo = value;
        }

        public string Descripcion
        {
            get => descripcion;
            set => descripcion = value;
        }
    }
}
