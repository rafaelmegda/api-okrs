using System.Collections;
using System.Collections.Generic;

namespace Cadastro_taxas.API.Model
{
    public class Objetivo
    {
        public int id { get; set; }
        public string DefinicaoObjetivo { get; set; }
        public PlanejamentoMetaObjetivos PlanejamentoMetas { get; set; }
        public ICollection<ResultadoChave> ResultadosChaves { get; set; }

        //public int Meta { get; set; } pegar a quantidade de atividades da KR e colocar aqui
        //public int QuantidadeRealizada { get; set; } se chegar o resultado chegar a 100% colocar realizada
        //public double PorcentagemRealizada {get; set;} fazer o calculo para chegar neste valor
    }
}