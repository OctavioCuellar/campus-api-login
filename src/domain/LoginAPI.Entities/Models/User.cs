using System.Collections.Generic;

namespace LoginAPI.Entities.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        
        public IEnumerable<Role> Roles { get; set; }
    }
}