using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Group.Models
{
    public class Review
    {
        public int ReviewID { get; set; }
        public string reviewContent { get; set; }
        public DateTime DatePosted { get; set; }
        public Photo locationPhoto { get; set; }
        public Base Base { get; set; }
        public Mapper Mapper { get; set; }
    }
}
