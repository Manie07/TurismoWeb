using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TurismoWeb.Server.Data;
using TurismoWeb.Server.Entities;

namespace TurismoWeb.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstablecimientoesController : ControllerBase
    {
        private readonly TurismowebContext _context;

        public EstablecimientoesController(TurismowebContext context)
        {
            _context = context;
        }

        // GET: api/Establecimientoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Establecimiento>>> GetEstablecimientos()
        {
            return await _context.Establecimientos.ToListAsync();
        }

        // GET: api/Establecimientoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Establecimiento>> GetEstablecimiento(int id)
        {
            var establecimiento = await _context.Establecimientos.FindAsync(id);

            if (establecimiento == null)
            {
                return NotFound();
            }

            return establecimiento;
        }

        // PUT: api/Establecimientoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEstablecimiento(int id, Establecimiento establecimiento)
        {
            if (id != establecimiento.Id)
            {
                return BadRequest();
            }

            _context.Entry(establecimiento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstablecimientoExists(id))
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

        // POST: api/Establecimientoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Establecimiento>> PostEstablecimiento(Establecimiento establecimiento)
        {
            _context.Establecimientos.Add(establecimiento);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEstablecimiento", new { id = establecimiento.Id }, establecimiento);
        }

        // DELETE: api/Establecimientoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEstablecimiento(int id)
        {
            var establecimiento = await _context.Establecimientos.FindAsync(id);
            if (establecimiento == null)
            {
                return NotFound();
            }

            _context.Establecimientos.Remove(establecimiento);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EstablecimientoExists(int id)
        {
            return _context.Establecimientos.Any(e => e.Id == id);
        }
    }
}
