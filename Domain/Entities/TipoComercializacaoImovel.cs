namespace Domain.Entities
{
    public class TipoComercializacaoImovel
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public int TipoComercializacaoID { get; set; }
        public TipoComercializacao? TipoComercializacao { get; set; }
        public int ImovelID { get; set; }
        public Imovel? Imovel { get; set; }
    }
}
