namespace EntityFramework.Demo
{
    internal interface IEmployeeProvider
    {
        Employee Get(int id);
    }
}