using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class AccessPermission
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidUntil { get; set; }
        public string Comment { get; set; }

        public Guid HeadOfficeId { get; set; }
        public HeadOffice HeadOffice { get; set; }

        public Guid DepartmentId { get; set; }
        public Department Department { get; set; }

        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
