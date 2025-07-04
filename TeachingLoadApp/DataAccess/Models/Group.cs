using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingLoadApp.Models
{
    [Table(Name = "groups")]
    public class Group
    {
        [PrimaryKey, Identity, Column(Name = "id")]
        public int Id { get; set; }

        [Column(Name = "name"), NotNull]
        public string Name { get; set; }

        [Column(Name = "id_faculty"), NotNull]  
        public int FacultyId { get; set; }
    }
}
