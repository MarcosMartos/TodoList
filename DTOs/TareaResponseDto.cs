namespace TodoList.DTOs
{
    public class TareaResponseDto
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Descripcion { get; set; }
        public bool EstaCompleta { get; set; }

    }
}
