using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingLoadApp.Models
{
    [Table(Name = "load")]
    public class Load
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "id")]
        public int Id { get; set; }

        [Column(Name = "semestr")]
        public string Semestr { get; set; }

        [Column(Name = "id_teacher")]
        public int TeacherId { get; set; }

        [Column(Name = "load_hours")]
        public int LoadHours { get; set; }
    }
}
