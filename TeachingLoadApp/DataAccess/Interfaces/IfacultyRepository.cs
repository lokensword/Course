﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachingLoadApp.Models;

namespace TeachingLoadApp.DataAccess.Interfaces
{
    public interface IFacultyRepository
    {
        IEnumerable<Faculty> GetAll();
        Faculty GetById(int id);
        int Add(Faculty faculty);
        void Delete(int id);
        void Update(Faculty faculty);

    }
}
