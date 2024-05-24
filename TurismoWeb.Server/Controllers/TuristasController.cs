using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using Microsoft.EntityFrameworkCore;
using TurismoWeb.Server.Data;

namespace TurismoWeb.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TuristasController : ControllerBase
    {
        private readonly TurismowebContext _context;

        public TuristasController(TurismowebContext context)
        {
            _context = context;
        }

        // GET: api/Turistas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Turista>>> GetTuristas()
        {

            var turistas = await _context.Turistas.ToListAsync(); 

            return turistas;
     

        }

        // GET: api/Turistas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Turista>> GetTurista(int id)
        {
            var turista = await _context.Turistas.FindAsync(id);

            if (turista == null)
            {
                return NotFound();
            }

            return turista;
        }

        // PUT: api/Turistas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTurista(int id, Turista turista)
        {
            if (id != turista.Id)
            {
                return BadRequest();
            }

            _context.Entry(turista).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TuristaExists(id))
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

        // POST: api/Turistas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Turista>> PostTurista(Turista turista)
        {
            _context.Turistas.Add(turista);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTurista", new { id = turista.Id }, turista);
        }

        // DELETE: api/Turistas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTurista(int id)
        {
            var turista = await _context.Turistas.FindAsync(id);
            if (turista == null)
            {
                return NotFound();
            }

            _context.Turistas.Remove(turista);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TuristaExists(int id)
        {
            return _context.Turistas.Any(e => e.Id == id);
        }
    }
}
