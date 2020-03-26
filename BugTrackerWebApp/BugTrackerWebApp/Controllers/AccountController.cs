using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BugTrackerWebApp.Models;
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

        public async Task<IActionResult> Login()
        {
            var result = await signInMgr.PasswordSignInAsync("TestUser", "Testpass123!", false, false);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Result = "result is: " + result.ToString();
            }
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await signInMgr.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Register()
        {
            try
            {
                ViewBag.Message = "User already registered";

                BTUser user = await userMgr.FindByNameAsync("TestUser");
                if (user == null)
                {
                    user = new BTUser();
                    user.UserName = "TestUser";
                    user.Email = "TestUser@test.com";
                    user.FirstName = "Dan";
                    user.LastName = "Fries";

                    IdentityResult result = await userMgr.CreateAsync(user, "Testpass123!");
                    ViewBag.Message = "User was created";
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
            }

            return View();
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}