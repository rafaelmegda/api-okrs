using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ControleOKR.Domain
{
    public class ControleDeOKR
    {
        public int Id { get; set; }
        public int? EmpresaId { get; set; }
        public List<Empresa> Empresas { get; set; }
        public int? ObjetivoId { get; set; }
        public List<Objetivo> Objetivos {get; set;}
    }
}