using Microsoft.EntityFrameworkCore;

namespace TodoList.Models
{
    public class TareasContext : DbContext
    {

        public TareasContext(DbContextOptions<TareasContext> options) : base(options) {}

        public DbSet<Tarea> Tareas { get; set; }
    }
}
