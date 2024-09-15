using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MVCSession1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();

            var app = builder.Build();

            app.UseRouting();
            #region my
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/Home", async context =>
            //    {
            //        await context.Response.WriteAsync("You Are at Home Page");
            //    });


            //    endpoints.MapGet("/Products/{ID:int?}", async context =>
            //    {
            //        var idData = context.Request.RouteValues["ID"];
            //        if (idData is not null)
            //        {
            //            int data = Convert.ToInt32(idData);
            //            await context.Response.WriteAsync($"You Are at Products Page id => {data} ");
            //        }
            //        else
            //        {
            //            await context.Response.WriteAsync($"You Are at Products Page");
            //        }
            //    });

            //    endpoints.MapGet("/Books/{ID}/{Auther:alpha:minlength(5):maxlength(10)}", async context =>
            //    {
            //        int id = Convert.ToInt32(context.Request.RouteValues["ID"]);
            //        string name = context.Request.RouteValues["Auther"].ToString() ;
            //        await context.Response.WriteAsync($"You Are at Books Page id => {id} , At Author => {name} ");
            //    });
            //});
            #endregion

            app.MapControllerRoute(
                name:"default",
                pattern:"/{Controller = Home}/{Action = Index}",
                defaults : new { Controller = "Home" , Action = "Index" }
                );

            app.MapControllerRoute(
               name: "default",
               pattern: "/{Controller = Home}/{Action = AboutUs}",
               defaults: new { Controller = "Home", Action = "AboutUs" }
               );

            //app.Run(async(HttpContext) => { await HttpContext.Response.WriteAsync("Your Requested Page Not Found"); } );

            //app.MapGet("/Home", () => "Hello world!");

            app.Run();
        }
    }
}
