namespace Domain.Entities
{
    public class TipoUsuario
    {
        public int ID { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public ICollection<Usuario>? Usuarios { get; set; }
    }
}
