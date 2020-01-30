using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Group.Models
{
    public class Mapper : IdentityUser
    {
        public int MapperID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }        

        public string CurrentBase { get; set; }
        public bool Notifications { get; set; }
        public bool PublicProfile { get; set; }

    }
}
