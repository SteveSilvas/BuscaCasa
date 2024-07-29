namespace Domain.Entities
{
    public class TipoConstrucaoImovel
    {
        public int Id { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public ICollection<Imovel>? Imoveis { get; set; }
    }
}
