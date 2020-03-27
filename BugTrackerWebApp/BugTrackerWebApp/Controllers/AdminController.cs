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

        [HttpGet]
        public async Task<IActionResult> EditRole(string id)
        {
            BTRole role = await roleMgr.FindByIdAsync(id);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id = {id} does not exists please try again";
                return RedirectToAction("ListRoles", "Admin");
            }

            EditRoleViewModel vm = new EditRoleViewModel
            {
                Id = role.Id,
                Name = role.Name,
                Description = role.Description,

            };

            foreach (BTUser user in userMgr.Users.ToList())
            {
                if (await userMgr.IsInRoleAsync(user, role.Name))
                {
                    vm.Users.Add(user.UserName);
                }
            }

            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> EditRole(EditRoleViewModel vm)
        {
            BTRole role = await roleMgr.FindByIdAsync(vm.Id.ToString());

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id = {vm.Id} does not exists please try again";
                return RedirectToAction("ListRoles", "Admin");
            }
            else
            {
                role.Name = vm.Name;
                IdentityResult result = await roleMgr.UpdateAsync(role);

                if (result.Succeeded)
                {
                    return RedirectToAction("ListRoles", "Admin");
                }

                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View(vm);
            }    
        }
    }
}