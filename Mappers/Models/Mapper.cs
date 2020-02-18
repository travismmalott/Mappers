using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mappers.Models
{
    public class Mapper : IdentityUser    
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Branch Branch { get; set; }
        public Base Base { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public bool Notifications { get; set; }
        public bool PublicProfile { get; set; }

    }
}
