using IncredibleBackendContracts.Abstractions;

namespace IncredibleBackendContracts.Events
{
    public class AccountDeletedEvent : MessagingEvent
    {
        public int Id { get; set; }
    }
}
