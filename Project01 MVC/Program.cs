namespace Project01_MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            var app = builder.Build();
            app.UseRouting();
            #region Routing
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/Home", async context =>
            //    {
            //        await context.Response.WriteAsync("You are At Home Page");
            //    });
            //    // endpoints.MapGet("/Products", async context =>
            //    //{
            //    //    await context.Response.WriteAsync("You are At Products Page");

            //    //});
            //    endpoints.MapGet("/Products/{id:int?}", async context =>
            //    {
            //        var Id = context.Request.RouteValues["id"];
            //        if (Id is not null)
            //        {
            //            // int data = Convert.ToInt32(Id);

            //            await context.Response.WriteAsync($"You are At Products Page At Id => {Id}");
            //        }
            //        else
            //        {
            //            await context.Response.WriteAsync("You are At Products Page");
            //        }

            //    });
            //    endpoints.MapGet("/Books/{id}/{Auther:alpha:minlength(5):maxlength(20)}", async context =>
            //    {
            //        int Id = Convert.ToInt32(context.Request.RouteValues["id"]);
            //        string AutherName = context.Request.RouteValues["Auther"].ToString();
            //        await context.Response.WriteAsync($"You are At Books Page Id => {Id} , At Auther => {AutherName}");
            //    });

            //});
            #endregion

            app.MapControllerRoute(
                name: "defult",
                pattern: "/{Controller = Home}/{Action = Index}",
               defaults: new { Controller = "Home", Action = "Index" });
         //   app.Run(async (HttpContext) => { await HttpContext.Response.WriteAsync("Your Requested Page Not Found "); });


            app.Run();
        }
    }
}
