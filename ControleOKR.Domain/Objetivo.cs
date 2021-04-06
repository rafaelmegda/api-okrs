using System.Collections;
using System.Collections.Generic;
using System;

namespace ControleOKR.Domain
{
    public class Objetivo
    {
        public int Id { get; set; }
        public string DefinicaoObjetivo { get; set; }
        public DateTime DataParaMeta { get; set; }
        public double PorcentagemRealizadaDaMeta { get; set; }
        public int? EmpresaId { get; set; }
        public Empresa Empresa { get; set; }        

        //public int Meta { get; set; } pegar a quantidade de atividades da KR e colocar aqui
        //public int QuantidadeRealizada { get; set; } se chegar o resultado chegar a 100% colocar realizada
        //public double PorcentagemRealizada {get; set;} fazer o calculo para chegar neste valor
    }
}