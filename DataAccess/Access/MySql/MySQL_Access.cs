using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using DataAccess.Models.RRHH;
using DataAccess.Models.RRHH.Nomina;
using DbConnector.Core;
using System.Data.Common;




namespace DataAccess.Access.MySQL
{
   public class MySQL_Access
    {

        private readonly string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString.ToString();



        /*--------------GET LIST-------------*/
        public IEnumerable<T> GetSavantList<TResult, T>(string sqlQuery, CommandType comandType, Type tipo, List<object> parameters = null)
                where TResult : DbConnection where T : new()
        {
            var _dbConnector = new DbConnector<TResult>(cadena);

            return _dbConnector.Read<T>(
                  onInit: (cmd) =>
                  {
                      cmd.CommandType = comandType;
                      cmd.CommandText = sqlQuery.ToUpper();

                      if (parameters != null)
                      {
                          cmd.Parameters.AddRange(parameters.ToArray());
                          cmd.GetDbParameters();

                      }

                  }).Execute();

        }










    }
}
