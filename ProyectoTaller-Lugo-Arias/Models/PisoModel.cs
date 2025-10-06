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
    internal class PisoModel
    {
        private int id_piso;
        private string descripcion;

        public int Id_piso
        {
            get { return id_piso; }
            set { id_piso = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
    }
}
