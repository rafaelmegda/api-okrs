using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Cadastro_taxas.API.Model
{
    public class KeyResult
    {
        public int Id { get; set; }
        public string NomeKeyResuts { get; set; }
        public string Reponsavel { get; set; }
        public double PorcentaAtividadeConcluida {get; set;}
        public double TotalConcluidoRelacionadoAoPeso { get; set; }
        public int TotalDoPesoDaAtividade { get; set; }
        public ICollection<AtividadeKeyResult> AtividadesKeyResults { get; set; }
    }
}