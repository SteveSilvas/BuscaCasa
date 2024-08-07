namespace Domain.Entities
{
    public class Proprietario
    {
        public long ID { get; set; }
        public long UsuarioID { get; set; }
        public Usuario? Usuario { get; set; }
        public ICollection<Propriedade>? Propriedades { get; set; }
    }
}
