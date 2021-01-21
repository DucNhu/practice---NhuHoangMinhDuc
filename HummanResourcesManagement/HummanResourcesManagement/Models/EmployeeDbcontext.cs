using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HummanResourcesManagement.Models
{
    public class EmployeeDbcontext : DbContext
    {
        public EmployeeDbcontext(DbContextOptions<EmployeeDbcontext> opts) : base(opts) { } 
        public DbSet<Employee> Employees { get; set; }
    }
}
