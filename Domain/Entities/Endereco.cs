﻿namespace Domain.Entities
{
    public class Endereco
    {
        public long ID { get; set; }
        public string Rua { get; set; } = string.Empty;
        public string Numero { get; set; } = string.Empty;
        public string Complemento { get; set; } = string.Empty;
        public string Bairro { get; set; } = string.Empty;
        public string CEP { get; set; } = string.Empty;
        public int MunicipioId { get; set; }
        public Municipio Municipio { get; set; } = new Municipio();
        public ICollection<Imobiliaria>? Imobiliarias { get; set; }
    }
}