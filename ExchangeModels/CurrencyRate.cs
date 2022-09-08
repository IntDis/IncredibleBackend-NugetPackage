namespace IncredibleBackendContracts.ExchangeModels
{
    public class CurrencyRate
    {
        public Dictionary<string, decimal> Rates { get; set; }

        public CurrencyRate()
        {
            Rates = new Dictionary<string, decimal>();
        }
    }
}