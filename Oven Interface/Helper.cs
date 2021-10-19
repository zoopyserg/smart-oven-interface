using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;
using System.Diagnostics;

namespace Oven_Interface
{
    public static class Helper
    {
        public static string GetConnectionString(string name = "OvenDataDB2")
        {
            string commonData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            string pathToDBFile = Path.Combine(commonData, "Oven Interface", "OvenDatabase.mdf");
            string connectionString = $"Data Source=(localdb)\\MSSQLLocalDB;AttachDbFilename={pathToDBFile};Trusted_Connection=true";
            return connectionString;
            //return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
