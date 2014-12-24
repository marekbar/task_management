using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskLibrary.Models
{
    public class User : Table
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public static List<User> GetAll(ref DB db)
        {
            return db.users.Select(s => new User() 
            {
                Id = s.id,
                Login = s.login,
                Name = s.name,
                Surname = s.surname
            }).ToList();
        }
    }
}
