using CoCWebForm.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoCWebForm.Controllers
{
    public class CoCFormController : Controller
    {
        private CoCDataModel dataModel = new CoCDataModel();

        public IActionResult Index()
        {
            if (!string.IsNullOrEmpty((string)TempData["IsValidClient"]) && (string)TempData["IsValidClient"]=="true") return View();
            return View("Error");
        }

        public IActionResult AddSample(Sample sample)
        {
            // TO DO: take info from form and create PDF to print out
            return View(dataModel);
        }

        public IActionResult PrintSubmit() 
        {
            // TO DO: take info from form and create PDF to print out
            return View();
        }
    }
}
