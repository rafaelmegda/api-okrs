using System.Threading.Tasks;
using ControleOKR.Domain;

namespace ControleOKR.Repository
{
    public class ControleOKRRepository : IControleOKRRepository
    {
        public void Add<T>(T entity) where T : class
        {
            throw new System.NotImplementedException();
        }

        public void Delete<T>(T entity) where T : class
        {
            throw new System.NotImplementedException();
        }

        public Task<Empresa[]> GetAllEmpresaAsyncByNome(string nome, bool inluirObjetivos)
        {
            throw new System.NotImplementedException();
        }

        public Task<Empresa[]> GetAllEmpresasAsync(bool incluirObjetivos)
        {
            throw new System.NotImplementedException();
        }

        public Task<Objetivo[]> GetAllObjetivosAsync(bool inluirResultadosChaves)
        {
            throw new System.NotImplementedException();
        }

        public Task<Objetivo[]> GetAllObjetivosAsyncByIdEmpresa(int EmpresaId, bool inluirResultadosChaves)
        {
            throw new System.NotImplementedException();
        }

        public Task<ResultadoChaveAtividade[]> GetAllResultadosChaveAtividadesAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<ResultadoChaveAtividade[]> GetAllResultadosChaveAtividadesAsyncByIdEmpresa(int ResultadoChaveId)
        {
            throw new System.NotImplementedException();
        }

        public Task<ResultadoChave[]> GetAllResultadosChavesAsync(bool inluirAtividadesResultadosChaves)
        {
            throw new System.NotImplementedException();
        }

        public Task<ResultadoChave[]> GetAllResultadosChavesAsyncByObjetivoId(int ObjetivoId, bool inluirAtividadesResultadosChaves)
        {
            throw new System.NotImplementedException();
        }

        public Task<Empresa> GetEmpresaAsyncById(int EmpresaId, bool incluirObjetivos)
        {
            throw new System.NotImplementedException();
        }

        public Task<Objetivo> GetObjetivoAsyncById(int ObjetivoId, bool inluirResultadosChaves)
        {
            throw new System.NotImplementedException();
        }

        public Task<ResultadoChave> GetResultadoChaveAsyncById(int ResultadoChaveId, bool inluirAtividadesResultadosChaves)
        {
            throw new System.NotImplementedException();
        }

        public Task<ResultadoChaveAtividade> GetResultadoChaveAtividadeAsyncById(int ResultadoChaveAtividadeId)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> SaveChangesAsync()
        {
            throw new System.NotImplementedException();
        }

        public void Update<T>(T entity) where T : class
        {
            throw new System.NotImplementedException();
        }
    }
}