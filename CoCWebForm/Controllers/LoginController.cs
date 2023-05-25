using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace CoCWebForm.Controllers
{
    public class LoginController : Controller
    {
        // GET: /Login/
        public IActionResult Index()
        {
            return View();
        }

        // GET: /Login/Failure
        public IActionResult Failure(string email, int ID)
        {
            ViewData["Message"] = email;
            ViewData["ID"] = ID;
            return View();
        }
    }
}
