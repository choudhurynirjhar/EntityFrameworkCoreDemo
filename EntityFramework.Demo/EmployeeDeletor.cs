using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Demo
{
    internal class EmployeeDeletor
    {
        private readonly EmployeeContext employeeContext;

        public EmployeeDeletor(EmployeeContext employeeContext)
        {
            this.employeeContext = employeeContext;
        }

        public void Delete(int id)
        {
            var query = $"DELETE FROM Employee WHERE id=(@id)";
            var param = new SqlParameter("@id", id);

            employeeContext.Database.ExecuteSqlRaw(query, param);
        }
    }
}
