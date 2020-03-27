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
            int userId = Convert.ToInt32(userMgr.GetUserId(HttpContext.User));
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
            int userId = Convert.ToInt32(userMgr.GetUserId(HttpContext.User));
            projectDAO.AddProject(vm.project, userId);
            return RedirectToAction("Index");
        }
    }
}
