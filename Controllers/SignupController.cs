using Microsoft.AspNetCore.Mvc;
using WebApplication3.Data;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class SignupController : Controller
    {
        private readonly ITIContext _context;

        public SignupController(ITIContext context)
        {
            _context = context;
        }

        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ADDnewuser(Signup signup)
        {
            if (signup.Name!=null)
            {
                _context.Signup.Add(signup);
                _context.SaveChanges();
                return RedirectToAction("Sucssfulsignup");
            }
            return View("Signup", signup);
        }

        public IActionResult Sucssfulsignup()
        {
            return View();
        }
    }
}
