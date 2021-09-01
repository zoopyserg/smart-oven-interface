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
        public List<Bread> GetBreads()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.GetConnectionString()))
            {
                return connection.Query<Bread>($"select * from Breads").ToList();
            }
        }

        public List<Bread> GetBread(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.GetConnectionString()))
            {
                return connection.Query<Bread>($"dbo.spBreads_GetById @ID", new { ID = id } ).ToList();
            }
        }

        public int InsertBread(string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.GetConnectionString()))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
                parameters.Add("@Name", name);

                string sql = $@"insert into dbo.Breads (Name) values (@Name); select @Id = @@IDENTITY";

                connection.Execute(sql, parameters);

                int newIdentity = parameters.Get<int>("@Id");

                return newIdentity;
            }
        }

        public FullBread GetBreadWithPoints(int id)
        {
            FullBread bread = null;
            List<FullBread> breads = null;
            List<TemperaturePoint> temperaturePoints = null;
            List<PressurePoint> pressurePoints = null;
            List<ValvePoint> valvePoints = null;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.GetConnectionString()))
            {
                var parameters = new
                {
                    ID = id
                };

                string sql = @"select * from dbo.Breads where Id = @ID; select * from dbo.TemperaturePoints where BreadId = @ID; select * from dbo.PressurePoints where BreadId = @ID; select * from dbo.ValvePoints where BreadId = @ID;";

                using (var lists = connection.QueryMultiple(sql, parameters))
                {
                    breads = lists.Read<FullBread>().ToList();
                    temperaturePoints = lists.Read<TemperaturePoint>().ToList();
                    pressurePoints = lists.Read<PressurePoint>().ToList();
                    valvePoints = lists.Read<ValvePoint>().ToList();
                }

                bread = breads[0];

                bread.TemperaturePoints = temperaturePoints;
                bread.PressurePoints = pressurePoints;
                bread.ValvePoints = valvePoints;
                // maybe try-catch transaction? so that it logs errors instead of getting exception and crashing?
                // cnn.Open()
                // using trans = cnn.BeginTransaction
                // try
                // cnn.Execute(sql, parameters, trans)
                // trans.Commit()
                // catch
                // trans.Rollback();
                // plus some logging code
                // something like that.
            }

            return bread;
        }
    }
}
