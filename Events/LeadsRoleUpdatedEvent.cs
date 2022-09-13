namespace IncredibleBackendContracts.Events
{
    public class LeadsRoleUpdatedEvent
    {
        public List<int> Ids { get; set; }

        public LeadsRoleUpdatedEvent(List<int> idsList) 
        {
            Ids = idsList;
        }
    }
}