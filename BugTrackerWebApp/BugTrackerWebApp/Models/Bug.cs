using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTrackerWebApp.Models
{
    public class Bug
    {
        public int BugId { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateResolved { get; set; }
        public int ProjectId { get; set; }
    }
}
