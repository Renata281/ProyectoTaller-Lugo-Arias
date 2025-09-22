using ProyectoTaller_Lugo_Arias.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller_Lugo_Arias.Views
{
    public interface ILoginView
    {
        // Propiedades de solo lectura para obtener los datos del formulario.
        // El Presenter lee estos valores.
        string Email { get; }
        string Password { get; }

        // Evento que el Presenter escucha.
        // Se dispara cuando el usuario intenta iniciar sesión.
        event EventHandler LoginAttempt;

        // Métodos que el Presenter usa para actualizar la vista.
        void ShowMessage(string message);
        void ShowErrorMessage(string message);
    }
}
