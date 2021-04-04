using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Cadastro_taxas.API.Model
{
    public class AtividadeKeyResult
    {
        public int Id { get; set; }
        public string DescricaoAtividade { get; set; }
        public double TotalConcluido { get; set; }
        public double PorcentagemConcluidoAtividadePeso { get; set; }
        public int PesoDaAtividade { get; set; }
    }
}