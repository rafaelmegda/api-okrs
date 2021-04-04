using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Cadastro_taxas.API.Model
{
    public class ResultadoChaveAtividade
    {
        public int Id { get; set; }
        public string DescricaoAtividade { get; set; }
        public double TotalConcluidoDaAtividade { get; set; }
        public int PesoDaAtividade { get; set; }
        
        //public int TotalConcluidoEmRelacaoAoPesoTotal { get; set; } não armazenar, calcular

    }
}