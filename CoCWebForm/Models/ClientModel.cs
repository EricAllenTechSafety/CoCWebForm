namespace CoCWebForm.Models
{
    public class ClientModel
    {
        public string Id { get; set; }
        public Guid SessionId { get; set; }
        public string Email { get; set; }
        public string WorkOrderNum { get; set; }
    }
}
