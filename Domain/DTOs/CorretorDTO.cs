namespace Domain.DTOs
{
    public class CorretorDTO
    {
        public long ID { get; set; }
        public string Sigla { get; set; } = string.Empty;
        public long UsuarioID { get; set; }
        public long? ImobiliariaID { get; set; }
    }
}
