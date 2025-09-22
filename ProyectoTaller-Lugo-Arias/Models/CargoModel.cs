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
    public class CargoModel
    {
        private int id_cargo;
        private string cargo_descripcion;

        public int Id_cargo
        {
            get => id_cargo;
            set => id_cargo = value;
        }

        public string Cargo_descripcion
        {
            get => cargo_descripcion;
            set => cargo_descripcion = value;
        }
    }

}
