using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework.Demo
{
    [Table("Employee")]
    internal class Employee
    {
        public int Id { get; set; }
        [Column("first_name")]
        public string FirstName { get; set; }
        [Column("last_name")]
        public string LastName { get; set; }
        [Column("home_phone")]
        public string HomePhone { get; set; }
        [Column("cell_phone")]
        public string CellPhone { get; set; }
    }
}
