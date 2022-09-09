namespace IncredibleBackendContracts.Events
{
    public class NewRatesEvent
    {
        public Dictionary<string, decimal> Rates { get; set; }

        public NewRatesEvent()
        {
            Rates = new Dictionary<string, decimal>();
        }
    }
}