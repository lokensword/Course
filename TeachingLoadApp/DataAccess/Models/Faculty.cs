using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingLoadApp.Models
{
    [Table(Name = "faculties")]
    public class Faculty
    {
        [PrimaryKey, Identity, Column(Name = "id")]
        public int Id { get; set; }

        [Column(Name = "short_name"), NotNull]
        public string ShortName { get; set; }

        [Column(Name = "full_name"), NotNull]
        public string FullName { get; set; }
    }
}
