using IncredibleBackendContracts.Enums;

namespace IncredibleBackendContracts.Responses
{
    public class TransactionResponse
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public DateTime Date { get; set; }
        public TransactionType TransactionType { get; set; }
        public decimal Amount { get; set; }
        public Currency Currency { get; set; }
    }
}
