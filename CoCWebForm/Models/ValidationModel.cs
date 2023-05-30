namespace CoCWebForm.Models
{
    public class ValidationModel
    {
        public string ValidationCode { get; set; } 
        public string WorkOrderNum { get; set; }
        public Timer ExpirationTimer { get; set; }
    }
}
