using IncredibleBackendContracts.Enums;

namespace IncredibleBackendContracts.Responses
{
    public class TransferTransactionCreatedEvent : TransactionCreatedEvent
    {
        public int RecipientId { get; set; }
        public int RecipientAccountId { get; set; }
        public decimal RecipientAmount { get; set; }
        public Currency RecipientCurrency { get; set; }
    }
}