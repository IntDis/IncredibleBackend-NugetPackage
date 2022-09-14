using IncredibleBackendContracts.Abstractions;
using IncredibleBackendContracts.Enums;

namespace IncredibleBackendContracts.Events
{
    public class TransactionCreatedEvent : MessagingEvent
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public DateTime Date { get; set; }
        public TransactionType TransactionType { get; set; }
        public decimal Amount { get; set; }
        public Currency Currency { get; set; }
        public decimal Rate { get; set; }
    }
}
