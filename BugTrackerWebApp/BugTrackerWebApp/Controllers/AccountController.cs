using System;
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
        private UserManager<BTUser> userMgr { get; }

        private SignInManager<BTUser> signInMgr { get; }

        public AccountController(UserManager<BTUser> userManager, SignInManager<BTUser> signInManager)
        {
            userMgr = userManager;
            signInMgr = signInManager;
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInMgr.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
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

                // On a succesful registration log the user in
                if (result.Succeeded)
                {
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
        public async Task<IActionResult> Login(LoginViewModel vm)
        {
            if (ModelState.IsValid)
            {
                // Attempt to sign in the user using the sign in manager
                var result = await signInMgr.PasswordSignInAsync(vm.Email, vm.Password, vm.RememberMe, false);

                // On a succesful registration log the user in
                if (result.Succeeded)
                {
                    return RedirectToAction("index", "home");
                }

                // On an unsuccesful login add an error message to ModelState
                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            }

            return View(vm);
        }
    }
}