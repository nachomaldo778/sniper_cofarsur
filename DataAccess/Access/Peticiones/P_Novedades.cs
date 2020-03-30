using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

using DataAccess.Access.MySQL;
using DataAccess.Models.RRHH.Novedades;
using System.Data;


namespace DataAccess.Access.Peticiones
{
   public class P_Novedades
    {
        MySQL_Access MAccess = new MySQL_Access();

        public IEnumerable<Novedades> GetNovedades(DateTime FECHA)
        {
            var parametros = new List<object>()
            {
                new MySqlParameter(){ ParameterName = "P_FECHA",Value = DateTime.Today}
            };
            var sqlQuery = "SP_NOVEDADES_GET";
            var result = MAccess.GetSavantList<MySqlConnection, Novedades>(sqlQuery, CommandType.StoredProcedure, typeof(MySqlParameterCollection), parametros);

            return result;
        }

    }
}
