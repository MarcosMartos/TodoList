using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoList.DTOs;

namespace TodoList.Controllers
{
    [Route("api/tareas")]
    [ApiController]
    public class TareasController : ControllerBase
    {
        // Solicitud GET
        [HttpGet]
        public ActionResult<IEnumerable<TareaResponseDto>> TodasLasTareas()
        {
            var tareaEjemplo = new List<TareaResponseDto>()
            {
                new TareaResponseDto {Id = 1, Titulo = "Titulo 1", Descripcion = "descripcion 1", EstaCompleta = false},
                new TareaResponseDto { Id = 2, Titulo = "Titulo 2", Descripcion = "descripcion 2", EstaCompleta=false},
            };

            return Ok(tareaEjemplo);

        }

        // Solicitud GET por ID
        [HttpGet("{Id}")]
        public ActionResult<TareaResponseDto> TareaPorId(int Id)
        {
            if (Id == 1)
            {
                var tareaEjemplo = new TareaResponseDto { Id = 1, Titulo = "Tarea Dinámica", Descripcion = $"Obtenida por ID: {Id}", EstaCompleta = false };
                return Ok(tareaEjemplo);
            }

            return NotFound();
        }

        // Solicitud POST
        [HttpPost]
        public ActionResult<TareaResponseDto> CrearTarea([FromBody] CrearTareaRequestDto tareaDto)
        {
            Console.WriteLine($"Título: {tareaDto.Titulo}");
            Console.WriteLine($"Descripción: {tareaDto.Descripcion}");


            var respuesta = new TareaResponseDto()
            {
                Id = new Random().Next(100, 1000),
                Titulo = tareaDto.Titulo,
                Descripcion = tareaDto.Descripcion,
                EstaCompleta = false,
            };

            return StatusCode(StatusCodes.Status201Created, respuesta);
        }
     
    }
}
