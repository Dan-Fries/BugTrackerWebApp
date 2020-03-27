using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BugTrackerWebApp.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        [Column(TypeName = "Date")]
        public DateTime StartDate { get; set; }
        public DateTime DateCreated { get; set; }
        // Add a reference to the Bugs table so entity framework can build the proper foreign key relationship
        public ICollection<Bug> Bugs { get; set; }
        // Add a reference to the UserProjects table so entity framework can build the proper foreign key relationship
        public ICollection<UserProjects> UserProjects { get; set; }

    }
}
