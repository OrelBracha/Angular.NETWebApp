using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RevuzeWebApp.Models
{
    public class userNewDetails
    {
    



    [Required]
    public string full_name { get; set; }
    [Required]
    public string birth_date { get; set; }

    [Required]
    public string address { get; set; }

        
        public void addDetails(string _full_name, string _birth_date, string _address)
        {
            full_name = _full_name;
            birth_date = _birth_date;
            address = _address;
        }
    }
}
