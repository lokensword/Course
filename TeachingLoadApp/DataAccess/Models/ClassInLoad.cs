using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace TeachingLoadApp.Models
{
    [Table(Name = "class_in_load")]
    public class ClassInLoad
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "id")]
        public int Id { get; set; }

        [Column(Name = "id_class")]
        public int ClassId { get; set; }

        [Column(Name = "id_load")]
        public int LoadId { get; set; }
    }
}

