using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTrackerWebApp.Models
{
    public class BTUser : IdentityUser<int>
    {
        public BTUser() : base() { }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
