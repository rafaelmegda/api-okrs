using System.Threading.Tasks;
using ControleOKR.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cadastro_taxas.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ResultadoChaveController : ControllerBase
    {
        public readonly ControleOKRContext _context;

        public ResultadoChaveController(ControleOKRContext context)
        {
            _context = context;
        }

        [HttpGet]
       public async Task<IActionResult> Get()
       {
           try
           {
                var results = await _context.ResultadosChaves.ToListAsync();

                return Ok(results);
           }
           catch (System.Exception)
           {
               return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");
           }           
       }

        //Get api/ResultadoChave/1
       [HttpGet("{id}")]
       public async Task<IActionResult> Get(int id)
       {
           try
           {
                var results = await _context.ResultadosChaves.FirstOrDefaultAsync(x => x.Id == id);

                return Ok(results);
           }
           catch (System.Exception)
           {
               return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");
           }  
       }
        
    }
}