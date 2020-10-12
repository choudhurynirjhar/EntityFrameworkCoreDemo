namespace EntityFramework.Demo
{
    static class Program
    {
        static void Main(string[] args)
        {
            var context = new EmployeeContext
                ("Persist Security Info = False; Integrated Security = true; Initial Catalog = TimeManagement; server = .\\SQLEXPRESS");

            var updater = new EmployeeUpdator(context);
            updater.Update(1, "Name'; truncate table Employee; --");
        }
    }
}
