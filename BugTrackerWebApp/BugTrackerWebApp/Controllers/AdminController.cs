using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BugTrackerWebApp.Models;
using BugTrackerWebApp.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BugTrackerWebApp.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly RoleManager<BTRole> roleMgr;
        private readonly UserManager<BTUser> userMgr;

        public AdminController(RoleManager<BTRole> roleManager, UserManager<BTUser> userManager)
        {
            this.roleMgr = roleManager;
            this.userMgr = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult AddRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddRole(AddRoleViewModel vm)
        {
            if (ModelState.IsValid)
            {
                BTRole newRole = new BTRole
                {
                    Name = vm.Name,
                    Description = vm.Description
                };

                IdentityResult result = await roleMgr.CreateAsync(newRole);

                if (result.Succeeded)
                {
                    return RedirectToAction("ListRoles", "Admin");
                }

                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(vm);
        }

        [HttpGet]
        public IActionResult ListRoles()
        {
            IList<BTRole> roles = roleMgr.Roles.ToList();

            return View(roles);
        }
    }
}