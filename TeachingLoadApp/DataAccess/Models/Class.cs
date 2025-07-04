using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingLoadApp.Models
{
    [Table(Name = "classes")]
    public class Class
    {
        [PrimaryKey, Identity, Column(Name = "id")]
        public int Id { get; set; }

        [Column(Name = "type")]
        public string Type { get; set; }

        [Column(Name = "id_subject"), NotNull]
        public int SubjectId { get; set; }

        [Column(Name = "id_group"), NotNull]
        public int GroupId { get; set; }

        [Column(Name = "class_hours"), NotNull]
        public int ClassHours { get; set; }
    }
}
