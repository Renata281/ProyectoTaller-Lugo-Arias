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
        private string estado;

        [DisplayName("Id_cliente")]
        public int Id_cliente
        {
            get => id_cliente;
            set => id_cliente = value;
        }

        [DisplayName("Nombre")]
        [Required(ErrorMessage = "Es obligatorio el nombre")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "El nombre no puede tener más de 15 caracteres ni menos de 3")]
        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        [DisplayName("Apellido")]
        [Required(ErrorMessage = "Es obligatorio el apellido")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "El apellido no puede tener más de 15 caracteres ni menos de 3")]
        public string Apellido
        {
            get => apellido;
            set => apellido = value;
        }

        [Required(ErrorMessage = "El email es obligatorio.")]
        [EmailAddress(ErrorMessage = "El formato del email no es válido.")]
        public string Email
        {
            get => email;
            set => email = value;
        }

        [Required(ErrorMessage = "El teléfono es obligatorio.")]
        [Range(1000000000, 9999999999, ErrorMessage = "El telefono debe tener 10 dígitos.")]
        public int Telefono
        {
            get => telefono;
            set => telefono = value;
        }

        [Required(ErrorMessage = "El DNI es obligatorio.")]
        [Range(1000000, 99999999, ErrorMessage = "El DNI debe tener entre 7 y 8 dígitos.")]
        public int Dni
        {
            get => dni;
            set => dni = value;
        }

        public string Estado
        {
            get => estado;
            set => estado = value;
        }
    }
}
