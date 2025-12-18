using TodoList.DTOs;
using TodoList.Models;

namespace TodoList.Services
{
    public class TareasEFService : ITareaService
    {
        private readonly TareasContext _context;

        public TareasEFService(TareasContext context)
        {
            _context = context;
        }


        // Metodo Get
        public async Task<IEnumerable<TareaResponseDto>> GetAll()
        {
            // 1. Obtenemos las ENTIDADES de la base de datos
            var tareasEntidades = await _context.Tareas.ToListAsync();

            // 2. Mapeamos de Entidad -> DTO
            return tareasEntidades.Select(t => new TareaResponseDto
            {
                Id = t.Id,
                Titulo = t.Titulo,
                Descripcion = t.Descripcion,
                EstaCompleta = t.EstaCompleta
            });
        }

        // Metodo Get By ID
        public async Task<TareaResponseDto> GetById(int id)
        {
            var tareaEntidad = await _context.Tareas.FindAsync(id);

            if (tareaEntidad == null)
            {
                return null;
            }

            return new TareaResponseDto
            {
                Id = tareaEntidad.Id,
                Titulo = tareaEntidad.Titulo,
                Descripcion = tareaEntidad.Descripcion,
                EstaCompleta = tareaEntidad.EstaCompleta
            };
        }

        // Metodo Post
        public async Task<TareaResponseDto> PostTarea(CrearTareaRequestDto tareaDTO)
        {
            // 1. Convertimos el DTO a una ENTIDAD de base de datos
            var entidad = new Tarea // Asumiendo que tu modelo de BD se llama TareaEntity
            {
                Titulo = tareaDTO.Titulo,
                Descripcion = tareaDTO.Descripcion,
                EstaCompleta = false
            };

            // 2. Agregamos la entidad al contexto
            _context.Tareas.Add(entidad);

            // 3. Guardamos cambios de forma asíncrona
            await _context.SaveChangesAsync();

            // 4. Retornamos el DTO de respuesta
            return new TareaResponseDto
            {
                Id = entidad.Id,
                Titulo = entidad.Titulo,
                Descripcion = entidad.Descripcion,
                EstaCompleta = entidad.EstaCompleta
            };
        }
    }

}
}
