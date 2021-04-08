using System.Linq;
using System.Threading.Tasks;
using ControleOKR.Domain;
using Microsoft.EntityFrameworkCore;

namespace ControleOKR.Repository
{
    public class ControleOKRRepository : IControleOKRRepository
    {
        private readonly ControleOKRContext _context;

        //Construtor do contexto do banco de dados
        public ControleOKRRepository(ControleOKRContext context)
        {
            _context = context;
        }

        //GERAIS
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

        //EMPRESAS
        
        public async Task<Empresa[]> GetAllEmpresasAsync(bool incluirObjetivos = false)
        {
            IQueryable<Empresa> query = _context.Empresas
                .Include(e => e.NomeEmpresa)
                .Include(e => e.PropostaValor);

            // if(incluirObjetivos)
            // {
            //     query = query
            //         .Include(o => o.Objetivos);
            // }

            query = query.OrderByDescending(e => e.NomeEmpresa);

            return await query.ToArrayAsync();
        }

        public async Task<Empresa[]> GetAllEmpresaAsyncByNome(string nomeEmpresa, bool incluirObjetivos)
        {
            IQueryable<Empresa> query = _context.Empresas
                .Include(e => e.NomeEmpresa)
                .Include(e => e.PropostaValor);

            if(incluirObjetivos)
            {
                query = query
                    .Include(o => o.Objetivos);
            }

            query = query.OrderByDescending(e => e.NomeEmpresa)
                .Where(e => e.NomeEmpresa.ToLower().Contains(nomeEmpresa.ToLower()));

            return await query.ToArrayAsync();
        }

        public async Task<Empresa> GetEmpresaAsyncById(int EmpresaId, bool incluirObjetivos)
        {
            IQueryable<Empresa> query = _context.Empresas
                .Include(e => e.NomeEmpresa)
                .Include(e => e.PropostaValor);

            if(incluirObjetivos)
            {
                query = query
                    .Include(o => o.Objetivos);
            }

            query = query.OrderByDescending(e => e.NomeEmpresa)
                .Where(e => e.Id == EmpresaId);

            return await query.FirstOrDefaultAsync();
        }

        //OBJETIVOS
        public Task<Objetivo[]> GetAllObjetivosAsync(bool inluirResultadosChaves)
        {
            throw new System.NotImplementedException();
        }

        public Task<Objetivo[]> GetAllObjetivosAsyncByIdEmpresa(int EmpresaId, bool inluirResultadosChaves)
        {
            throw new System.NotImplementedException();
        }

        public Task<Objetivo> GetObjetivoAsyncById(int ObjetivoId, bool inluirResultadosChaves)
        {
            throw new System.NotImplementedException();
        }

        //RESULTADO CHAVE ATIVIDADE
        public Task<ResultadoChaveAtividade[]> GetAllResultadosChaveAtividadesAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<ResultadoChaveAtividade[]> GetAllResultadosChaveAtividadesAsyncByIdEmpresa(int ResultadoChaveId)
        {
            throw new System.NotImplementedException();
        }
        public Task<ResultadoChaveAtividade> GetResultadoChaveAtividadeAsyncById(int ResultadoChaveAtividadeId)
        {
            throw new System.NotImplementedException();
        }

        //RESULTADO CHAVE
        public Task<ResultadoChave[]> GetAllResultadosChavesAsync(bool inluirAtividadesResultadosChaves)
        {
            throw new System.NotImplementedException();
        }

        public Task<ResultadoChave[]> GetAllResultadosChavesAsyncByObjetivoId(int ObjetivoId, bool inluirAtividadesResultadosChaves)
        {
            throw new System.NotImplementedException();
        }

        public Task<ResultadoChave> GetResultadoChaveAsyncById(int ResultadoChaveId, bool inluirAtividadesResultadosChaves)
        {
            throw new System.NotImplementedException();
        }
    }
}