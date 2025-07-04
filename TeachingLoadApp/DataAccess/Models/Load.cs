using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingLoadApp.Models
{
    [Table(Name = "load")]
    public class Load
    {
        [PrimaryKey, Identity, Column(Name = "id")]
        public int Id { get; set; }

        [Column(Name = "semestr"), NotNull]
        public string Semestr { get; set; }

        [Column(Name = "id_teacher"), NotNull]
        public int TeacherId { get; set; }

        [Column(Name = "load_hours"), NotNull]
        public int LoadHours { get; set; }
    }
}
