using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class HealthInspection
    {
        [Key]
        public Guid Id { get; set; }
        public int HealthInspectionNumber { get; set; }
        public DateTime NextHealthInspectionDate { get; set; }
        public string Result { get; set; }
        public string Comment { get; set; }

        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
