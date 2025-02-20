﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BugTrackerWebApp.Models;
using BugTrackerWebApp.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BugTrackerWebApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly RoleManager<BTRole> roleMgr;

        private readonly UserManager<BTUser> userMgr;

        private readonly SignInManager<BTUser> signInMgr;

        public AccountController(UserManager<BTUser> userManager, SignInManager<BTUser> signInManager, RoleManager<BTRole> roleManager)
        {
            userMgr = userManager;
            signInMgr = signInManager;
            this.roleMgr = roleManager;
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            // Sign the user out and redirect to the Index page
            await signInMgr.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        // Remote validation for Email in registration form, will live update the error message if a user tries to register an email that already exists
        [AcceptVerbs("Get", "Post")]
        public async Task<IActionResult> IsEmailInUse(string email)
        {
            var user = await userMgr.FindByEmailAsync(email);

            if (user == null)
            {
                return Json(true);
            }
            else
            {
                return Json($"Email {email} is already in use");
            }
        }


        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel vm)
        {
            if (ModelState.IsValid)
            {
                // Create a new user object with data from the View Model
                BTUser user = new BTUser
                {
                    UserName = vm.Email,
                    Email = vm.Email
                };

                // Create a new user using the user manager service
                IdentityResult result = await userMgr.CreateAsync(user, vm.Password);

                // On a succesful registration add the user to the default user role and then log the user in
                if (result.Succeeded)
                {
                    user = await userMgr.FindByNameAsync(user.UserName);
                    BTRole role = await roleMgr.FindByNameAsync("User");
                    await userMgr.AddToRoleAsync(user, role.Name);
                    await signInMgr.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("index", "home");
                }

                // On an unsuccesful registration add errors to ModelState for display in validation error summary on the view
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(vm);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel vm, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                // Attempt to sign in the user using the sign in manager
                var result = await signInMgr.PasswordSignInAsync(vm.Email, vm.Password, vm.RememberMe, false);

                // If the login was succesful redirect the user to the appropriate page
                if (result.Succeeded)
                {
                    // If a redirect URL exists redirect the user to that page otherwise redirect to home index
                    if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                    {
                        return LocalRedirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("index", "home");
                    }
                }

                // On an unsuccesful login add an error message to ModelState
                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            }

            return View(vm);
        }
    }
}