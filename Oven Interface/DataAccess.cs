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
                return connection.Query<Bread>($"With AllMinutes AS (SELECT tp.Minute, tp.BreadId FROM TemperaturePoints tp UNION SELECT vp.Minute, vp.BreadId FROM ValvePoints vp UNION SELECT pp.Minute, pp.BreadId FROM PressurePoints pp ) SELECT Id, Name, (SELECT MAX(Minute) FROM AllMinutes am WHERE am.BreadId = br.Id ) AS Duration FROM Breads br").ToList();
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

        internal List<LaunchInstance> GetLaunchInstances(int breadId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.GetConnectionString()))
            {
                return connection.Query<LaunchInstance>($"SELECT Id, Status, MinutesPassed, CreatedAt, BreadId FROM LaunchInstances WHERE BreadId = @BreadId ORDER BY CreatedAt DESC", new { BreadId = breadId }).ToList();
            }
        }

        internal List<ValvePoint> GetValvePoints(int breadId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.GetConnectionString()))
            {
                return connection.Query<ValvePoint>($"SELECT Id, Minute, Value FROM ValvePoints WHERE BreadId = @BreadId ORDER BY Minute ASC", new { BreadId = breadId }).ToList();
            }
        }

        internal List<PressurePoint> GetPressurePoints(int breadId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.GetConnectionString()))
            {
                return connection.Query<PressurePoint>($"SELECT Id, Minute, Value FROM PressurePoints WHERE BreadId = @BreadId ORDER BY Minute ASC", new { BreadId = breadId }).ToList();
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

                string sql = @"select *, (SELECT MAX(Minute) FROM TemperaturePoints WHERE tp.BreadId = @Id) AS Duration from dbo.Breads where Id = @ID; 
                               select * from dbo.TemperaturePoints where BreadId = @ID; 
                               select * from dbo.PressurePoints where BreadId = @ID; 
                               select * from dbo.ValvePoints where BreadId = @ID;";

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
                connection.Query($"DELETE FROM TemperaturePoints WHERE BreadId = @ID; DELETE FROM LaunchInstances WHERE BreadId = @ID; DELETE FROM Breads WHERE Id = @ID;", new { ID = breadId });
            }
        }

        public void DeleteTemperaturePoint(int temperatutrePointId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.GetConnectionString()))
            {
                connection.Query($"DELETE FROM TemperaturePoints WHERE Id = @ID", new { ID = temperatutrePointId });
            }
        }

        public int InsertLaunchInstance(int breadId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.GetConnectionString()))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
                parameters.Add("@Status", "started");
                parameters.Add("@MinutesPassed", 0);
                parameters.Add("@CreatedAt", DateTime.Now);
                parameters.Add("@BreadId", breadId);

                string sql = $@"insert into dbo.LaunchInstances (Status, MinutesPassed, BreadId, CreatedAt) values (@Status, @MinutesPassed, @BreadId, @CreatedAt); select @Id = @@IDENTITY";

                connection.Execute(sql, parameters);

                int newIdentity = parameters.Get<int>("@Id");

                return newIdentity;
            }
        }

        public void UpdateProgramTimePassed(int breadId, int minutesPassed)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.GetConnectionString()))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
                parameters.Add("@MinutesPassed", minutesPassed);
                parameters.Add("@BreadId", breadId);

                string sql = $@"UPDATE dbo.LaunchInstances SET MinutesPassed=@MinutesPassed WHERE (BreadId = @BreadId AND Status = 'started');";

                connection.Execute(sql, parameters);
            }
        }

        public void FinishProgram(int breadId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.GetConnectionString()))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
                parameters.Add("@Status", "finished");
                parameters.Add("@BreadId", breadId);

                string sql = $@"UPDATE dbo.LaunchInstances SET Status=@Status WHERE (BreadId = @BreadId AND Status = 'started');";

                connection.Execute(sql, parameters);
            }
        }

        internal void DeletePressurePoint(int pressurePointId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.GetConnectionString()))
            {
                connection.Query($"DELETE FROM PressurePoints WHERE Id = @ID", new { ID = pressurePointId });
            }
        }

        internal void DeleteValvePoint(int valvePointId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.GetConnectionString()))
            {
                connection.Query($"DELETE FROM ValvePoints WHERE Id = @ID", new { ID = valvePointId });
            }
        }

        public int InsertPressurePoint(int breadId, int minute, int value)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.GetConnectionString()))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
                parameters.Add("@Minute", minute);
                parameters.Add("@Value", value);
                parameters.Add("@BreadId", breadId);

                string sql = $@"insert into dbo.PressurePoints (Minute, Value, BreadId) values (@Minute, @Value, @BreadId); select @Id = @@IDENTITY";

                connection.Execute(sql, parameters);

                int newIdentity = parameters.Get<int>("@Id");

                return newIdentity;
            }
        }

        public int InsertValvePoint(int breadId, int minute, int value)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.GetConnectionString()))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
                parameters.Add("@Minute", minute);
                parameters.Add("@Value", value);
                parameters.Add("@BreadId", breadId);

                string sql = $@"insert into dbo.ValvePoints (Minute, Value, BreadId) values (@Minute, @Value, @BreadId); select @Id = @@IDENTITY";

                connection.Execute(sql, parameters);

                int newIdentity = parameters.Get<int>("@Id");

                return newIdentity;
            }
        }
    }
}
