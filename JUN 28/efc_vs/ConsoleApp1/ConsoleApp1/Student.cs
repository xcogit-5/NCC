using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1
{
    public class Student
    {
        [Key]
        public int Roll { get; set; }
        public string? Name { get; set; }
    }
}
