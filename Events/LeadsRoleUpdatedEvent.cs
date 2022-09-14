using IncredibleBackendContracts.Abstractions;

namespace IncredibleBackendContracts.Events
{
    public class LeadsRoleUpdatedEvent : MessagingEvent
    {
        public List<int> Ids { get; set; }

        public LeadsRoleUpdatedEvent(List<int> idsList) 
        {
            Ids = idsList;
        }
    }
}