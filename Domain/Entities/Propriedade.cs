namespace Domain.Entities
{
    public class Propriedade
    {
        public long ID { get; set; }
        public long ProprietarioID { get; set; }
        public Proprietario? Proprietario { get; set; }
        public long ImobiliariaID { get; set; }
        public Imobiliaria? Imobiliaria { get; set; }
        public long ImovelID { get; set; }
        public Imovel? Imovel { get; set; }
    }
}
