namespace Domain.Entities
{
    public class Imovel
    {
        public long ID { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int StatusImovelID { get; set; }
        public StatusImovel? StatusImovel { get; set; }
        public int TipoUsoImovelID { get; set; }
        public TipoUsoImovel? TipoUsoImovel{ get; set; }
        public int TipoConstrucaoImovelID { get; set; }
        public TipoConstrucaoImovel? TipoConstrucaoImovel { get; set; }
        public ICollection<Favorito>? Favoritos { get; set; }
        public ICollection<Propriedade>? Propriedades { get; set; }
    }
}
