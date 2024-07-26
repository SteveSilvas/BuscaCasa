namespace Domain.Entities
{
    public class TipoUsuario
    {
        public int Id { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public ICollection<User>? Usuarios { get; set; }
    }
}
