using CoCWebForm.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoCWebForm.Controllers
{
    public class CoCFormController : Controller
    {
        public IActionResult Index(List<Sample> samples)
        {
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
    }
}
