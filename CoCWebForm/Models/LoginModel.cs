using Timer = System.Timers.Timer;

namespace CoCWebForm.Models
{
    public class LoginModel
    {
        public string EmailAddress { get; set; }
        public string WorkOrderNum { get; set; }
        public string ValidationCode { get; set; }
        public bool IsValid { get; set; }
        public Timer ExpirationTimer { get; set; }
    }
}
