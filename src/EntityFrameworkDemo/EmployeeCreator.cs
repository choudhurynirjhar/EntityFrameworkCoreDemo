namespace EntityFrameworkDemo
{
    internal class EmployeeCreator : IEmployeeCreator
    {
        private readonly EmployeeContext employeeContext;

        public EmployeeCreator(EmployeeContext employeeContext)
        {
            this.employeeContext = employeeContext;
        }

        public Employee Create(string firstName, string lastName, string address, string homePhone, string cellPhone)
        {
            var employee = employeeContext.Add(new Employee { FirstName = firstName, LastName = lastName, Address = address, HomePhone = homePhone, CellPhone = cellPhone });
            employeeContext.SaveChanges();
            return employee.Entity;
        }
    }
}
