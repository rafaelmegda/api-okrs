using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ControleOKR.Domain
{
    public class Empresa
    {
        public int Id { get; set; }
        public string NomeEmpresa { get; set; }
        public string PropostaValor { get; set; }
        public IList<Objetivo> Objetivos { get; set; } = new List<Objetivo>();
    }
    
}