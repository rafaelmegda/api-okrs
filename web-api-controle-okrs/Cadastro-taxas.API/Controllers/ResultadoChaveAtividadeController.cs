using System.Threading.Tasks;
using Cadastro_taxas.API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cadastro_taxas.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ResultadoChaveAtividadeController : ControllerBase
    {
        public readonly DataContext _context;

        public ResultadoChaveAtividadeController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
       public async Task<IActionResult> Get()
       {
           try
           {
                var results = await _context.RESULTADO_CHAVE.ToListAsync();

                return Ok(results);
           }
           catch (System.Exception)
           {
               return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");
           }           
       }

        //Get api/ResultadoChaveAtividade/1
       [HttpGet("{id}")]
       public async Task<IActionResult> Get(int id)
       {
           try
           {
                var results = await _context.RESULTADO_CHAVE.FirstOrDefaultAsync(x => x.Id == id);

                return Ok(results);
           }
           catch (System.Exception)
           {
               return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");
           }  
       }

    }
}