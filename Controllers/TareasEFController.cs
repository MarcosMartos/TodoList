using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoList.DTOs;
using TodoList.Models;

namespace TodoList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TareasEFController : ControllerBase
    {
        private TareasContext _context;

        public TareasEFController(TareasContext context)
        {
            _context = context;
        }

        // Método GET
        [HttpGet]
        public async Task<IEnumerable<TareaResponseDto>> GetTarea()
        {
            return await _context.Tareas.Select(t => new TareaResponseDto
            {
                Id = t.Id,
                Titulo = t.Titulo,
                Descripcion = t.Descripcion,
                EstaCompleta = t.EstaCompleta,
            }).ToListAsync();
        }
    }
}
