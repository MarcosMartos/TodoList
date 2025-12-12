using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoList.DTOs;

namespace TodoList.Controllers
{
    [Route("api/tareas")]
    [ApiController]
    public class TareasController : ControllerBase
    {

        [HttpGet]
        public void Tareita()
        {
            Console.WriteLine("Estoy funcionando");
        }

        [HttpPost]
        public Task<IEnumerable<CrearTareaRequestDto>> CrearTarea(CrearTareaRequestDto tareaDto)
        {

        }
     
    }
}
