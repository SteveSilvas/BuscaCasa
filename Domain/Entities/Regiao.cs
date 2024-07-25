namespace Domain.Entities
{
    public class Regiao
    {
        public int Id { get; set; }
        public string Sigla { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;

        public ICollection<Estado>? Estados { get; set; }
    }
}
