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
        public ICollection<Bug> Bugs { get; set; }
        public ICollection<UserProjects> UserProjects { get; set; }

    }
}
