using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingLoadApp.Models
{
    [Table(Name = "subjects")]
    public class Subject
    {
        [PrimaryKey, Identity, Column(Name = "id")]
        public int Id { get; set; }

        [Column(Name = "name"), NotNull]
        public string Name { get; set; }

        [Column(Name = "hours"), NotNull]
        public int Hours { get; set; }
    }
}
