namespace Domain.Entities
{
    public class Imobiliaria
    {
        public long ID { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string CNPJ { get; set; } = string.Empty;
        public string Email { get; set;} = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public long EnderecoID{ get; set; }
        public Endereco? Endereco { get; set;}
        public ICollection<Propriedade>? Propriedades { get; set; }
        public ICollection<Corretor>? Corretores { get; set; }
    }
}
