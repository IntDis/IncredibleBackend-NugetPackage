using IncredibleBackendContracts.Abstractions;

namespace IncredibleBackendContracts.Events
{
    public class LeadDeletedEvent : MessagingEvent
    {
        public int Id { get; set; }
    }
}
