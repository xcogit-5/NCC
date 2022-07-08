using Microsoft.EntityFrameworkCore;
public class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions options): base(options)
    {
    
    }

    public MyDbContext(){}
    public DbSet<Student> tblStudent {get; set;}
    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        builder.UseSqlServer("Data Source = XCOGITBOOK\\MSSQLSERVER1; uid = sa; pwd = sql; Initial catalog = test");
    }
}