using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingLoadApp.Models
{
    [Table(Name = "teachers")]
    public class Teacher
    {
        [PrimaryKey, Identity, Column(Name = "id")]
        public int Id { get; set; }

        [Column(Name = "first_name"), NotNull]
        public string FirstName { get; set; }

        [Column(Name = "middle_name"), NotNull]
        public string MiddleName { get; set; }

        [Column(Name = "last_name"), NotNull]
        public string LastName { get; set; }

        [Column(Name = "load_limit"), NotNull]
        public int LoadLimit { get; set; }

        [Column(Name = "id_user"), NotNull]
        public int UserId { get; set; }
    }
}
