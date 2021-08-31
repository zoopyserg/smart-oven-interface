using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Oven_Interface
{
    public class DataAccess
    {
        public List<Bread> GetBreads()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("OvenDataDB")))
            {
                return connection.Query<Bread>($"select * from dbo.Breads").ToList();
            }
        }

        public List<Bread> GetBread(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("OvenDataDB")))
            {
                return connection.Query<Bread>($"dbo.spBreads_GetById @ID", new { ID = id } ).ToList();
            }
        }

        public void InsertBread(string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("OvenDataDB")))
            {
                List<Bread> breads = new List<Bread>();
                breads.Add(new Bread { Name = name });
                connection.Execute("dbo.spBreads_Insert @Name", breads);
            }
        }
    }
}
