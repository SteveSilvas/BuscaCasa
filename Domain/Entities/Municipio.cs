namespace Domain.Entities
{
    public class Municipio
    {
        public int ID { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int EstadoId { get; set; }
        public Estado? Estado { get; set; }
        public ICollection<Endereco>? Enderecos { get; set; }
    }
}
