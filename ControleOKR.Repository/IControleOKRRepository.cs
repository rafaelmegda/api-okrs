using System.Threading.Tasks;
using ControleOKR.Domain;

namespace ControleOKR.Repository
{
    public interface IControleOKRRepository
    {
        //GERAL
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;

        Task<bool> SaveChangesAsync();

        //EMPRESAS
        Task<Empresa[]> GetAllEmpresaAsyncByNome(string nome, bool inluirObjetivos);
        Task<Empresa[]> GetAllEmpresasAsync(bool incluirObjetivos);
        Task<Empresa> GetEmpresaAsyncById(int EmpresaId, bool incluirObjetivos);

        //OBJETIVOS
        Task<Objetivo[]> GetAllObjetivosAsyncByIdEmpresa(int EmpresaId, bool inluirResultadosChaves);
        Task<Objetivo[]> GetAllObjetivosAsync(bool inluirResultadosChaves);
        Task<Objetivo> GetObjetivoAsyncById(int ObjetivoId, bool inluirResultadosChaves);

        //RESULTADO CHAVE
        Task<ResultadoChave[]> GetAllResultadosChavesAsyncByObjetivoId(int ObjetivoId, bool inluirAtividadesResultadosChaves);
        Task<ResultadoChave[]> GetAllResultadosChavesAsync(bool inluirAtividadesResultadosChaves);
        Task<ResultadoChave> GetResultadoChaveAsyncById(int ResultadoChaveId, bool inluirAtividadesResultadosChaves);

        //RESULTADO CHAVE ATIVIDADE
        Task<ResultadoChaveAtividade[]> GetAllResultadosChaveAtividadesAsyncByIdEmpresa(int ResultadoChaveId);
        Task<ResultadoChaveAtividade[]> GetAllResultadosChaveAtividadesAsync();
        Task<ResultadoChaveAtividade> GetResultadoChaveAtividadeAsyncById(int ResultadoChaveAtividadeId);
    }
}