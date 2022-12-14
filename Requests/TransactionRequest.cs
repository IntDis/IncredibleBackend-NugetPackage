using IncredibleBackendContracts.Enums;

namespace IncredibleBackendContracts.Requests
{
    public class TransactionRequest
    {
        public long AccountId { get; set; }
        public Currency Currency { get; set; }
        public decimal Amount { get; set; }
    }
}
