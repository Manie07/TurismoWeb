using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TurismoWeb.Server.Data;
using TurismoWeb.Server.Entities;

namespace TurismoWeb.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly DataContext _context;

        public UsuarioController(DataContext context)
        {
            _context = context;
        }



        [HttpGet]
        public async Task<ActionResult<List<Usuario>>> GetAllUsuarios()
        {
            var Usuarios = await _context.usuariosprueba.ToListAsync();

            
            return Ok(Usuarios);
        }

        [HttpGet("{id}")]
   
        public async Task<ActionResult<Usuario>> GetUsuario(int id)
        {
            var Usuarios = await _context.usuariosprueba.FindAsync(id);
            if (Usuarios == null) 
                return BadRequest("usuario no encontrado.");


            return Ok(Usuarios);
        }

        [HttpPost]

        public async Task<ActionResult<List<Usuario>>> AddUsuario(Usuario usuario)
        {
            _context.usuariosprueba.Add(usuario);
            await _context.SaveChangesAsync();


            return Ok(await _context.usuariosprueba.ToListAsync());
        }

        [HttpPut]

        public async Task<ActionResult<List<Usuario>>> UpdateUsuario(Usuario updatedusuario)
        {
            var turismoweb = await _context.usuariosprueba.FindAsync(updatedusuario.Id);
            if (turismoweb is null)
                return BadRequest("usuario no encontrado.");

            turismoweb.Name = updatedusuario.Name;
            turismoweb.PrimerNombre = updatedusuario.PrimerNombre;
            turismoweb.Apellido = updatedusuario.Apellido;
            turismoweb.Lugar = updatedusuario.Lugar;
            await _context.SaveChangesAsync();


            return Ok(await _context.usuariosprueba.ToListAsync());
        }

        [HttpDelete]

        public async Task<ActionResult<List<Usuario>>> DeleteUsuario(int id)
        {
            var turismoweb = await _context.usuariosprueba.FindAsync(id);
            if (turismoweb is null)
                return BadRequest("usuario no encontrado.");

            _context.usuariosprueba.Remove(turismoweb);
            await _context.SaveChangesAsync();


            return Ok(await _context.usuariosprueba.ToListAsync());
        }
    }

}
