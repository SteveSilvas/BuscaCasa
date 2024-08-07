namespace Domain.Entities
{
    public class Favorito
    {
        public long ID { get; set; }
        public long ImovelID {get;set;}
        public Imovel? Imovel {get;set;}
        public long UsuarioID { get; set; }
        public Usuario? Usuario { get; set; }
    }
}
