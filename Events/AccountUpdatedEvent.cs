using IncredibleBackendContracts.Abstractions;
using IncredibleBackendContracts.Enums;

namespace IncredibleBackendContracts.Events
{
    public class AccountUpdatedEvent : MessagingEvent
    {
        public int Id { get; set; }
        public AccountStatus Status { get; set; }
    }
}
