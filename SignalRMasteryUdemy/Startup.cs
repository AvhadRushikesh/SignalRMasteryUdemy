using Microsoft.AspNetCore.Builder;
using SignalRMasteryUdemy.Hubs;

namespace SignalRMasteryUdemy
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSignalR();
        }


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
                configure.MapHub<ViewHub>("/hub/view");
            });
        }
    }
}
