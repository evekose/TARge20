using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Hints
    {
        [Key]
        public Guid Id { get; set; }
        public string Content { get; set; }
        public DateTime DateOfEntry { get; set; }
        public string Comment { get; set; }

        public Guid HeadOfficeId { get; set; }
        public HeadOffice HeadOffice { get; set; }
    }
}
