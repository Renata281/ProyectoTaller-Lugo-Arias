using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller_Lugo_Arias.Models
{
    public class LogModelHotel
    {
        private int id_log;
        private string archivo;
        private string admin_email;
        private DateTime fecha;
        public int Idlog {
            get { return id_log; }
            set { id_log = value; }
        }

        public string Archivo
        { 
            get { return archivo; }
            set { archivo = value; } 
        }
        public string UserEmail {
            get { return admin_email; }
            set { admin_email = value; }
        }
        public DateTime Fecha{
            get { return fecha; }
            set { fecha = value; }
        }
    }
}
