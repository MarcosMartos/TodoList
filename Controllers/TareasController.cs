using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoList.DTOs;
using TodoList.Services;

namespace TodoList.Controllers
{
    [Route("api/tareas")]
    [ApiController]
    public class TareasController : ControllerBase
    {
        private readonly ITareaService _tareasService;

        public TareasController(ITareaService tareasService)
        {
            _tareasService = tareasService;
        }


        // Solicitud GET
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TareaResponseDto>>> ObtenerTodasLasTareasAsync()
        {
            var tarea = await _tareasService.ObtenerTodasLasTareasAsync();
            return Ok(tarea);
        }

        // Solicitud GET por ID
        [HttpGet("{Id}")]
        public async Task<ActionResult<TareaResponseDto>> ObtenerTareaPorIdAsync(int Id)
        {
            var tarea = await _tareasService.ObtenerTareaPorIdAsync(Id);

            if (tarea == null)
            {
                return NotFound($"No se encontró la tarea con ID: {Id}");
            }
            return Ok(tarea);
        }

        // Solicitud POST
        [HttpPost]
        public async Task<ActionResult<TareaResponseDto>> CrearTareaAsync([FromBody] CrearTareaRequestDto tareaDto)
        {
            // Llamamos al método asíncrono del servicio
            var respuesta = await _tareasService.CrearTareaAsync(tareaDto);

            // Devolver 201 Created (HTTP status code)
            return StatusCode(StatusCodes.Status201Created, respuesta);
        }
     
    }
}
