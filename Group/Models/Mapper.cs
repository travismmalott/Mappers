using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Group.Models
{
    public class Mapper
    {
        public int MapperID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string password { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public string currentBase { get; set; }
        public bool notifications { get; set; }
        public bool publicOrPrivate { get; set; }

    }
}
