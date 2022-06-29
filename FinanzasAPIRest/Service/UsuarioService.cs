using FinanzasAPIRest.Common;
using FinanzasAPIRest.IRepository;
using FinanzasAPIRest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanzasAPIRest.Service
{
    public class UsuarioService : IUsuarioRepository

    {
        public readonly FinanzasContext _dbContext;
        public UsuarioService(FinanzasContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Usuario>> FindAll() => await _dbContext.
                                                            Usuario.
                                                            ToListAsync();
        public async Task<Usuario> FindUserById(int idUsuario) => await _dbContext.
                                                                        Usuario.
                                                                        FindAsync(idUsuario);      

        public async Task CreateUser(Usuario usuario)
        {
            Usuario usuario_disponible = _dbContext.Usuario.Where(u => u.Correo.Equals(usuario.Correo) && u.Password.Equals(usuario.Password)).FirstOrDefault();

            
            usuario.Password = CommonMethods.ConvertToEncrypt(usuario.Password);
            await _dbContext.
                    Usuario.
                    AddAsync(usuario);
            await _dbContext.
                    SaveChangesAsync();
        }
        public async Task Update(Usuario usuario) 
        {                                 
            _dbContext.Usuario.Update(usuario);               
            await _dbContext.SaveChangesAsync();                           
        }
        public bool UserExist(int IdUsuario) => _dbContext
                                                .Usuario
                                                .Any(usuario =>
                                                     usuario.IdUsuario.
                                                     Equals(IdUsuario)
                                                    );
        public Usuario Login(Usuario u)         
        { 
            Usuario usuarioEncontrado =(from usuario in _dbContext.Usuario  
                                        where usuario.Correo== u.Correo && 
                                              CommonMethods.ConvertToDecrypt(usuario.Password) == u.Password
                                        select usuario).First();
            return usuarioEncontrado;
            
        }
    }
}
