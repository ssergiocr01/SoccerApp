using Datos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Modelos.Usuario;

namespace Api.Controllers
{
    public class UsuarioController : BaseApiController
    {
        private ApplicationDbContext _db;

        public UsuarioController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuarios()
        {
            var usuarios = await _db.Usuarios.ToListAsync();
            return Ok(usuarios);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> GetUsuario(int id)
        {
            var usuario = await _db.Usuarios.FindAsync(id); 
            return Ok(usuario);
        }
    }
}
