namespace EntityFrameworkDemo
{
    internal class EmployeeRemover : IEmployeeRemover
    {
        private readonly EmployeeContext employeeContext;

        public EmployeeRemover(EmployeeContext employeeContext)
        {
            this.employeeContext = employeeContext;
        }

        public void Remove(Employee employee)
        {
            employeeContext.Remove(employee);
            employeeContext.SaveChanges();
        }
    }
}
