namespace Domain.Entities
{
    public class Usuario
    {
        public long ID{ get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; } = new byte[32];
        public byte[] PasswordSalt{ get; set; } = new byte[32];
        //public string Role { get; internal set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int StatusId { get; set; }
        public StatusUsuario? Status { get; set; }
        public int TipoUsuarioID { get; set; }
        public TipoUsuario? TipoUsuario { get; set; }
        public ICollection<Corretor>? Corretores { get; set; }
        public ICollection<Favorito>? Favoritos { get; set; }
        public ICollection<Proprietario>? Proprietarios { get; set; }
        public ICollection<Visita>? Visitas { get; set; }
    }
}
