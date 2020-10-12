using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Demo
{
    internal class EmployeeProviderWithInlineQuery : IEmployeeProvider
    {
        private readonly EmployeeContext employeeContext;

        public EmployeeProviderWithInlineQuery(EmployeeContext employeeContext)   
        {
            this.employeeContext = employeeContext;
        }

        public Employee Get(int id)
        {
            return employeeContext.Employees.FromSqlRaw
                ("SELECT id, first_name,last_name,home_phone,cell_phone FROM Employee WHERE id=({0})", id)
                .FirstOrDefaultAsync().Result;
        }
    }
}
