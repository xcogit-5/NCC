using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Student
    {
        [Key]
        public int Roll { get; set; }

        public string Name { get; set; }
    }
}
