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
    public class GuiasturistasController : ControllerBase
    {
        private readonly TurismowebContext _context;

        public GuiasturistasController(TurismowebContext context)
        {
            _context = context;
        }

        // GET: api/Guiasturistas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Guiasturista>>> GetGuiasturistas()
        {
            return await _context.Guiasturistas.ToListAsync();
        }

        // GET: api/Guiasturistas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Guiasturista>> GetGuiasturista(int id)
        {
            var guiasturista = await _context.Guiasturistas.FindAsync(id);

            if (guiasturista == null)
            {
                return NotFound();
            }

            return guiasturista;
        }

        // PUT: api/Guiasturistas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGuiasturista(int id, Guiasturista guiasturista)
        {
            if (id != guiasturista.Id)
            {
                return BadRequest();
            }

            _context.Entry(guiasturista).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GuiasturistaExists(id))
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

        // POST: api/Guiasturistas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Guiasturista>> PostGuiasturista(Guiasturista guiasturista)
        {
            _context.Guiasturistas.Add(guiasturista);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGuiasturista", new { id = guiasturista.Id }, guiasturista);
        }

        // DELETE: api/Guiasturistas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGuiasturista(int id)
        {
            var guiasturista = await _context.Guiasturistas.FindAsync(id);
            if (guiasturista == null)
            {
                return NotFound();
            }

            _context.Guiasturistas.Remove(guiasturista);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GuiasturistaExists(int id)
        {
            return _context.Guiasturistas.Any(e => e.Id == id);
        }
    }
}
