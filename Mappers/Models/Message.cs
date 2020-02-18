using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mappers.Models
{
    public class Message
    {
        public int MessageID { get; set; }
        [Required]
        public string Text { get; set; }
    }
}
