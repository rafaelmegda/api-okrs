using System;

namespace Cadastro_taxas.API.Model
{
    public class PlanejamentoMetaObjetivos
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Porcentagem { get; set; }
    }
}