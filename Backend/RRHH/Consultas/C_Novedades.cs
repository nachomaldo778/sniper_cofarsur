using System;
using System.Collections.Generic;
using System.Text;

using DataAccess.Access.Peticiones;
using DataAccess.Models.RRHH.Novedades;

namespace Backend.RRHH.Consultas
{
    public class C_Novedades
    {

        P_Novedades PNovedades = new P_Novedades();

        public IEnumerable<Novedades> GetNovedades(DateTime FECHA)
        {
            return PNovedades.GetNovedades(FECHA);
        }


    }
}
