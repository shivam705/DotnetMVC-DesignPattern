using DAL.EFModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using DAL.Data.DbContexts;

namespace AssignmenttMVC.Controllers
{
    public class LoginController : Controller
    {
        private readonly AssignmenttMVCContext _db;
        public LoginController(AssignmenttMVCContext db)
        {
            _db = db;
        }

        public IActionResult Login()
        {

            return View();
        }

        
        [HttpPost]
        [ActionName("Login")]
        public IActionResult Login(User model)
        {

            bool isUservalid = false;

            Register user = _db.Registers.Where(usr => usr.UserName == model.UserName &&
        usr.Password == model.Password).FirstOrDefault();

            if (user != null)
            {
                isUservalid = true;
            }


            if (ModelState.IsValid && isUservalid)
            {
                var claims = new List<Claim>();

                claims.Add(new Claim(ClaimTypes.Name, user.UserName));
                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var principal = new ClaimsPrincipal(identity);

                var props = new AuthenticationProperties();


                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, props).Wait();

                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewData["message"] = "Invalid UserName or Password!";
            }
            return View("Login");


        }

        public ActionResult LogOut()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return Redirect("/Home/Index");
        }
    }
}

