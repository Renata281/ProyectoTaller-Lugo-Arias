using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller_Lugo_Arias.Models
{
    public interface IUsuarioRepositorio
    {
        void Add(UsuarioModel usuario);
        void Edit(UsuarioModel usuario);
        void Delete(int id);

        //retorna todos los usuarios
        IEnumerable<UsuarioModel> GetAll();
        //retorna un usuario por su id
        UsuarioModel GetById(int id);

        //retorna un usuario
        IEnumerable<UsuarioModel> GetByValue(string valorBusqueda); //buscador
    }
}
