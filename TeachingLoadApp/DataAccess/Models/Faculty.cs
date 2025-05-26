using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingLoadApp.Models
{
    [Table(Name = "faculties")]
    public class Faculty
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "id")]
        public int Id { get; set; }

        [Column(Name = "short_name")]
        public string ShortName { get; set; }

        [Column(Name = "full_name")]
        public string FullName { get; set; }
    }
}
