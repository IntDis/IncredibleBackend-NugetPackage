﻿using IncredibleBackendContracts.Abstractions;
using IncredibleBackendContracts.Enums;

namespace IncredibleBackendContracts.Events
{
    public class LeadCreatedEvent : MessagingEvent
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Passport { get; set; }
        public City City { get; set; }
        public string Address { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}