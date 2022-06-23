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
    public class DatosBonosController : ControllerBase
    {
        private readonly IDatosBonoRepository _datosBono;
        private readonly FinanzasContext _context;

        public DatosBonosController(IDatosBonoRepository datosBono)
        {
            _datosBono = datosBono;
        }

        // GET: api/DatosBonos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DatosBono>>> GetDatosBono()
        {
            return await _context.DatosBono.ToListAsync();
        }

        // GET: api/DatosBonos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DatosBono>> GetDatosBono(int id)
        {
            var datosBono = await _context.DatosBono.FindAsync(id);

            if (datosBono == null)
            {
                return NotFound();
            }

            return datosBono;
        }

        // PUT: api/DatosBonos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDatosBono(int id, DatosBono datosBono)
        {
            if (id != datosBono.IdOperacion)
            {
                return BadRequest();
            }

            _context.Entry(datosBono).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DatosBonoExists(id))
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

        // POST: api/DatosBonos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult> PostDatosBono(DatosBono datosBono)
        {
            await _datosBono.
                  Insert(datosBono);

            return CreatedAtAction("GetDatosBono", new { id = datosBono.IdOperacion }, datosBono);
        }

        // DELETE: api/DatosBonos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDatosBono(int id)
        {
            var datosBono = await _context.DatosBono.FindAsync(id);
            if (datosBono == null)
            {
                return NotFound();
            }

            _context.DatosBono.Remove(datosBono);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DatosBonoExists(int id)
        {
            return _context.DatosBono.Any(e => e.IdOperacion == id);
        }
    }
}
