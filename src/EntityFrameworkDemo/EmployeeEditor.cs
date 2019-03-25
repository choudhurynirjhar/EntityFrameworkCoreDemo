namespace EntityFrameworkDemo
{
    internal class EmployeeEditor : IEmployeeEditor
    {
        private readonly EmployeeContext employeeContext;

        public EmployeeEditor(EmployeeContext employeeContext)
        {
            this.employeeContext = employeeContext;
        }

        public void Edit(Employee employee)
        {
            employeeContext.Update(employee);
            employeeContext.SaveChanges();
        }
    }
}
