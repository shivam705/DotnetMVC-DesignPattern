
using DAL.Data.DbContexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace AssignmenttMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly AssignmenttMVCContext _db;
        public HomeController(AssignmenttMVCContext db)
        {
            _db = db;
        }
        

        public IActionResult Index()
        {
            return View();
        }
    }
}
