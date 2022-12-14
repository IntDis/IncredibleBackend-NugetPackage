using IncredibleBackendContracts.Enums;

namespace IncredibleBackendContracts.Responses
{
    public class TransferResponse : TransactionResponse
    {
        public long RecipientId { get; set; }
        public long RecipientAccountId { get; set; }
        public decimal RecipientAmount { get; set; }
        public Currency RecipientCurrency { get; set; }
    }
}
