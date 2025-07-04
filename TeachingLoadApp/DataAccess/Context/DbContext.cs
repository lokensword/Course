using LinqToDB.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using LinqToDB.Mapping;
using System.Text;
using System.Threading.Tasks;
using TeachingLoadApp.Models;
using LinqToDB;

namespace TeachingLoadApp.Context
{
    public class DbContext : DataConnection
    {
        public DbContext(string connectionString)
            : base("MySql.Data.MySqlClient", connectionString)
        {
        }

        public ITable<AppUser> Users => this.GetTable<AppUser>();
        public ITable<Teacher> Teachers => this.GetTable<Teacher>();
        public ITable<Faculty> Faculties => this.GetTable<Faculty>();
        public ITable<Group> Groups => this.GetTable<Group>();
        public ITable<Subject> Subjects => this.GetTable<Subject>();
        public ITable<Class> Classes => this.GetTable<Class>();
        public ITable<Load> Loads => this.GetTable<Load>();
        public ITable<ClassInLoad> ClassInLoads => this.GetTable<ClassInLoad>();
    }
}



