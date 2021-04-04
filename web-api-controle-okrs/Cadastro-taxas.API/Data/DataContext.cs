using Cadastro_taxas.API.Model;
using Microsoft.EntityFrameworkCore;

namespace Cadastro_taxas.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options) : base (options)
        {
        }
        public DbSet<Empresa> EMPRESAS { get; set; }
        public DbSet<ControleDeOKR> CONTROLE_OKRS { get; set; }
        public DbSet<Objetivo> OBJETIVOS { get; set; }
        public DbSet<PlanejamentoMetaObjetivos> PLANEJAMENTO_METAS_DOS_OBJETIVOS { get; set; }
        public DbSet<ResultadoChave> RESULTADO_CHAVE { get; set; }
        public DbSet<ResultadoChaveAtividade> RESULTADO_CHAVE_ATIVIDADE { get; set; }
    }
}