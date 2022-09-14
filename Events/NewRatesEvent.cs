using IncredibleBackendContracts.Abstractions;

namespace IncredibleBackendContracts.Events
{
    public class NewRatesEvent : MessagingEvent
    {
        public Dictionary<string, decimal> Rates { get; set; }

        public NewRatesEvent()
        {
            Rates = new Dictionary<string, decimal>();
        }
    }
}