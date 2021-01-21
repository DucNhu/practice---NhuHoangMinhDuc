using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HummanResourcesManagement.Models
{
    public class EFEmployeeRespository : EmployeeRepository 
    {
        private EmployeeDbcontext context;

        public EFEmployeeRespository(EmployeeDbcontext ctx)
        {
            context = ctx;
        }public IQueryable<Employee> Employees => context.Employees;
    }
}
