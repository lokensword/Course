using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingLoadApp.Models
{
    [Table(Name = "teachers")]
    public class Teacher
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "id")]
        public int Id { get; set; }

        [Column(Name = "first_name")]
        public string FirstName { get; set; }

        [Column(Name = "middle_name")]
        public string MiddleName { get; set; }

        [Column(Name = "last_name")]
        public string LastName { get; set; }

        [Column(Name = "load_limit")]
        public int LoadLimit { get; set; }

        [Column(Name = "id_user")]
        public int UserId { get; set; }
    }
}
