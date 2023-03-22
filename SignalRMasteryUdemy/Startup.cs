using SignalRMasteryUdemy.Hubs;

namespace SignalRMasteryUdemy
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //  Go to Azure Service portal copy connection string and paste here
            var connectionString = "";

            /*  When WebSocket Connects it will not connect to localhost,
                It will connect to Azure signalR service */
            services.AddSignalR().AddAzureSignalR(connectionString);
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
                configure.MapHub<TimeHub>("/hub/time");
            });
        }
    }
}
