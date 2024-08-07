namespace Domain.Entities
{
    public class Visita
    {
        public long ID { get; set; }
        public DateTime Data { get; set; }
        public long UsuarioID { get; set; }
        public Usuario? Usuario { get; set; }
        public long ImovelID { get; set; }
        public Imovel? Imovel { get; set; }
        public long CorretorID { get; set; }
        public Corretor? Corretor { get; set; }
        public int StatusVisitaID { get; set; }
        public StatusVisita? StatusVisita { get; set; } 
    }
}
