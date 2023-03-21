using Microsoft.AspNetCore.Builder;
using SignalRMasteryUdemy.Hubs;
using SignalRMasteryUdemy.Servives;

namespace SignalRMasteryUdemy
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSignalR();
            services.AddTransient<IVoteManager, VoteManager>();
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

            app.UseEndpoints(configure =>
            {
                configure.MapHub<VoteHub>("/hub/vote");
                configure.MapControllers();
            });
        }
    }
}
