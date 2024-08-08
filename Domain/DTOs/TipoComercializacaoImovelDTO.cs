namespace Domain.DTOs
{
    public class TipoComercializacaoImovelDTO
    {
        public int ID { get; set; }
        public decimal Valor { get; set; }
        public int TipoComercializacaoID { get; set; }
        public long ImovelID { get; set; }
    }
}
