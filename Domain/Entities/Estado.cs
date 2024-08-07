namespace Domain.Entities
{
    public class Estado
    {
        public int ID { get; set; }
        public string Sigla { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public int RegiaoId { get; set; }
        public Regiao Regiao { get; set; } = new Regiao();
        public ICollection<Municipio>? Municipios { get; set; }
    }
}
