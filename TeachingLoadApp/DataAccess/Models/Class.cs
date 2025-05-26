using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingLoadApp.Models
{
    [Table(Name = "classes")]
    public class Class
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "id")]
        public int Id { get; set; }

        [Column(Name = "type")]
        public string Type { get; set; }

        [Column(Name = "id_subject")]
        public int SubjectId { get; set; }

        [Column(Name = "id_group")]
        public int GroupId { get; set; }

        [Column(Name = "class_hours")]
        public int ClassHours { get; set; }
    }
}
