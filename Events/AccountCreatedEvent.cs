using IncredibleBackendContracts.Enums;

namespace IncredibleBackendContracts.Events
{
    public class AccountCreatedEvent
    {
        public int Id { get; set; }
        public TradingCurrency Currency { get; set; }
        public AccountStatus Status { get; set; }
        public int LeadId { get; set; }
    }
}