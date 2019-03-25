namespace EntityFrameworkDemo
{
    internal interface IEmployeeCreator
    {
        Employee Create(string firstName, string lastName, string address, string homePhone, string cellPhone);
    }
}
