using IncredibleBackendContracts.Abstractions;

namespace IncredibleBackendContracts.Events
{
    public class EmailEvent : MessagingEvent
    {
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
