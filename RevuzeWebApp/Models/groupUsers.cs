using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RevuzeWebApp.Models
{
    public class groupUsers
    {

    
    [Required]
    public int from { get; set; }

    [Required]

    public IList<userNewDetails> users { get; set; }

    [Required]
    public int to { get; set; }


    
    }



}
