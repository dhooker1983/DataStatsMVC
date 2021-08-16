using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStatsMVC.Areas.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public DateTime CareerStart { get; set; }
        public bool CurrentlyEmployed { get; set; }
        public string Gender { get; set; }
    }
}
