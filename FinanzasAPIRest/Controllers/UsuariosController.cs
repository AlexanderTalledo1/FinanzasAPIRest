using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinanzasAPIRest.Models;
using FinanzasAPIRest.IRepository;

namespace FinanzasAPIRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarios;

        public UsuariosController(IUsuarioRepository usuarios)
        {
            _usuarios = usuarios;            
        }

        // GET: api/Usuarios
        [HttpGet]
        public async Task<ActionResult> GetUsuario() 
        {
            List<Usuario> ListaUsuarios = await _usuarios.
                                                FindAll();
            return ListaUsuarios != null ? 
                                    Ok(ListaUsuarios) :
                                    NotFound();              
        }

        // GET: api/Usuarios/5
        [HttpGet("{id}")]
        public async Task<ActionResult> FindUsuarioById(int id)
        {
            Usuario Usuario = await _usuarios.
                                    FindUserById(id);                                
            return Usuario != null ?
                            Ok(Usuario):
                            NotFound();           
        }

        // PUT: api/Usuarios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<ActionResult> PutUsuario(int id,[FromBody]Usuario usuario)
        {
            try
            {
                if (id != usuario.IdUsuario)
                {
                    return BadRequest();
                }
                else
                {
                    usuario.IdUsuario = id;
                    await _usuarios.Update(usuario);
                    return Ok(usuario);
                }
            }
            catch(DbUpdateConcurrencyException)
            {
                if (!_usuarios.UserExist(id))
                {
                    return NotFound();
                }
                else { throw; }
             }                    
        }

        // POST: api/Usuarios      
        [HttpPost]
        public async Task<ActionResult> PostUsuario([FromBody]Usuario usuario)
        {            
            await _usuarios.
                   Insert(usuario);          
            return CreatedAtAction("GetUsuario", new { id = usuario.IdUsuario }, usuario);
        }

        // DELETE: api/Usuarios/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult> DeleteUsuario(int id)
        //{
        //    var usuario = await _context.Usuario.FindAsync(id);
        //    if (usuario == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Usuario.Remove(usuario);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}       
        
    }
}
