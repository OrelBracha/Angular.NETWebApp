using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RevuzeWebApp.Models
{
    public class UsersList
    {
    [Required]
    public IList<UserData> users { get; set; }
    
    
    }
}
