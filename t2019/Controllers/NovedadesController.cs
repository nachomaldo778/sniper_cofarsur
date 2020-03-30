using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


using Backend.RRHH.Consultas;
using DataAccess.Models.RRHH.Novedades;

namespace t2019.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NovedadesController : ControllerBase
    {
        private C_Novedades CNovedades = new C_Novedades();

        [HttpGet("getnovedades")]
        [ProducesResponseType(200, Type = typeof(Novedades))]
        [ProducesResponseType(403)]
        [ProducesResponseType(404)]
        public IEnumerable<Novedades> getnovedades([FromQuery]DateTime FECHA) //
        {
            var result = CNovedades.GetNovedades(FECHA);
            return result;
        }
    }
}