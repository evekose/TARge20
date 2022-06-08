using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class HeadOffice
    {
        [Key]
        public Guid Id { get; set; }
        public int RegistryNumber { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactPerson { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }

        public List<Department> Departments { get; set; }
        public List<AccessPermission> AccessPermissions { get; set; }
        public List<Hints> Hints { get; set; }
        public List<Requests> Requests { get; set; }
    }
}
