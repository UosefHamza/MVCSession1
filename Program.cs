namespace MVCSession1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/Home", async context =>
                {
                    await context.Response.WriteAsync("You Are at Home Page");
                });

                endpoints.MapGet("/Products", async context =>
                {
                    await context.Response.WriteAsync("You Are at Products Page ");
                }); 

            });

            app.Run(async(HttpContext) => { await HttpContext.Response.WriteAsync("Your Requested Page Not Found"); } );

            //app.MapGet("/Home", () => "Hello world!");
            
            app.Run();
        }
    }
}
