namespace Domain.DTOs
{
    public class ImovelDTO
    {
        public long Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int StatusImovelID { get; set; }
        public int TipoUsoImovelID { get; set; }
        public int TipoConstrucaoImovelID { get; set; }
    }
}
