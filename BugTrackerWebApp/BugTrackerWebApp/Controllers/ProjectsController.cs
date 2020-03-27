using BugTrackerWebApp.DAL;
using BugTrackerWebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTrackerWebApp.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly IProjectDAO projectDAO;

        public ProjectsController(IProjectDAO projectDAO)
        {
            this.projectDAO = projectDAO;
        }

        public IActionResult Index()
        {
            return View(projectDAO.GetAllProjects());
        }

        [HttpGet]
        [Authorize]
        public IActionResult AddProject()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult AddProject(AddProjectViewModel vm)
        {
            projectDAO.AddProject(vm.project);
            return RedirectToAction("Index");
        }
    }
}
