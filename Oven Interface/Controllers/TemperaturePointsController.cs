﻿using Dapper;
using Oven_Interface.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oven_Interface.Controllers
{
    public static class TemperaturePointsController
    {
        public static List<TemperaturePoint> Index(int breadId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@BreadId", breadId);
            string sql = $"SELECT Id, Minute, Value FROM TemperaturePoints WHERE BreadId = @BreadId ORDER BY Minute ASC";
            DataAccess db = new DataAccess();
            return db.Query<TemperaturePoint>(sql, parameters);
        }

        public static int Create(int breadId, int minute, int value)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id", 0, DbType.Int32, ParameterDirection.Output);
            parameters.Add("@Minute", minute);
            parameters.Add("@Value", value);
            parameters.Add("@BreadId", breadId);

            string sql = $@"INSERT INTO dbo.TemperaturePoints (Minute, Value, BreadId) VALUES (@Minute, @Value, @BreadId);" +
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
            string sql = $"DELETE FROM TemperaturePoints WHERE Id = @ID";
            DataAccess db = new DataAccess();
            db.Execute(sql, parameters);
        }

    }
}
