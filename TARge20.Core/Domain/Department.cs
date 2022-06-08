using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Department
    {
        [Key]
        public Guid Id { get; set; }
        public int DepartmentNumber { get; set; }
        public string DepartmentName { get; set; }
        public string Location { get; set; }
        public string PersonInCharge { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int NumberOfEmployees { get; set; }
        public string Comment { get; set; }

        public List<Employee> Employees { get; set; }
        public List<JobTitle> JobTitles { get; set; }
        public List<AccessPermission> AccessPermissions { get; set; }
        public List<ProductsForLoan> ProductsForLoan { get; set; }
    }
}
