using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProAgil.Domain;
using ProAgil.WebApi.Data;

namespace ProAgil.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ProAgilContext _context;

        public WeatherForecastController(ProAgilContext context)
        {
            this._context = context;

        }

        [HttpGet]
        public ActionResult<IEnumerable<Evento>> Get()
        {

            return new Evento[]{
                new Evento(){
                    Id = 1,
                    Tema = "Angular bla bal",
                    Local = "Bem longe",
                    QtdPessoas = 400,
                    DataEvento = DateTime.Now.AddDays(2)
                },
                new Evento(){
                    Id = 1,
                    Tema = "segundo evento bla bal",
                    Local = "Bem",
                    QtdPessoas = 33,
                    DataEvento = DateTime.Now.AddDays(2)
                },

            };
            
        }

    }
}
