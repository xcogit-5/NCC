using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class MyDbContext:IdentityDbContext
    {
        public MyDbContext(DbContextOptions options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }


        public DbSet<Student> tblStudent { get; set; }

        public DbSet<Employee> tblEmployee { get; set; }
    }

   

   
}
