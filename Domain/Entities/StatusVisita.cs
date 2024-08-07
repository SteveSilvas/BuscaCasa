namespace Domain.Entities
{
    public class StatusVisita
    {
        public int ID { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public ICollection<Visita>? Visitas { get; set; }
    }
}
