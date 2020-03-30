﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


using Backend.RRHH.Consultas;
using DataAccess.Models.RRHH.Nomina;

namespace t2019.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NominaController : ControllerBase
    {
        private C_Nomina CNomina = new C_Nomina();

        [HttpGet("getnomina")]
        [ProducesResponseType(200, Type = typeof(Nomina))]
        [ProducesResponseType(403)]
        [ProducesResponseType(404)]
        public IEnumerable<Nomina> Getnomina([FromQuery]long param)
        {
            var result = CNomina.GetNomina(param);
            return result;
        }

		public string prueba() { return ""; }
	}

	
}