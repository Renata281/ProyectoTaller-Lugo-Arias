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
    internal class FormaPagoModel
    {
        private int id_pago;
        private string descripcion;

        public int Id_pago
        {
            get { return id_pago; }
            set { id_pago = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
    }
}
