using Mappers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Group.Models
{
    public class Base
    {
        public int BaseID { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string BaseName { get; set; }

        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public Branch Branch { get; set; }

    }
}
