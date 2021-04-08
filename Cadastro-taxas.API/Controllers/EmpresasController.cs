using System.Threading.Tasks;
using ControleOKR.Domain;
using ControleOKR.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cadastro_taxas.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmpresasController : ControllerBase
    {
        private readonly IControleOKRRepository _repository;

        public EmpresasController(IControleOKRRepository repository)
        {
            _repository = repository;
        }
    
        //GET api/Empresas
       [HttpGet]
       public async Task<IActionResult> Get()
       {
           try
           {
                var results = await _repository.GetAllEmpresasAsync(true);

                return Ok(results);
           }
           catch (System.Exception)
           {
               return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");
           }           
       }

        //Get api/Empresas/1
       [HttpGet("{empresaid}")]
       public async Task<IActionResult> Get(int EmpresaId)
       {
           try
           {
                var results = await _repository.GetAllObjetivosAsyncByIdEmpresa(EmpresaId, true);

                return Ok(results);
           }
           catch (System.Exception)
           {
               return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");
           }  
       }

        //Get api/Empresas/NomeEmpresa
       [HttpGet("getByNomeEmpresa/{nomeempresa}")]
       public async Task<IActionResult> Get(string NomeEmpresa)
       {
           try
           {
                var results = await _repository.GetAllEmpresaAsyncByNome(NomeEmpresa, true);

                return Ok(results);
           }
           catch (System.Exception)
           {
               return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");
           }  
       }

       [HttpPost]
       public async Task<IActionResult> Post(Empresa model)
       {
           try
           {
                _repository.Add(model);

                if(await _repository.SaveChangesAsync())
                {
                    return Ok();
                    //return Created($"/api/empresas/{model.Id}", model);
                }
           }
           catch (System.Exception)
           {
               return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");
           }  

           return BadRequest();
       }

       [HttpPut]
       public async Task<IActionResult> Put(int empresaId, Empresa model)
       {
           try
           {
               var empresa = await _repository.GetAllObjetivosAsyncByIdEmpresa(empresaId, false);
                if(empresa == null) return NotFound();

                _repository.Update(model);

                if(await _repository.SaveChangesAsync())
                {
                    return Created($"/api/empresas/{model.Id}", model);
                }
           }
           catch (System.Exception)
           {
               return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");
           }  

           return BadRequest();
       }

       [HttpDelete]
       public async Task<IActionResult> Delete(int empresaId)
       {
           try
           {
               var empresa = await _repository.GetAllObjetivosAsyncByIdEmpresa(empresaId, false);
                if(empresa == null) return NotFound();

                _repository.Delete(empresa);

                if(await _repository.SaveChangesAsync())
                {
                    return Ok();
                }
           }
           catch (System.Exception)
           {
               return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");
           }  

           return BadRequest();
       }

    }
}