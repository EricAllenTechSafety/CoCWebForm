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

namespace CoCWebForm.Controllers
{
    
    public class LoginController : Controller
    {
        private ServiceManagerContext _dbContext = new ServiceManagerContext();
        private Timer expirationTimer = new Timer() { Interval = 900000 }; // Timer set to 15min
        private LoginModel loginModel = new LoginModel();
                
        // GET: /Login/
        public IActionResult Index()
        {
            return View();
        }

        // GET: /Login/Validate
        public ActionResult Validate(string CustEmail, string WorkOrderNum)
        {
            try
            {
                // Check WorkOrder # against DB
                //var db_workOrder = (from orders in _dbContext.DAT_ORDERS
                //                    where orders.ID.ToString() == WorkOrderNum
                //                    select orders).SingleOrDefault();
                //if (db_workOrder == null) throw new Exception("Invalid Work Order Entered.");
                
                // Check EmailAddress
                if (CustEmail.Contains('@')) 
                {
                    var index = CustEmail.IndexOf('@');
                    var url = CustEmail.Substring(index+1);
                }
                else { throw new Exception("Email provided is invalid"); }
            }
            catch { }
            loginModel = CreateEmailCode(CustEmail, WorkOrderNum);
            //SendEmail(loginModel);
            return View("~/Views/Login/Validate.cshtml");
        }

        public IActionResult ConfirmCode(string ValidationCode)
        {
            if (ValidationCode == loginModel.ValidationCode) return View("~/Views/CoCForm/Index.cshtml");
            else return View("Failure");
        }

        // GET: /Login/Failure
        public IActionResult Failure(string email, int ID)
        {
            ViewData["Message"] = email;
            ViewData["ID"] = ID;
            return View();
        }

        private LoginModel CreateEmailCode(string email, string workOrder)
        {
            expirationTimer.Start();
            var model = new LoginModel()
            {
                EmailAddress = email,
                WorkOrderNum = workOrder,
                ValidationCode = Guid.NewGuid().ToString().Substring(0, 6),
                ExpirationTimer = expirationTimer
        };
            return model;
        }
        
        private void SendEmail(LoginModel loginModel) 
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var senderEmail = new MailAddress("eric.allen@techsafety.com");
                    var recieverEmail = new MailAddress(loginModel.EmailAddress);
                    var subject = "TSS Validation code";
                    var body = $"Your validation code is: \n{loginModel.ValidationCode} \n \n Please enter it in within the next 15 minutes, before it expires.";
                    var client = new SmtpClient("tss-mx.corp.techsafety.com");
                    client.Credentials = new NetworkCredential("eric.allen", "F19!7KG0Lupv");
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
    }
}
