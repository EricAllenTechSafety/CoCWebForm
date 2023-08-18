using CoCWebForm.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace CoCWebForm.Controllers
{
    public class CoCFormController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            CoCDataModel dataModel = new CoCDataModel();
            dataModel.Samples = new List<SampleData>();
            dataModel.Samples.Add(new SampleData { 
                SampleId = "",
                MediaType = "",
                IsoClass = "",
                SampleType = "",
                MediaLotNumber = 0,
                SampleVol = ""
            });
            TestCodeBank tcBank = new TestCodeBank();
            tcBank.CATEGORY.Sort();
            tcBank.TEST_CODE.Sort();
            tcBank.DESCRIPTION.Sort();
            ViewData["testCodes"] = tcBank;
#if DEBUG
            return View(dataModel);
#else
            if (!string.IsNullOrEmpty((string)TempData.Peek("IsValidClient")) && (string)TempData.Peek("IsValidClient")=="true") return View(dataModel);
            return View("Error");
#endif
        }

        public IActionResult SubmitPrint(IFormCollection collection) 
        {
            var outputModel = MapCollectionData(collection);
            // TO DO: take info from form and create PDF to print out
            
            return View();
        } 
        
        private CoCDataModel MapCollectionData(IFormCollection collection)
        {
            var outputModel = new CoCDataModel();
            //Mapping 
            outputModel.ServiceOrder = collection["ServiceOrder"];
            outputModel.TestCode = new TestCode {
                Category = collection["TestCodes-Categories"],
                Test_Code = collection["TestCodes-Codes"],
                Description = collection["TestCodes-Desc"]
            };
            outputModel.SpecialInstructions = collection["SpecialInstructions"];

            return outputModel;
        }
    }

}
