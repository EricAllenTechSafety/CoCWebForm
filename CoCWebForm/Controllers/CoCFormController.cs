using CoCWebForm.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoCWebForm.Controllers
{
    public class CoCFormController : Controller
    {
        private CoCDataModel dataModel = new CoCDataModel();
        
        public IActionResult Index()
        {
            //ViewData["WorkOrder"] = id;
            dataModel.Samples = new List<Sample>();
            dataModel.Samples.Add(new Sample() { 
                SampleId = "", 
                MediaType = "",
                IsoClass = "",
                MediaLotNumber = 0,
                SampleVol = ""
            }); 
            return View(dataModel);
        }
        [HttpPost]
        public ActionResult Index(CoCDataModel dataModel)
        {
            dataModel.Samples.Add(new Sample());
            return View(dataModel);
        }

        public IActionResult PrintSubmit() 
        {
            // TO DO: take info from form and create PDF to print out
            return View();
        }
    }
}
