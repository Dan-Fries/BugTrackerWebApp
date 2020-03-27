using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTrackerWebApp.Models
{
    public class BTRole : IdentityRole<int>
    {
        public BTRole() : base() { }
        
    }
}
