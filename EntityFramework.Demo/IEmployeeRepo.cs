namespace EntityFramework.Demo
{
    internal interface IEmployeeRepo
    {
        Employee Create(string firstName, 
            string lastName, 
            string homePhone, 
            string cellPhone);

        Employee Update(Employee employee);

        void Delete(Employee employee);
    }
}
