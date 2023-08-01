using CoCWebForm.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoCWebForm.Controllers
{
    public class CoCFormController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            CoCDataModel dataModel = new CoCDataModel();
            dataModel.Samples = new List<Sample>();
            dataModel.Samples.Add(new Sample { 
                SampleId = "",
                MediaType = "",
                IsoClass = "",
                SampleType = "",
                MediaLotNumber = 0,
                SampleVol = ""
            });
#if DEBUG
            return View(dataModel);
#else
            if (!string.IsNullOrEmpty((string)TempData.Peek("IsValidClient")) && (string)TempData.Peek("IsValidClient")=="true") return View(dataModel);
            return View("Error");
#endif
        }

        [HttpPost]
        public IActionResult AddSample(CoCDataModel dataModel) 
        { 
            dataModel.Samples.Add(new Sample
            {
                SampleId = "",
                MediaType = "",
                IsoClass = "",
                SampleType = "",
                MediaLotNumber = 0,
                SampleVol = ""
            });
            return View(dataModel);
        }



        public IActionResult PrintSubmit() 
        {
            // TO DO: take info from form and create PDF to print out
            return View();
        }
    }
}
