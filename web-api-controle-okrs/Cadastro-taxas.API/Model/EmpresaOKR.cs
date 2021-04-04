using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Cadastro_taxas.API.Model
{
    public class EmpresaOKR
    {
        public int Id { get; set; }
        public string NomeEmpresa { get; set; }
        public string PropostaValor { get; set; }
        public ICollection<ObjectKeyResult> ObjectsKeyResults {get;set;}

    }
}