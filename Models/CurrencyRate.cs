namespace IncredibleBackendContracts.Models
{
    public class CurrencyRate
    {
        public Dictionary<string, decimal> Rates;

        public CurrencyRate()
        {
            Rates = new Dictionary<string, decimal>();
        }
    }
}