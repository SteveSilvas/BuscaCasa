namespace Domain.Entities
{
    public class StatusImovel
    {
        public int ID { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public ICollection<Imovel>? Imoveis { get; set; }
    }
}
