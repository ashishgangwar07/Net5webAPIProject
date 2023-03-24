using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace consoleApptoWebAPI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello from Use1 middleware \n");
                await next();
                await context.Response.WriteAsync("Hello from Use2 middleware \n");
            });
            app.Map("/ashish", customMessage);
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Hello from Run1 middleware \n");
            });


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();

            });
        }

        private void customMessage(IApplicationBuilder app)
        {
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello from custom Message \n");
            });
        }
    }
}
