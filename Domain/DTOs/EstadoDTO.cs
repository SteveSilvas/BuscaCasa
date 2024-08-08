namespace Domain.DTOs
{
    public class EstadoDTO
    {
        public int ID { get; set; }
        public string Sigla { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public int RegiaoId { get; set; }
    }
}
