using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ControleOKR.Domain
{
    public class ResultadoChave
    {
        public int Id { get; set; }
        public string DescricaoResultadoChave { get; set; }
        public string Reponsavel { get; set; }
        public int? ObjetivoId { get; set; }
        public Objetivo Objetivo { get; set; }

        //public int PesoTotalDaAtividadeSobreResultado { get; set; } fazer o calculo manualmente
        
        //public double PorcentagemTotalConcluida {get; set;} não precisa armazenar, calcular e exibir na tela
        
        
        
    }
}