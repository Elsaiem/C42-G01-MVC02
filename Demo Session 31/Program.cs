using Microsoft.AspNetCore.Mvc;

namespace Demo_Session_31
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //add to any service you need before build
            //builder.Services.AddControllers();//register the built -in APIS service in the container
            builder.Services.AddControllersWithViews();//register the built -in MVC service in the container
            //builder .Services.AddRazorPages();//register the built -in Razor  service in the container
            //builder.Services.AddMvc();//register the built -in All web service in the container
            var app = builder.Build();
            app.UseStaticFiles();//middleware for static file
            app.MapGet("/", () => "Hello World!");
            //app.MapGet("hamada", () => "hello hamade");
            //app.MapGet("/signin", signin);


            app.UseRouting();


            app.MapControllerRoute(
                name: "Default",
                pattern: "/{controller}/{action}/{id:int?}"
            );

           


            app.Run();
        
        
        
        
        }
        static string signin()
        {
            return "signin";
        }
    }
}
