using CoCWebForm.Models;
using CoCWebForm.ServiceManagerEntities;
using CoCWebForm.ServiceManagerEntities.ServiceManagerModels;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Web;

namespace CoCWebForm.Controllers
{

    public class LoginController : Controller
    {
        // GET: /Login/
        // GET: /Login/Index
        // GET: /Login/Index/email/workOrder
        public IActionResult Index()
        {
            TempData.Clear();
            var request = HttpContext.Request.PathBase;
            var filter = request.Value.Length;
            
            // Pulls email and workorder from uri
            if(filter > 12) GetLoginValuesFromUri(request);
            else { ViewData["Email"] = ""; ViewData["WorkOrder"] = ""; }
            return View();
        }

        // GET: /Login/Validate
        public ActionResult Validate(string CustEmail, string WorkOrderNum)
        {
            ServiceManagerContext _dbContext = new ServiceManagerContext();
            try // CO-BBC20090178D-01 : testing WorkOrder#
            {
                _dbContext.Database.Connection.Open();

                // Check EmailAddress for @ symbol
                if (CustEmail.Contains('@')) 
                {
                    // Check WorkOrder # against DB
                    var db_Order = (from orders in _dbContext.DAT_ORDERS
                                        where WorkOrderNum.Contains(orders.PROJECT_ID)
                                        select orders).Single();
                    if (!ValidateWorkOrderNumber(WorkOrderNum, db_Order)) return View("Error");

                    // Check Email against email in DB with that WorkOrder
                    var client = (from contact in _dbContext.DAT_CONTACTS
                                  where contact.CONTACT_GUID == db_Order.FIRSTCONTACT_GUID
                                  select contact).SingleOrDefault();
                    if (!ValidateEmailAddress(CustEmail, client)) return View("Error"); 
                }
                else { return View("Error"); }
            }
            catch { }
            var _data = CreateEmailCode(CustEmail, WorkOrderNum);
            
            SendEmail(_data.LoginModel);
            return View();
        }

        public IActionResult ConfirmCode(string InputCode)
        {
            if (InputCode.Trim() == (string)TempData["SecretCode"])
            {
                TempData["IsValidClient"] = "true";
                TempData.Keep();
                return RedirectToAction("Index", "CoCForm");
            }
            else 
                return View("Error");
        }


        private CoCDataModel CreateEmailCode(string email, string workOrder)
        {
            var model = new CoCDataModel()
            {
               LoginModel = new LoginModel() {
                    EmailAddress = email,
                    WorkOrderNum = workOrder,
                    ValidationCode = Guid.NewGuid().ToString().Substring(0, 6),
                    IsValid = true
                },
            };
            TempData.Add("SecretCode", model.LoginModel.ValidationCode);
            //TempData.Add("ValidCode",model.LoginModel.ValidationCode.ToString());
            TempData["WorkOrderNum"] = workOrder;
            TempData.Keep();
            return model;
        }
        
        private void SendEmail(LoginModel loginModel) 
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var senderEmail = new MailAddress("TestFrom@TechSafety.com");
                    var recieverEmail = new MailAddress(loginModel.EmailAddress);
                    var subject = "TSS Validation code - TEST";
                    var body = $"Your validation code is:\n \n{loginModel.ValidationCode}\n \n This code is only valid for 15 minutes. If it expires, you will need to login again.";

                    // Hard coded for debugging/testing. CHANGE BEFORE DEPLOYING
                    // Following is set up through personal hotmail account for test purposes
                    // NEED TO EDIT TO CORRECT TSS MAIL ACCOUNT/DETAILS
                    var client = new SmtpClient("TSS-TX-EALLEN");
                    client.Port = 25;
                    
                    var message = new MailMessage(senderEmail, recieverEmail)
                    {
                        Subject = subject,
                        Body = body
                    };
                    client.Send(message);
                }
            }
            catch (Exception)
            {
                View("Error");
            }      
        }

        private void GetLoginValuesFromUri(PathString path)
        {
            var emailWorkOrderCombo = path.Value.Substring(path.Value.IndexOf("x") + 2);
            ViewData["Email"] = emailWorkOrderCombo.Substring(0, emailWorkOrderCombo.IndexOf("/"));
            ViewData["WorkOrder"] = emailWorkOrderCombo.Substring(emailWorkOrderCombo.IndexOf("/") + 1);
        }

#region Client Validation Methods
        private bool ValidateWorkOrderNumber(string inputNum, DAT_ORDERS db_Order)
        {
            bool isValid = false;
            if (inputNum == $"{db_Order.REGION_ID}-{db_Order.PROJECT_ID}-{db_Order.ORDER_NUMBER}") isValid = true;
#if DEBUG
            return true;
#else
            return isValid;
#endif
        }
        private bool ValidateEmailAddress(string inputEmail, DAT_CONTACTS contact)
        {
            bool isValid = false;
            var inputUrl = inputEmail.Substring(inputEmail.IndexOf('@') + 1);
            var dbUrl = contact.E_MAIL.Substring(contact.E_MAIL.IndexOf("@") + 1);
            if (inputUrl == dbUrl) isValid = true;
#if DEBUG
            return true;
#else
            return isValid;
#endif
        }
#endregion
    }
}
