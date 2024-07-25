namespace Domain.Entities
{
    public class User
    {
        public int Id{ get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; } = new byte[32];
        public byte[] PasswordSalt{ get; set; } = new byte[32];
        //public string Role { get; internal set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int StatusId { get; set; }
        public Status? Status { get; set; }
    }
}
