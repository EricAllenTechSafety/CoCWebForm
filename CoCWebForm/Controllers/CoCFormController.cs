using CoCWebForm.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoCWebForm.Controllers
{
    public class CoCFormController : Controller
    {
        private CoCDataModel dataModel = new CoCDataModel();
        
        public IActionResult Index(string id)
        {
            ViewData["WorkOrder"] = id;
            return View();
        }

        public ActionResult CreateNewSample(List<Sample> samples)
        {
            var sample = new Sample()
            {
                SampleId = Guid.NewGuid(),
            };
            samples.Add(sample);

            return View(samples);
        }
        public IActionResult PrintSubmit() 
        {
            // TO DO: take info from form and create PDF to print out
            return View();
        }
    }
}
