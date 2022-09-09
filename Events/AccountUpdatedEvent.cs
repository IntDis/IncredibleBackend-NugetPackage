using IncredibleBackendContracts.Enums;

namespace IncredibleBackendContracts.Events
{
    public class AccountUpdatedEvent
    {
        public int Id { get; set; }
        public AccountStatus Status { get; set; }
    }
}
