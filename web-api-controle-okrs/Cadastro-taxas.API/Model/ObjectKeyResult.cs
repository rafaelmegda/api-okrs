using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Cadastro_taxas.API.Model
{
    public class ObjectKeyResult
    {
        public int Id { get; set; }
        public string DescricaoObjetivo { get; set; }
        public int TotalAtividades { get; set; }
        public int TotalRealizado { get; set; }
        public double Porcentagem { get; set; }
        public ICollection<KeyResult> KeysResults { get; set; }
        public ICollection<PlanejamentoMeta> PlanejamentosMetas { get; set; }    
    }
}