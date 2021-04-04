using Cadastro_taxas.API.Model;
using Microsoft.EntityFrameworkCore;

namespace Cadastro_taxas.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options) : base (options)
        {
        }
        public DbSet<EmpresaOKR> EmpresaOKR { get; set; }
        public DbSet<KeyResult> Atividades_Chaves { get; set; }
        public DbSet<AtividadeKeyResult> Atividades_Resultados_Chaves { get; set; }
        public DbSet<ObjectKeyResult> Resultado_Objetos_Chaves { get; set; }
        public DbSet<PlanejamentoMeta> Planejamento_Metas { get; set; }
    }
}