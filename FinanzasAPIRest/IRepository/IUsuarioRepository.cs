using FinanzasAPIRest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanzasAPIRest.IRepository
{
    public interface IUsuarioRepository
    {
        Task<List<Usuario>> FindAll();
        Task<Usuario> FindUserById(int IdUsuario);
        Task CreateUser(Usuario usuario);
        Task Update(Usuario usuario);
        bool UserExist(int IdUsuario);
        Usuario Login(Usuario u);
       
    }
}
