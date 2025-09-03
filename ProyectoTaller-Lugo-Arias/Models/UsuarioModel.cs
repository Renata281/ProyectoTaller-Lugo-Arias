using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoTaller_Lugo_Arias.Models
{
    public class UsuarioModel
    {
        //campos
        private int id_usuario;
        private string nombre;
        private string apellido;
        private int dni;
        private int telefono;
        private string email;
        private byte[] password;
        private int id_cargo;
        private string cargo_descripcion;
        private string estado; //activo o inactivo


        [DisplayName("ID Usuario")]
        public int Id_usuario { 
            get => id_usuario;
            set => id_usuario = value;
        }

        [DisplayName("Nombre")]
        [Required(ErrorMessage = "Es obligatorio el nombre")]
        [StringLength(15,MinimumLength = 3, ErrorMessage = "El nombre no puede tener más de 15 caracteres ni menos de 3")]
        public string Nombre {
            get => nombre; 
            set => nombre = value;
        }

        [DisplayName("Apellido")]
        [Required(ErrorMessage = "Es obligatorio el apellido")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "El apellido no puede tener más de 15 caracteres ni menos de 3")]
        public string Apellido {
            get => apellido; 
            set => apellido = value;
        }

        [Required(ErrorMessage = "El DNI es obligatorio.")]
        [Range(1000000, 99999999, ErrorMessage = "El DNI debe tener entre 7 y 8 dígitos.")]
        public int Dni { 
            get => dni; 
            set => dni = value;
        }

        [Required(ErrorMessage = "El teléfono es obligatorio.")]
        public int Telefono { 
            get => telefono;
            set => telefono = value;
        }

        [Required(ErrorMessage = "El email es obligatorio.")]
        [EmailAddress(ErrorMessage = "El formato del email no es válido.")]
        public string Email {
            get => email; 
            set => email = value;
        }

        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        [MinLength(8, ErrorMessage = "La contraseña debe tener al menos 8 caracteres.")]
        public byte[] Password {
            get => password;
            set => password = value;
        }

        [Required(ErrorMessage = "El ID del cargo es obligatorio.")]
        public int Id_cargo {
            get => id_cargo;
            set => id_cargo = value;
        }


        public string Cargo_descripcion {
            get => cargo_descripcion;
            set => cargo_descripcion = value;
        }

        public string Estado { 
            get => estado;
            set => estado = value;
        }
    }
}
