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
        string db_host;
        string db_user;
        string db_pass;
        string db_name;
        public string connstring;
        public DbContext() 
        {
            Env.Load();

            db_host = Environment.GetEnvironmentVariable("DB_HOST");
            db_user = Environment.GetEnvironmentVariable("DB_USER");
            db_pass = Environment.GetEnvironmentVariable("DB_PASS");
            db_name = Environment.GetEnvironmentVariable("DB_NAME");

            connstring = $"Host={db_host};Username={db_user};Password={db_pass};Database={db_name};";
        }        
    }
}
