using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Demo
{
    internal class EmployeeCreator
    {
        private readonly EmployeeContext employeeContext;

        public EmployeeCreator(EmployeeContext employeeContext)
        {
            this.employeeContext = employeeContext;
        }

        public void Create(Employee employee)
        {
            var query = "INSERT Employee (first_name, last_name, address, home_phone, cell_phone)" +
                " VALUES (@first_name, @last_name, @address, @home_phone, @cell_phone)";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@first_name", employee.FirstName),
            new SqlParameter("@last_name", employee.LastName),
            new SqlParameter("@home_phone", employee.HomePhone),
            new SqlParameter("@cell_phone", employee.CellPhone)
            };

            employeeContext.Database.ExecuteSqlRaw(query, parameters);
        }
    }
}
