using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ControleOKR.Domain
{
    public class ResultadoChave
    {
        public int Id { get; set; }
        public string DescricaoResultadoChave { get; set; }
        public string Reponsavel { get; set; }
        public int? ResultadoChaveAtividadeId { get; set; }
        public List<ResultadoChaveAtividade> AtividadesResultadoChave { get; set; }

        //public int PesoTotalDaAtividadeSobreResultado { get; set; } fazer o calculo manualmente
        
        //public double PorcentagemTotalConcluida {get; set;} não precisa armazenar, calcular e exibir na tela
        
        
        
    }
}