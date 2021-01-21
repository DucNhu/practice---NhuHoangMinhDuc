using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HummanResourcesManagement.Models
{
    public interface EmployeeRepository
    {
        IQueryable<Employee> Employees { get; }
    }
}
