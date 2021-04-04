using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cadastro_taxas.API.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Cadastro_taxas.API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Cadastro_taxas.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        public readonly DataContext _context;

        public ValuesController(DataContext context)
        {
            _context = context;
        }
        
    //    [HttpGet]
    //    public async Task<IActionResult> Get()
    //    {
    //        try
    //        {
    //             var results = await _context.Eventos.ToListAsync();

    //             return Ok(results);
    //        }
    //        catch (System.Exception)
    //        {
    //            return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");
    //        }           
    //    }

        //Get api/values/1
    //    [HttpGet("{id}")]
    //    public async Task<IActionResult> Get(int id)
    //    {
    //        try
    //        {
    //             var results = await _context.Eventos.FirstOrDefaultAsync(x => x.EventoId == id);

    //             return Ok(results);
    //        }
    //        catch (System.Exception)
    //        {
    //            return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");
    //        }  
    //    }
    }
}
