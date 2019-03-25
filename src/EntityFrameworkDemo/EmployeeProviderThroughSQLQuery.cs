using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using System.Linq;

namespace EntityFrameworkDemo
{
    internal class EmployeeProviderThroughSQLQuery : IEmployeeProvider
    {
        private readonly EmployeeContext employeeContext;

        public EmployeeProviderThroughSQLQuery(EmployeeContext employeeContext)
        {
            this.employeeContext = employeeContext;
        }

        public Employee Get(int id)
        {
            var employees = employeeContext.Employees.FromSql("SELECT * FROM Employee WHERE ID = @ID", new SqlParameter("@ID", id));
            return employees.FirstOrDefault();
        }
    }
}
