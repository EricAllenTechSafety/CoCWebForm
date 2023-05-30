using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Text.Encodings.Web;

namespace CoCWebForm.Controllers
{
    public class LoginController : Controller
    {
        // GET: /Login/
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Validate(string CustEmail, string WorkOrderNum)
        {
            var emailpair = CreateEmailCode(CustEmail);
            SendEmail(emailpair);
            return View();
        }

        // GET: /Login/Failure
        public IActionResult Failure(string email, int ID)
        {
            ViewData["Message"] = email;
            ViewData["ID"] = ID;
            return View();
        }

        private Tuple<string, Guid> CreateEmailCode(string email)
        {
            var validationCode = new Guid();
            return new Tuple<string, Guid>(email, validationCode);
        }
        
        private void SendEmail(Tuple<string, Guid> emailPair) 
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var senderEmail = new MailAddress("eric.allen@techsafety.com");
                    var recieverEmail = new MailAddress(emailPair.Item1);
                    var subject = "TSS Validation code";
                    var body = $"Your validation code is: \n{emailPair.Item2} \n \n Please enter it in within the next 15 minutes, before it expires.";
                    var smtp = new SmtpClient
                    {
                        Host = "smtp.techsafety.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                    };
                    using(var mess = new MailMessage(senderEmail, recieverEmail)
                    {
                        Subject = subject,
                        Body = body
                    })
                    {
                        smtp.Send(mess);
                    }
                }
            }
            catch (Exception)
            {
                ViewBag.Error = "Oops";
            }      
        }
    }
}
