namespace CoCWebForm.Models
{
    public class Client
    {
        public Guid ClientGuid { get; set; }
        public string? ClientName { get; set; }
        public string ClientEmail { get; set; }
        public string? ClientPassword { get; set; }
        public string? WorkOrderId { get; set;}
    }
}
