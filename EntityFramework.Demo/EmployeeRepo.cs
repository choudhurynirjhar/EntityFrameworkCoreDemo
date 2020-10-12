namespace EntityFramework.Demo
{
    internal class EmployeeRepo : IEmployeeRepo
    {
        private readonly EmployeeContext employeeContext;

        public EmployeeRepo(EmployeeContext employeeContext)
        {
            this.employeeContext = employeeContext;
        }

        public Employee Create(string firstName, 
            string lastName, 
            string homePhone, 
            string cellPhone)
        {
            var response = employeeContext.Add(new Employee
            {
                FirstName = firstName,
                LastName = lastName,
                HomePhone = homePhone,
                CellPhone = cellPhone
            });
            employeeContext.SaveChanges();
            return response.Entity;
        }

        public void Delete(Employee employee)
        {
            employeeContext.Remove(employee);
            employeeContext.SaveChanges();
        }

        public Employee Update(Employee employee)
        {
            var response = employeeContext.Update(employee);
            employeeContext.SaveChanges();
            return response.Entity;
        }
    }
}
