using CoCWebForm.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoCWebForm.Controllers
{
    public class CoCFormController : Controller
    {
        private CoCDataModel dataModel = new CoCDataModel();

        [HttpPost]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddSample(Sample sample)
        {
            dataModel.Samples.Add(sample);
            return View(dataModel);
        }

        //[HttpPost]
        //public ActionResult Index(CoCDataModel dataModel)
        //{
        //    dataModel.Samples.Add(new Sample());
        //    return View(dataModel);
        //}

        public IActionResult PrintSubmit() 
        {
            // TO DO: take info from form and create PDF to print out
            return View();
        }
    }
}
