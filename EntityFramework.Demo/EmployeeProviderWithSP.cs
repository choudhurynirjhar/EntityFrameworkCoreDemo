using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EntityFramework.Demo
{
    internal class EmployeeProviderWithSP : IEmployeeProvider
    {
        private readonly EmployeeContext employeeContext;

        public EmployeeProviderWithSP(EmployeeContext employeeContext)
        {
            this.employeeContext = employeeContext;
        }

        public Employee Get(int id)
        {
            return employeeContext.Employees.FromSqlRaw("EXEC dbo.GetEmployeeById @id={0}", id)
                .ToListAsync().Result.FirstOrDefault();
        }
    }
}
