using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugTrackerWebApp.Models
{
    public class AddProjectViewModel
    {
        public string ProjectName { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        public Project project
        {
            get
            {
                return new Project()
                {
                    ProjectName = this.ProjectName,
                    StartDate = this.StartDate,
                    DateCreated = DateTime.Now
                };
            }
        }
    }
}
