using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class SickLeave
    {
        [Key]
        public Guid Id { get; set; }
        public int SickLeaveNumber { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Comment { get; set; }

        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
