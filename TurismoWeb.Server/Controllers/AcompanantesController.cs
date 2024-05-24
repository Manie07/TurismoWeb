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
    public class AcompanantesController : ControllerBase
    {
        private readonly TurismowebContext _context;

        public AcompanantesController(TurismowebContext context)
        {
            _context = context;
        }

        // GET: api/Acompanantes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Acompanante>>> GetAcompanantes()
        {
            return await _context.Acompanantes.ToListAsync();
        }

        // GET: api/Acompanantes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Acompanante>> GetAcompanante(string id)
        {
            var acompanante = await _context.Acompanantes.FindAsync(id);

            if (acompanante == null)
            {
                return NotFound();
            }

            return acompanante;
        }

        // PUT: api/Acompanantes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAcompanante(string id, Acompanante acompanante)
        {
            if (id != acompanante.Dni)
            {
                return BadRequest();
            }

            _context.Entry(acompanante).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AcompananteExists(id))
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

        // POST: api/Acompanantes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Acompanante>> PostAcompanante(Acompanante acompanante)
        {
            _context.Acompanantes.Add(acompanante);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AcompananteExists(acompanante.Dni))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAcompanante", new { id = acompanante.Dni }, acompanante);
        }

        // DELETE: api/Acompanantes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAcompanante(string id)
        {
            var acompanante = await _context.Acompanantes.FindAsync(id);
            if (acompanante == null)
            {
                return NotFound();
            }

            _context.Acompanantes.Remove(acompanante);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AcompananteExists(string id)
        {
            return _context.Acompanantes.Any(e => e.Dni == id);
        }
    }
}
