using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugTrackerWebApp.ViewModels
{
    public class EditRoleViewModel
    {
        // In the constructor instantiate a list of strings to hold userNames
        public EditRoleViewModel()
        {
            Users = new List<string>();
        }
        public int Id { get; set; }

        [Required(ErrorMessage = "Role name is required")]
        public string Name { get; set; }

        public string Description { get; set; }

        public List<string> Users { get; set; }
    }
}
