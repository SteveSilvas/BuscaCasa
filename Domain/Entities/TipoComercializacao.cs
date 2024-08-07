namespace Domain.Entities
{
    public class TipoComercializacao
    {
        public int ID { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public ICollection<TipoComercializacaoImovel>? TiposComercializacoesImoveis { get; set; }
    }
}
