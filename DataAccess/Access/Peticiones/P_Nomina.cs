using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

using DataAccess.Access.MySQL;
using DataAccess.Models.RRHH.Nomina;
using System.Data;

namespace DataAccess.Access.Peticiones
{
    public class P_Nomina
    {

        MySQL_Access MAccess = new MySQL_Access();

        public IEnumerable<Nomina> GetNomina(long id_legajo)
        {
            var parametros = new List<object>()
            {
                new MySqlParameter(){ ParameterName = "P_ID", Value = (id_legajo > 0) ? id_legajo.ToString() : DBNull.Value.ToString()},
            };
            var sqlQuery = "SP_NOMINA_GET";
            var result = MAccess.GetSavantList<MySqlConnection, Nomina>(sqlQuery, CommandType.StoredProcedure, typeof(MySqlParameterCollection), parametros);

            return result;
        }
    }
}
