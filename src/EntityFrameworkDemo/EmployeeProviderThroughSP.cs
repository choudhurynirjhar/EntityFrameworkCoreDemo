using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EntityFrameworkDemo
{
    internal class EmployeeProviderThroughSP : IEmployeeProvider
    {
        private readonly EmployeeContext employeeContext;

        public EmployeeProviderThroughSP(EmployeeContext employeeContext)
        {
            this.employeeContext = employeeContext;
        }

        public Employee Get(int id)
        {
            var employees = employeeContext.Employees.FromSql($"Execute dbo.GetEmployeeById {id}");
            return employees.FirstOrDefault();
        }
    }
}
