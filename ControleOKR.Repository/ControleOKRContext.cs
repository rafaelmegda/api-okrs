using Microsoft.EntityFrameworkCore;
using ControleOKR.Domain;

namespace ControleOKR.Repository
{
    public class ControleOKRContext : DbContext
    {
        public ControleOKRContext(DbContextOptions<ControleOKRContext>options) : base (options)
        {
        }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<ControleDeOKR> ControleDeOKRs { get; set; }
        public DbSet<Objetivo> Objetivos { get; set; }
        public DbSet<PlanejamentoMetaObjetivos> PlanejamentoMetasObjetivos { get; set; }
        public DbSet<ResultadoChave> ResultadosChaves { get; set; }
        public DbSet<ResultadoChaveAtividade> ResultadosChavesAtividades { get; set; }

        //n para n
        // protected override void OnModelCreating(){

        // }
    }
}