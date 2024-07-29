namespace Domain.Entities
{
    public class TipoComercializacao
    {
        public int Id { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public ICollection<TipoComercializacaoImovel>? TiposComercializacoesImoveis { get; set; }
    }
}
