using Microsoft.EntityFrameworkCore;

namespace TodoList.Models
{
    public class TareasContext : DbContext
    {

        public TareasContext(DbContextOptions<TareasContext> options) : base(options) {}

        DbSet<Tarea> Tareas { get; set; }
    }
}
