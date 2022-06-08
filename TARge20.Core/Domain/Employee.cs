using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace TARge20.Core.Domain
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public string PersonalIdCode { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime WorkingSince { get; set; }
        public DateTime WorkingUntil { get; set; }
        public string Comment { get; set; }


        public List<Child> Child { get; set; }
        public List<ProductsForLoan> ProductsForLoan { get; set; }
        public List<SickLeave> SickLeave { get; set; }
        public List<HealthInspection> HealthInspection { get; set; }
        public List<Vacations> Vacations { get; set; }
        public List<AccessPermission> AccessPermission { get; set; }
        public List<Requests> Requests { get; set; }
    }
}
