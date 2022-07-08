using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Efc
    {
         public static void Main(String[] args)
            {
                var context = new MyDbContext();
                var lst = context.tblStudent;
                context.tblStudent.Remove(lst);
                context.SaveChanges();
                Console.WriteLine("Success");
            }
    }
}
