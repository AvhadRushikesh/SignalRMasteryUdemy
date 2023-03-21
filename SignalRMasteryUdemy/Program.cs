//using SignalRMasteryUdemy.Hubs;
//var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddSignalR();
//var app = builder.Build();
//app.UseDefaultFiles();
//app.UseStaticFiles();
//app.UseRouting();
//app.MapHub<ViewHub>("/hubs/view");
//app.Run();



namespace SignalRMasteryUdemy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}