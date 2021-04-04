using System.Threading.Tasks;
using Cadastro_taxas.API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cadastro_taxas.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]        
    public class ObjetivosController : ControllerBase
    {
        public readonly DataContext _context;

        public ObjetivosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
       public async Task<IActionResult> Get()
       {
           try
           {
                var results = await _context.OBJETIVOS.ToListAsync();

                return Ok(results);
           }
           catch (System.Exception)
           {
               return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");
           }           
       }

       //Get api/Objetivos/1
       [HttpGet("{id}")]
       public async Task<IActionResult> Get(int id)
       {
           try
           {
                var results = await _context.OBJETIVOS.FirstOrDefaultAsync(x => x.id == id);

                return Ok(results);
           }
           catch (System.Exception)
           {
               return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");
           }  
       }
    }
}