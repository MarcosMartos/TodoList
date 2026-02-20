namespace TodoList.DTOs
{
    public class ActualizarTareaRequestDto
    {
            public string? Titulo { get; set; }
            public string? Descripcion { get; set; }
            public bool EstaCompleta { get; set; }
    }
}
