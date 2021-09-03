using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Oven_Interface.Controllers
{
    public static class BreadsController
    {
        public static List<Bread> Index()
        {
            DynamicParameters parameters = new DynamicParameters();
            string sql = $"With AllMinutes AS (SELECT tp.Minute, tp.BreadId FROM TemperaturePoints tp UNION SELECT vp.Minute, vp.BreadId FROM ValvePoints vp UNION SELECT pp.Minute, pp.BreadId FROM PressurePoints pp ) SELECT Id, Name, (SELECT MAX(Minute) FROM AllMinutes am WHERE am.BreadId = br.Id ) AS Duration FROM Breads br";
            DataAccess db = new DataAccess();
            return db.Query<Bread>(sql, parameters);
        }

        public static int Create(string name)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
            parameters.Add("@Name", name);
            
            string sql = $@"INSERT INTO dbo.Breads (Name) VALUES (@Name);" +
                         $@"SELECT @Id = @@IDENTITY";

            DataAccess db = new DataAccess();
            db.Execute(sql, parameters);

            int newIdentity = parameters.Get<int>("@Id");

            return newIdentity;
        }

        public static void Delete(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id", id);
            string sql = $"DELETE FROM TemperaturePoints WHERE BreadId = @ID; " +
                         $"DELETE FROM ValvePoints WHERE BreadId = @ID; " +
                         $"DELETE FROM PressurePoints WHERE BreadId = @ID; " +
                         $"DELETE FROM LaunchInstances WHERE BreadId = @ID; " +
                         $"DELETE FROM Breads WHERE Id = @ID;";
            DataAccess db = new DataAccess();
            db.Execute(sql, parameters);
        }

        public static void Update(int breadId, int minutesPassed)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
            parameters.Add("@MinutesPassed", minutesPassed);
            parameters.Add("@BreadId", breadId);

            string sql = $@"UPDATE dbo.LaunchInstances SET MinutesPassed=@MinutesPassed WHERE (BreadId = @BreadId AND Status = 'started');";

            DataAccess db = new DataAccess();
            db.Execute(sql, parameters);
        }

        public static void Finish(int breadId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
            parameters.Add("@Status", "finished");
            parameters.Add("@BreadId", breadId);

            string sql = $@"UPDATE dbo.LaunchInstances SET Status=@Status WHERE (BreadId = @BreadId AND Status = 'started');";

            DataAccess db = new DataAccess();
            db.Execute(sql, parameters);
        }
    }
}
