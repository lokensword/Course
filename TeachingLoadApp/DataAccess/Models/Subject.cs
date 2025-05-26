using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingLoadApp.Models
{
    [Table(Name = "subjects")]
    public class Subject
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "id")]
        public int Id { get; set; }

        [Column(Name = "name")]
        public string Name { get; set; }

        [Column(Name = "hours")]
        public int Hours { get; set; }
    }
}
