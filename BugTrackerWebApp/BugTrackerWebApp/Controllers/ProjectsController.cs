using BugTrackerWebApp.DAL;
using BugTrackerWebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTrackerWebApp.Controllers
{
    [Authorize]
    public class ProjectsController : Controller
    {
        private readonly IProjectDAO projectDAO;
        private readonly UserManager<BTUser> userMgr;

        public ProjectsController(IProjectDAO projectDAO, UserManager<BTUser> userManager)
        {
            this.projectDAO = projectDAO;
            this.userMgr = userManager;
        }

        public IActionResult Index()
        {
            // Get the userId through the User Manager
            int userId = Convert.ToInt32(userMgr.GetUserId(HttpContext.User));

            // Use the User Id to build a list of projects that the user is a part of
            return View(projectDAO.GetProjectsForUserId(userId));
        }

        [HttpGet]
        public IActionResult AddProject()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProject(AddProjectViewModel vm)
        {
            // Get the userId through user manager and call the Add Project method to create a new project and add the required information to the association table
            int userId = Convert.ToInt32(userMgr.GetUserId(HttpContext.User));
            projectDAO.AddProject(vm.project, userId);
            return RedirectToAction("Index", "Projects");
        }
    }
}
