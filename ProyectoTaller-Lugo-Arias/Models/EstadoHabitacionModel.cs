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
    public class EstadoHabitacionModel
    {
        private int id_estado;
        private string descripcion;

        public int Id_estado
        {
            get { return id_estado; }
            set { id_estado = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
