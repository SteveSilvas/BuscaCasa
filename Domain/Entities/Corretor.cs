namespace Domain.Entities
{
    public class Corretor
    {
        public long ID { get; set; }
        public string Sigla { get; set; } = string.Empty;
        public long UsuarioID { get; set; }
        public Usuario? Usuario { get; set; }
        public long? ImobiliariaID { get; set; }
        public Imobiliaria? Imobiliaria { get; set; }
        public ICollection<Visita>? Visitas { get; set; }
    }
}
