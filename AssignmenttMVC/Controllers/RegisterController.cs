
using Microsoft.AspNetCore.Mvc;
using DAL.EFModels;
using DAL.Data.DbContexts;

namespace AssignmenttMVC.Controllers
{
    public class RegisterController : Controller
    {
        private readonly AssignmenttMVCContext _db;
        public RegisterController(AssignmenttMVCContext db)
        {
            _db = db;
        }


        public ActionResult Register()
        {

            return View();
        }


        [HttpPost]
        
        [ActionName("Register")]
        public ActionResult Register(Register Res)
        {

            if (ModelState.IsValid)
            {
                _db.Registers.Add(Res);
                _db.SaveChanges();
                return RedirectToAction("Login", "Login");
            }
            return View("Register");
        }
    }
}
