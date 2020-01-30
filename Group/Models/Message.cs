using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Mappers.Model
{
    public class Message
    {
        public int MessageID { get; set; }
        [Required]
        public string Text { get; set; }
    }
}
