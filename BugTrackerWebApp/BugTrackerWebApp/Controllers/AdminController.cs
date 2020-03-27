using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BugTrackerWebApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BugTrackerWebApp.Controllers
{
    public class AdminController : Controller
    {
        private readonly RoleManager<BTRole> roleManager;

        public AdminController(RoleManager<BTRole> roleManager)
        {
            this.roleManager = roleManager;
        }

    
        public IActionResult Index()
        {
            return View();
        }
    }
}