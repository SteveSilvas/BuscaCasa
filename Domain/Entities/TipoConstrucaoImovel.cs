namespace Domain.Entities
{
    public class TipoConstrucaoImovel
    {
        public int ID { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public ICollection<Imovel>? Imoveis { get; set; }
    }
}
