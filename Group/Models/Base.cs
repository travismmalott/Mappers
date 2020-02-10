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
        public string BaseName { get; set; }
        public string StateName { get; set;}       
        public State State { get; set; }
        public Branch Branch { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<Mapper> Mappers { get; set; }

        //Out of scope - integration of Google Maps for Base Page
        //public double Longitude { get; set; }
        //public double Latitude { get; set; }
        

    }
}
