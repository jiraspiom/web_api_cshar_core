using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProAgil.WebApi.Data;

namespace ProAgil.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class VentoController: ControllerBase
    {
        private readonly ProAgilContext _context;

        public VentoController(ProAgilContext context)
        {
            this._context = context;
            
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var results = await _context.Eventos.ToListAsync();
                return Ok(results);
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Erro no Banco de dados");
            }
      
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {   
                var results = await _context.Eventos.FirstOrDefaultAsync(x => x.Id == id);
                return Ok(results);
            }
            catch (System.Exception)
            {
                
                return this.StatusCode(StatusCodes.Status500InternalServerError, "erro em algum lugar");
            }
        }

    }
}