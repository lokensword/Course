using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Linq;
using System.Data.Linq.Mapping;

using TeachingLoadApp.Models;

namespace TeachingLoadApp.Context
{
    public class DbContext : DataContext
    {
        public DbContext(string connectionString) : base(connectionString) { }

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
