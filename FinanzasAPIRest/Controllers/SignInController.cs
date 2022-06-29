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
    public class SignInController : ControllerBase
    {
        private readonly FinanzasContext _context;
        private readonly IUsuarioRepository _usuarios;
        public SignInController(FinanzasContext context, IUsuarioRepository usuarios)
        {
            _context = context;
            _usuarios = usuarios;
        }

        // GET: api/SignIn
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuario()
        {
            return await _context.Usuario.ToListAsync();
        }

        // GET: api/SignIn/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> GetUsuario(int id)
        {
            var usuario = await _context.Usuario.FindAsync(id);

            if (usuario == null)
            {
                return NotFound();
            }

            return usuario;
        }

        // PUT: api/SignIn/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsuario(int id, Usuario usuario)
        {
            if (id != usuario.IdUsuario)
            {
                return BadRequest();
            }

            _context.Entry(usuario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsuarioExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/SignIn
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public ActionResult LoginUsuario([FromBody] Usuario usuario)
        {
            var usuarioEncontrado =_usuarios.Login(usuario);
            if(usuarioEncontrado!=null)
            {
                return Ok("Succes");
            }
            return Ok("Fail");

            //try
            //{
            //    _usuarios.Login(usuario);
            //    return Ok("Success");
            //}
            //catch
            //{
            //    return Ok("Fail");
            //}
            //_context.Usuario.Add(usuario);
            //await _context.SaveChangesAsync();
            //return CreatedAtAction("GetUsuario", new { id = usuario.IdUsuario }, usuario);
        }

        // DELETE: api/SignIn/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsuario(int id)
        {
            var usuario = await _context.Usuario.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }

            _context.Usuario.Remove(usuario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UsuarioExists(int id)
        {
            return _context.Usuario.Any(e => e.IdUsuario == id);
        }
    }
}
