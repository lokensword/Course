using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingLoadApp.Models
{
    [Table(Name = "user")]
    public class AppUser
    {
        [PrimaryKey, Identity, Column(Name = "id")]
        public int Id { get; set; }

        [Column(Name = "login"), NotNull]
        public string Login { get; set; }

        [Column(Name = "password"), NotNull]
        public string Password { get; set; }

        [Column(Name = "role"), NotNull]
        public string Role { get; set; }
    }
}
