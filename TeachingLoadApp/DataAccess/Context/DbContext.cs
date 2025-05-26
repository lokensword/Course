using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachingLoadApp.Models;

namespace TeachingLoadApp.Context
{
    public class DbContext : DataContext
    {
        public DbContext(IDbConnection connection) : base(connection) { }

        public Table<AppUser> Users;
        public Table<Teacher> Teachers;
        public Table<Faculty> Faculties;
        public Table<Group> Groups;
        public Table<Subject> Subjects;
        public Table<Class> Classes;
        public Table<Load> Loads;
        public Table<ClassInLoad> ClassInLoads;
    }

}
