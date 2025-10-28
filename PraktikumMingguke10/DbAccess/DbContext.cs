using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetEnv;

namespace PraktikumMingguke10.DbAccess
{
    public class DbContext
    {
        static string db_host = Environment.GetEnvironmentVariable("DB_HOST");
        static string db_user = Environment.GetEnvironmentVariable("DB_USER");
        static string db_pass = Environment.GetEnvironmentVariable("DB_PASS");
        static string db_name = Environment.GetEnvironmentVariable("DB_NAME");
        public static string connstring = $"Host={db_host};Username={db_user};Password={db_pass};Database={db_name};";
        public DbContext() 
        {
            Env.Load();

            db_host = Environment.GetEnvironmentVariable("DB_HOST");
            db_user = Environment.GetEnvironmentVariable("DB_USER");
            db_pass = Environment.GetEnvironmentVariable("DB_PASS");
            db_name = Environment.GetEnvironmentVariable("DB_NAME");

           
        }       
    }
}
