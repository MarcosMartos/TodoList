using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoList.Models
{
    public class Tarea
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TareaId { get; set; }
        public string? TareaTitulo { get; set; }
        public string? TareaDescripcion { get; set; }
        public bool EstaCompleta { get; set; }

    }
}
