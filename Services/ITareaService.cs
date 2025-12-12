using TodoList.DTOs;

namespace TodoList.Services
{
    public interface ITareaService
    {
        Task<TareaResponseDto> CrearTarea(CrearTareaRequestDto tareaDto);

    }
}
