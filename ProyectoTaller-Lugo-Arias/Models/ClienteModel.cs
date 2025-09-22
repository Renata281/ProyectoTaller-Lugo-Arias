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
    public class ClienteModel
    {
        //campos
        private int id_cliente;
        private string nombre;
        private string apellido;
        private string email;
        private int telefono;
        private int dni;

        public int Id_cliente
        {
            get => id_cliente;
            set => id_cliente = value;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public string Apellido
        {
            get => apellido;
            set => apellido = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public int Telefono
        {
            get => telefono;
            set => telefono = value;
        }

        public int Dni
        {
            get => dni;
            set => dni = value;
        }
    }
}
