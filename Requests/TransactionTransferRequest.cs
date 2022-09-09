using IncredibleBackendContracts.Enums;

namespace IncredibleBackendContracts.Requests
{
    public class TransactionTransferRequest : TransactionRequest
    {
        public long RecipientAccountId { get; set; }
        public Currency RecipientCurrency { get; set; }
    }
}
