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

        public async Task Insert(Usuario usuario)
        {
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
    }
}
