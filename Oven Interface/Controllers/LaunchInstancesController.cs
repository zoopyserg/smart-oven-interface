using Dapper;
using Oven_Interface.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oven_Interface.Controllers
{
    public static class LaunchInstancesController
    {
        public static List<LaunchInstance> Index(int breadId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@BreadId", breadId);
            string sql = $"SELECT Id, Status, MinutesPassed, CreatedAt, BreadId FROM LaunchInstances WHERE BreadId = @BreadId ORDER BY CreatedAt DESC";
            DataAccess db = new DataAccess();
            return db.Query<LaunchInstance>(sql, parameters);
        }

        public static int Create(int breadId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
            parameters.Add("@Status", "started");
            parameters.Add("@MinutesPassed", 0);
            parameters.Add("@CreatedAt", DateTime.Now);
            parameters.Add("@BreadId", breadId);

            string sql = $@"INSERT INTO dbo.LaunchInstances (Status, MinutesPassed, BreadId, CreatedAt) VALUES (@Status, @MinutesPassed, @BreadId, @CreatedAt);" +
                         $@"SELECT @Id = @@IDENTITY";

            DataAccess db = new DataAccess();
            db.Execute(sql, parameters);

            int newIdentity = parameters.Get<int>("@Id");

            return newIdentity;
        }
    }
}
