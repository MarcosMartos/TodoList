//using Microsoft.AspNetCore.Http.HttpResults;
//using TodoList.DTOs;

//namespace TodoList.Services
//{

//    // Cumplimos con los requisitos de la interfaz ITareaService
//    public class Tarea
//    {
//        public int Id { get; set; }
//        public string? Titulo { get; set; }
//        public string? Descripcion { get; set; }
//        public bool EstaCompleta { get; set; } = false;
//    }
//    public class TareasServices : ITareaService
//    {
//        private readonly List<Tarea> _tareas = new List<Tarea>();
//        private int _nextId = 1; // Para simular la generación de ID

//        public async Task<TareaResponseDto> CrearTarea(CrearTareaRequestDto tareaDto)
//        {
//            // Validar dto
//            if (string.IsNullOrEmpty(tareaDto.Titulo))
//            {
//                return BadRequest(); ;
//            }
//            // Pasar info del dto a Dominio
//            var nuevaTarea = new Tarea
//            {
//                Id: _nextId++,
//                Titulo = tareaDto.Titulo,
//                Descripcion = tareaDto.Descripcion,
//                EstaCompleta = false
//            }
//         };

//        }

//    }
//}
