using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Microsoft.Owin;
using Owin;

namespace Angle
{
    public partial class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration_Angle = configuration;
        }

        public IConfiguration Configuration_Angle { get; }

        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Pages/Error_404");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                //// Angle sin default route
                //routes.MapRoute(
                //    name: "default",
                //    template: "{controller=Dashboard}/{action=Dashboard_v1}/{id?}");

                // Hung default route
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Forms}/{action=FormLogin}/{id?}");
            });
        }
    }
}
