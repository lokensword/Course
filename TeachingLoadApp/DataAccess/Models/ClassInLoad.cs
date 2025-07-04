using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingLoadApp.Models
{
    [Table(Name = "class_in_load")]
    public class ClassInLoad
    {
        [PrimaryKey, Identity, Column(Name = "id")]
        public int Id { get; set; }

        [Column(Name = "id_class"), NotNull]
        public int ClassId { get; set; }

        [Column(Name = "id_load"), NotNull]
        public int LoadId { get; set; }
    }
}

