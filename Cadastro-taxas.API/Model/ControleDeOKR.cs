using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Cadastro_taxas.API.Model
{
    public class ControleDeOKR
    {
        public int Id { get; set; }
        public Empresa Empresas {get; set;}
        public ICollection<Objetivo> Objetivos {get; set;}
    }
}