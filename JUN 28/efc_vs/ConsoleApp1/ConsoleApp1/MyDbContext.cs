using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace ConsoleApp1
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {

        }

        public MyDbContext() { }

        public DbSet<Student> tblStudent { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Data Source = XCOGITBOOK\\MSSQLSERVER1; uid = sa; pwd = sql; Initial catalog = test");
        }
    }
}
