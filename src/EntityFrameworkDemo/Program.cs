using System;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new EmployeeContext(@"Persist Security Info = False; Integrated Security = true; Initial Catalog = TimeManagement; server = Nirjhar-Tab\SQLEXPRESS");
            CreateMultipleEmployee(context);
        }

        static void CreateMultipleEmployee(EmployeeContext context)
        {
            var creator = new MultipleEmployeeCreator(context);
            creator.Create(new Employee[] {
                new Employee{ FirstName= "Samwise", LastName = "Gamgee", Address= "Shire", HomePhone= "123-123-1234", CellPhone= "123-123-1234" },
                new Employee{ FirstName= "Frodo", LastName = "Baggins", Address= "Shire", HomePhone= "123-123-1234", CellPhone= "123-123-1234" }
            });
            Console.ReadLine();
        }

        static void ProvideEmployeeWithSP(EmployeeContext context, int id)
        {
            var provider = new EmployeeProviderThroughSP(context);
            var employee = provider.Get(id);
            Console.WriteLine($"{employee.FirstName} {employee.LastName} {employee.Address}");
            Console.ReadLine();
        }

        static void ProvideEmployeeWithSql(EmployeeContext context, int id)
        {
            var provider = new EmployeeProviderThroughSQLQuery(context);
            var employee = provider.Get(id);
            Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            Console.ReadLine();
        }

        static void ProvideEmployee(EmployeeContext context)
        {
            var provider = new EmployeeProvider(context);
            Console.WriteLine(provider.Get(2).FirstName);
            Console.ReadLine();
        }

        static void CreateEmployee(EmployeeContext context)
        {
            var creator = new EmployeeCreator(context);
            var employee = creator.Create("Samwise", "Gamgee", "Shire", "123-123-1234", "123-123-1234");
            Console.WriteLine($"Name: {employee.FirstName} {employee.LastName}, Addredd: {employee.Address}");
            Console.ReadLine();
        }

        static void UpdateEmployee(EmployeeContext context, int id)
        {
            var provider = new EmployeeProvider(context);
            var employee = provider.Get(id);
            var editor = new EmployeeEditor(context);
            employee.Address = "Gondor";
            editor.Edit(employee);
            Console.ReadLine();
        }

        static void DeleteEmployee(EmployeeContext context, int id)
        {
            var provider = new EmployeeProvider(context);
            var employee = provider.Get(id);
            var remover = new EmployeeRemover(context);
            remover.Remove(employee);
        }
    }
}
