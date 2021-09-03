using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Oven_Interface.Models;

namespace Oven_Interface
{
    public class DataAccess
    {
        public void Execute(string sql, object parameters)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.GetConnectionString()))
            {
                connection.Execute(sql, parameters);
            }
        }

        public List<T> Query<T>(string sql, DynamicParameters parameters)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.GetConnectionString()))
            {
                return connection.Query<T>(sql, parameters).ToList();
            }
        }
    }
}
