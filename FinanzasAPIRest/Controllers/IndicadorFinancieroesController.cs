using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinanzasAPIRest.Models;
using FinanzasAPIRest.IRepository;
using System.Text.Json;

namespace FinanzasAPIRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IndicadorFinancieroesController : ControllerBase
    {
        private readonly FinanzasContext _context;

        private readonly IIndicadorRepository _indicadores;
        public IndicadorFinancieroesController(FinanzasContext context, IIndicadorRepository indicadores)
        {
            _context = context;
            _indicadores = indicadores;
        }

        // GET: api/IndicadorFinancieroes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<IndicadorFinanciero>>> GetIndicadorFinanciero()
        {
            return await _context.IndicadorFinanciero.ToListAsync();
        }

        // GET: api/IndicadorFinancieroes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IndicadorFinanciero>> GetIndicadorFinanciero(int id)
        {
            var indicadorFinanciero = await _context.IndicadorFinanciero.FindAsync(id);

            if (indicadorFinanciero == null)
            {
                return NotFound();
            }

            return indicadorFinanciero;
        }

        // PUT: api/IndicadorFinancieroes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIndicadorFinanciero(int id, IndicadorFinanciero indicadorFinanciero)
        {
            if (id != indicadorFinanciero.IdIndicador)
            {
                return BadRequest();
            }

            _context.Entry(indicadorFinanciero).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IndicadorFinancieroExists(id))
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

        // POST: api/IndicadorFinancieroes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult> PostIndicadorFinanciero([FromBody] DatosBono datos)
        {            
            try
            {

                await _indicadores.Insert(datos.IdOperacion);
                return Ok();
            }
            catch(Exception ex)
            {
                return Ok(ex.Message);
            }

        }

        // DELETE: api/IndicadorFinancieroes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIndicadorFinanciero(int id)
        {
            var indicadorFinanciero = await _context.IndicadorFinanciero.FindAsync(id);
            if (indicadorFinanciero == null)
            {
                return NotFound();
            }

            _context.IndicadorFinanciero.Remove(indicadorFinanciero);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool IndicadorFinancieroExists(int id)
        {
            return _context.IndicadorFinanciero.Any(e => e.IdIndicador == id);
        }
    }
}
