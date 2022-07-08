using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }

        public string? EmpName { get; set; }
    }
}
