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
        public string firstName { get; set; }
        public string lastName { get; set; }       
           
        public string currentBase { get; set; }
        public bool Notifications { get; set; }
        public bool Public { get; set; }

    }
}
