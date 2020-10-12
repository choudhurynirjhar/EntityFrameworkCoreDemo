using System;

namespace EntityFramework.Demo
{
    internal class EmployeeTransactionalCreator
    {
        private readonly EmployeeContext employeeContext;

        public EmployeeTransactionalCreator(EmployeeContext employeeContext)
        {
            this.employeeContext = employeeContext;
        }

        public void Create(Employee[] employees)
        {
            using (var transaction = employeeContext.Database.BeginTransaction())
            {
                try
                {
                    foreach (var employee in employees)
                    {
                        employeeContext.Employees.Add(employee);
                        employeeContext.SaveChanges();
                    }
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    // Log etc
                }
            }
        }
    }
}
