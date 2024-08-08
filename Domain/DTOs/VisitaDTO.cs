namespace Domain.DTOs
{
    public class VisitaDTO
    {
        public long ID { get; set; }
        public DateTime Data { get; set; }
        public long UsuarioID { get; set; }
        public long ImovelID { get; set; }
        public long CorretorID { get; set; }
        public int StatusVisitaID { get; set; }
    }
}
