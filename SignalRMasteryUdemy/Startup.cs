using SignalRMasteryUdemy.Hubs;

namespace SignalRMasteryUdemy
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // connection string to redis - Get from configuration! 
            var connectionString = "";

            // Add StackExchange Redis helper
            services.AddSignalR().AddStackExchangeRedis(connectionString, configure => {
                configure.Configuration.ChannelPrefix = "signalr";
                configure.Configuration.DefaultDatabase = 5;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseDefaultFiles(); //index.html
            app.UseStaticFiles();

            app.UseEndpoints(configure => {
                configure.MapHub<BackgroundColorHub>("/hub/background");
            });
        }
    }
}
