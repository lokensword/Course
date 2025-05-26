using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingLoadApp.Context
{
    public class DbHandler
    {
        private readonly string _connectionString;
        private DbContext _context;

        public DbHandler()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["TeachingLoadDb"].ConnectionString;
            _context = new DbContext(_connectionString);
        }

        public DbContext Context => _context;
    }
}
