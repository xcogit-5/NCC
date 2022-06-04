namespace MVC_from_scratch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            app.MapControllerRoute(name: "defafult", pattern: "{controller=student}/{action=show}/{id?}");

            app.Run();
        }
    }
}