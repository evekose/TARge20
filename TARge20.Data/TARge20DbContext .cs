using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TARge20.Core.Domain;

namespace TARge20.Data
{
    public class TARge20DbContext : DbContext
    {

        public TARge20DbContext(DbContextOptions<TARge20DbContext> options)
            : base(options) { }

        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Child> Children { get; set; }
        public DbSet<AccessPermission> AccessPermissions { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<HeadOffice> HeadOffice { get; set; }
        public DbSet<HealthInspection> HealthInspection { get; set; }
        public DbSet<Hints> Hints { get; set; }
        public DbSet<JobTitle> JobTitle { get; set; }
        public DbSet<ProductsForLoan> ProductsForLoan { get; set; }
        public DbSet<Requests> Requests { get; set; }
        public DbSet<SickLeave> SickLeave { get; set; }
        public DbSet<Vacations> Vacations { get; set; }

    }
}