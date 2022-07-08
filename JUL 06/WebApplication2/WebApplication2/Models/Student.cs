using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Student
    {
        [Key]
        public int Roll { get; set; }

        public string? Name { get; set; }
    }
}
