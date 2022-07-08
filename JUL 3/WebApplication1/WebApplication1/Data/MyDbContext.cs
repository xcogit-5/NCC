using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions options):base(options)
        {

        }

        public MyDbContext()
        {

        }

        public DbSet<Student> tblStudent { get; set; }
        public DbSet<Employee> MyProperty { get; set; }



        protected override void OnModelCreating(ModelBuilder mbuilder)
        {
           
        }
    }
}
