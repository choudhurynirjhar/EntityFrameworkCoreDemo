using System;

namespace EntityFrameworkDemo
{
    internal class MultipleEmployeeCreator
    {
        private readonly EmployeeContext employeeContext;

        public MultipleEmployeeCreator(EmployeeContext employeeContext)
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
                        employeeContext.Add(employee);
                        employeeContext.SaveChanges();
                    }
                    transaction.Commit();
                }
                catch(Exception exc)
                {
                    transaction.Rollback();
                    Console.WriteLine(exc);
                    // Log etc.
                }
            }
        }
    }
}
