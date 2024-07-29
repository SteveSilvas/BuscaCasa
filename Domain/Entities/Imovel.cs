namespace Domain.Entities
{
    public class Imovel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int StatusImovelID { get; set; }
        public StatusImovel? StatusImovel { get; set; }
        public int TipoUsoImovelID { get; set; }
        public TipoUsoImovel? TipoUsoImovel{ get; set; }
        public int TipoConstrucaoImovelID { get; set; }
        public TipoConstrucaoImovel? TipoConstrucaoImovel { get; set; }
    }
}
