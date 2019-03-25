using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkDemo
{
    internal class EmployeeContext : DbContext
    {
        public EmployeeContext(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public DbSet<Employee> Employees { get; set; }
        public string ConnectionString { get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
