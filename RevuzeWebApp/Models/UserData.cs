using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RevuzeWebApp.Models
{
    public class UserData
    {
        [Required]
        public string ID { get; set; }
        [Required]
        public string date { get; set; }
        [Required]
        public int age { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string address { get; set; }

    }
}
