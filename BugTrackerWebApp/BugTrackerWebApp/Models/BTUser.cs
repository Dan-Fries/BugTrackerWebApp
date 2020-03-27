using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTrackerWebApp.Models
{
    // Extend identity user and change the primary key to an integer
    public class BTUser : IdentityUser<int>
    {
        public BTUser() : base() { }
        // Currently not using these properties for first and last name, will implement later
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Add a reference to UserProjects table so entity framework can build the proper foreign key relationship
        public ICollection<UserProjects> UserProjects { get; set; }
    }
}
