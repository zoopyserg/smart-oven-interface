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
                return connection.Query<Bread>($"SELECT Id, Name FROM Breads").ToList();
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

        internal List<TemperaturePoint> GetTemperaturePoints(int breadId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.GetConnectionString()))
            {
                return connection.Query<TemperaturePoint>($"SELECT Id, Minute, Value FROM TemperaturePoints WHERE BreadId = @BreadId ORDER BY Minute ASC", new { BreadId = breadId }).ToList();
            }
        }

        public List<Bread> GetBreadWithPoints(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.GetConnectionString()))
            {
                Bread bread = null;
                List<Bread> breads = null;
                List<TemperaturePoint> temperaturePoints = null;
                List<PressurePoint> pressurePoints = null;
                List<ValvePoint> valvePoints = null;

                var parameters = new
                {
                    ID = id
                };

                string sql = @"select * from dbo.Breads where Id = @ID; select * from dbo.TemperaturePoints where BreadId = @ID; select * from dbo.PressurePoints where BreadId = @ID; select * from dbo.ValvePoints where BreadId = @ID;";

                using (var lists = connection.QueryMultiple(sql, parameters))
                {
                    breads = lists.Read<Bread>().ToList();
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

                return breads;
            }
        }

        public int InsertTemperaturePoint(int breadId, int minute, int value)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.GetConnectionString()))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
                parameters.Add("@Minute", minute);
                parameters.Add("@Value", value);
                parameters.Add("@BreadId", breadId);

                string sql = $@"insert into dbo.TemperaturePoints (Minute, Value, BreadId) values (@Minute, @Value, @BreadId); select @Id = @@IDENTITY";

                connection.Execute(sql, parameters);

                int newIdentity = parameters.Get<int>("@Id");

                return newIdentity;
            }
        }

        public void DeleteProgram(int breadId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.GetConnectionString()))
            {
                connection.Query($"DELETE FROM TemperaturePoints WHERE BreadId = @ID; DELETE FROM Breads WHERE Id = @ID;", new { ID = breadId });
            }
        }

        public void DeleteTemperaturePoint(int temperatutrePointId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.GetConnectionString()))
            {
                connection.Query($"DELETE FROM TemperaturePoints WHERE Id = @ID", new { ID = temperatutrePointId });
            }
        }
    }
}
