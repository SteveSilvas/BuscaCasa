namespace Domain.DTOs
{
    public class ImobiliariaDTO
    {
        public long ID { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string CNPJ { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public long EnderecoID { get; set; }
    }
}
