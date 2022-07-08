// public class efc{
//     public static void Main(string [] args)
//     {
//         var context = new MyDbContext();
//         Student s1 = new Student();
//         s1.Roll = 1;
//         s1.Name = "Ramsssssrtrtrt";
//         context.tblStudent.Add(s1);
//         context.SaveChanges();
//         Console.WriteLine("Success");
//     }
// }


//fetch------------
using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;

public class efc
{
    public static void Main(String[] args)
    {
        var context = new MyDbContext();
        // var lst = context.tblStudent.ToList();
        context.tblStudent.Remove(lst);
        context.SaveChanges();
        Console.WriteLine("Success");
    }
}


// public class efc{
//     public static void Main(string [] args)
//     {
//         var context = new MyDbContext();
//         Student s1 = new Student();
//         s1.Roll = 1;
//         s1.Name = "Ramsssssrtrtrt";
//         context.tblStudent.Add(s1);
//         context.SaveChanges();
//         Console.WriteLine("Success");
//     }
// }

// public class efc{
//     public static void Main(string[] args)
//     {
//         var context = new MyDbContext();
//         var lst = context.tblStudent.where(x => x.Roll==1).firstOrDefault();
//         lst.Name = "Shyam";
//         context.SaveChange();
//         {
//             Console.WriteLine(lst.Roll + lst.Name);
//         }
        
//     }
// }
/*
public class efc
{
    public static void Main(String[] args)
    {
       using(var context  =new MyDbContext())
        {
            var lst = context.tblStudent.ToList();
            foreach (var s in lst)
            {
                Console.WriteLine(s.Roll + s.Name);
            }
        }
        

    }

}

update------------
var lst = context.tblStudent.where(x => x.Roll==1).firstorDefault();
lst.Name = "Shyam";
context.SaveChange();
{
    c.w(lst.Roll + lst.Name)
}

remove---------------
context.tblStudent.Remove(lst);
context.saveChanges();
*/
