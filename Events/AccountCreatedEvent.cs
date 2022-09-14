using IncredibleBackendContracts.Abstractions;
using IncredibleBackendContracts.Enums;

namespace IncredibleBackendContracts.Events
{
    public class AccountCreatedEvent : MessagingEvent
    {
        public int Id { get; set; }
        public TradingCurrency Currency { get; set; }
        public AccountStatus Status { get; set; }
        public int LeadId { get; set; }
    }
}