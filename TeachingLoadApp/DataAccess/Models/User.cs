using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingLoadApp.Models
{
    [Table(Name = "user")]
    public class AppUser
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "id")]
        public int Id { get; set; }

        [Column(Name = "login")]
        public string Login { get; set; }

        [Column(Name = "password")]
        public string Password { get; set; }

        [Column(Name = "role")]
        public string Role { get; set; }
    }
}
