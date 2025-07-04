using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingLoadApp.Context
{
    public static class DbHandler
    {
        public static DbContext CreateContext()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["TeachingLoadDb"].ConnectionString;
            return new DbContext(connectionString);
        }
    }
}
