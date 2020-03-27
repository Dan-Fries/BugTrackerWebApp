using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTrackerWebApp.Models
{
    public class UserProjects
    {
        public int BTUserId { get; set; } 
        public BTUser BTUser { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
