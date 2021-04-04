using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Cadastro_taxas.API.Model
{
    public class PlanejamentoMeta
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Porcentagem { get; set; }
    }
}