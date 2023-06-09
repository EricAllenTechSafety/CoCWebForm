using CoCWebForm.Models;
using CoCWebForm.ServiceManagerEntities;
using Microsoft.AspNetCore.Mvc;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text.Encodings.Web;
using System.Timers;
using Microsoft.AspNetCore.Session;
using Timer = System.Timers.Timer;
using CoCWebForm.ServiceManagerEntities.ServiceManagerModels;

namespace CoCWebForm.Controllers
{
    
    public class LoginController : Controller
    {
        private ServiceManagerContext _dbContext = new ServiceManagerContext();
    
        // GET: /Login/
        public IActionResult Index()
        {
            return View();
        }

        // GET: /Login/Validate
        public ActionResult Validate(string CustEmail, string WorkOrderNum)
        {
            try // CO-BBC20090178D-01 : testing WorkOrder#
            {
                // Check EmailAddress for @ symbol
                if (CustEmail.Contains('@')) 
                {
                    // Check WorkOrder # against DB
                    var db_Order = (from orders in _dbContext.DAT_ORDERS
                                        where WorkOrderNum.Contains(orders.PROJECT_ID)
                                        select orders).SingleOrDefault();
                    if (!ValidateWorkOrderNumber(WorkOrderNum, db_Order)) return NotFound("We don't have a WorkOrder that matches the WorkOrder entered.");

                    // Check Email against email in DB with that WorkOrder
                    var client = (from contact in _dbContext.DAT_CONTACTS
                                  where contact.CONTACT_GUID == db_Order.FIRSTCONTACT_GUID
                                  select contact).SingleOrDefault();
                    if (!ValidateEmailAddress(CustEmail, client)) return NotFound("The email you entered doesn't match what we have in our database."); 
                }
                else { throw new Exception("Entry is not a valid email"); }
            }
            catch { }
            var _data = CreateEmailCode(CustEmail, WorkOrderNum);
            
            //emails confirmed address a code
            //SendEmail(_data.LoginModel);
            return View("~/Views/Login/Validate.cshtml");
        }

        public IActionResult ConfirmCode(string InputCode)
        {
            if (InputCode.Trim() == (string)TempData["ValidCode"]) 
                return RedirectToAction("Index", "CoCForm");
            else 
                return View("Failure");
        }

        // GET: /Login/Failure
        public IActionResult Failure(string email, int ID)
        {
            ViewData["Message"] = email;
            ViewData["ID"] = ID;
            return View();
        }

        private CoCDataModel CreateEmailCode(string email, string workOrder)
        {
            //expirationTimer.Start();
            var model = new CoCDataModel()
            {
               LoginModel = new LoginModel() {
                    EmailAddress = email,
                    WorkOrderNum = workOrder,
                    ValidationCode = Guid.NewGuid().ToString().Substring(0, 6),
                    //ExpirationTimer = expirationTimer
                },
            };
            TempData["ValidCode"] = model.LoginModel.ValidationCode;
            TempData["WorkOrderNum"] = workOrder;
            //TempData["DataModel"] = model;
            return model;
        }
        
        private void SendEmail(LoginModel loginModel) 
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var senderEmail = new MailAddress("e.s.allen@hotmail.com");
                    var recieverEmail = new MailAddress(loginModel.EmailAddress);
                    var subject = "TSS Validation code - TEST";
                    var body = $"Your validation code is: \n{loginModel.ValidationCode} \n \n This code is only valid for 15 minutes. If it expires, you will need to login again.";
                    
                    // Following is set up through personal hotmail account for test purposes
                    // NEED TO EDIT TO CORRECT TSS MAIL ACCOUNT/DETAILS
                    var client = new SmtpClient("smtp-mail.outlook.com");
                    client.Port = 587;
                    client.EnableSsl = true;
                    client.Credentials = new NetworkCredential("USERNAME", "PASSWORD");
                    
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
                ViewBag.Error = "Oops";
            }      
        }

        #region Client Validation Methods
        private bool ValidateWorkOrderNumber(string inputNum, DAT_ORDERS db_Order)
        {
            bool isValid = false;
            if (inputNum == $"{db_Order.REGION_ID}-{db_Order.PROJECT_ID}-{db_Order.ORDER_NUMBER}") isValid = true;
            return isValid;
        }
        private bool ValidateEmailAddress(string inputEmail, DAT_CONTACTS contact)
        {
            bool isValid = false;
            var inputUrl = inputEmail.Substring(inputEmail.IndexOf('@') + 1);
            var dbUrl = contact.E_MAIL.Substring(contact.E_MAIL.IndexOf("@") + 1);
            if (inputUrl == dbUrl) isValid = true;
            return true;
        }
        #endregion
    }
}
