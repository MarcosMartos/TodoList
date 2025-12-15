using TodoList.DTOs;

namespace TodoList.Services
{
    public interface ITareaService
    {
        // Método para crear una tarea
        Task<TareaResponseDto> CrearTareaAsync(CrearTareaRequestDto tareaDto);

        // Método para buscar una tarea por id
        Task<TareaResponseDto?> ObtenerTareaPorIdAsync(int id);

        // Método para buscar todas las tareas
        Task<IEnumerable<TareaResponseDto>> ObtenerTodasLasTareasAsync();
    }
}
