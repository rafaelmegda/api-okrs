using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ControleOKR.Domain
{
    public class ResultadoChaveAtividade
    {
        public int Id { get; set; }
        public string DescricaoAtividade { get; set; }
        public double TotalConcluidoDaAtividade { get; set; }
        public int PesoDaAtividade { get; set; }
        public int? ResultadoChaveId { get; set; }
        public ResultadoChave ResultadoChave { get; set; }
                
        //public int TotalConcluidoEmRelacaoAoPesoTotal { get; set; } não armazenar, calcular

    }
}