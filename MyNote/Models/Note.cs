using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyNote.Models
{
    public class Note
    {
        public int id { get; set; }
        [Required]
        [DisplayName("Opis")]
        public string description { get; set; }

        public DateTime dataTime { get; set; }
    }
}
