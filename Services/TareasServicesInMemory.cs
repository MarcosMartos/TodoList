using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TodoList.DTOs;

namespace TodoList.Services
{
    public class TareasServicesInMemory : ITareaService
    {
    
        // Creamos una instancia donde guardaremos la informacion recibida (Base de datos)
        private readonly List<TareaResponseDto> _Tareas = new List<TareaResponseDto>()
           {
               new TareaResponseDto { Id = 1, Titulo = "Comprar leche", Descripcion = "aca a la vuelta", EstaCompleta = false },
               new TareaResponseDto { Id = 2, Titulo = "Comprar jabon", Descripcion = "en el chino", EstaCompleta = false }
           };

        // Creamos un método Post para agregar tareas
        public async Task<TareaResponseDto> CrearTareaAsync(CrearTareaRequestDto TareaDto)
        {
            // Simulamos la creación de un nuevo ID dinámico
            int nuevoId = _Tareas.Any() ? _Tareas.Max(t => t.Id) + 1 : 1;

            var nuevaTarea = new TareaResponseDto
            {
                Id = nuevoId,
                Titulo = TareaDto.Titulo,
                Descripcion = TareaDto.Descripcion,
                EstaCompleta = false,
            };

            _Tareas.Add(nuevaTarea);

            return await Task.FromResult(nuevaTarea);

        }

        // Creamos método Get por id
        public async Task<TareaResponseDto?> ObtenerTareaPorIdAsync(int id)
        {
            var respuesta = _Tareas.FirstOrDefault(t => t.Id == id);

            if (respuesta == null)
            {
                return null;
            }

            return await Task.FromResult(respuesta);
        }

        // Creamos método para retornar todas las tareas
        public async Task<IEnumerable<TareaResponseDto>> ObtenerTodasLasTareasAsync()
        {
            return await Task.FromResult(_Tareas);
        }
    }
          
}

       



