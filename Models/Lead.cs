﻿using IncredibleBackendContracts.Enums;

namespace IncredibleBackendContracts.Models
{
    public class Lead
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
        public Role Role { get; set; }
        public string Password { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool IsDeleted { get; set; }
        public List<Account> Accounts { get; set; }
    }
}
