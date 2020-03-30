using System;
using System.Collections.Generic;
using System.Text;

using DataAccess.Access.Peticiones;
using DataAccess.Models.RRHH.Nomina;

namespace Backend.RRHH.Consultas
{

    public class C_Nomina
    {

        P_Nomina PNomina = new P_Nomina();

        public IEnumerable<Nomina> GetNomina(long ID_LEGAJO)
        {
            return PNomina.GetNomina(ID_LEGAJO);
        }

    }
}
