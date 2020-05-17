using System;

namespace EntityFramework.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new EmployeeContext
                ("Persist Security Info = False; Integrated Security = true; Initial Catalog = TimeManagement; server = .\\SQLEXPRESS");

            var creator = new EmployeeCreator(context);
            creator.Create(new Employee { 
                FirstName = "Demo First",
                LastName = "Demo Last",
                Address="Demo Address",
                HomePhone="123-456-7890",
                CellPhone= "123-456-7890"
            });
        
        }
    }
}
