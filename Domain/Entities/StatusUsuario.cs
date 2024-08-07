namespace Domain.Entities
{
    public class StatusUsuario
    {
        public int ID { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public ICollection<Usuario>? Usuarios { get; set; }
    }
}
