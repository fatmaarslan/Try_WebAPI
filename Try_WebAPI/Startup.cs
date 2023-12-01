using Try_WebAPI.Models;
using Try_WebAPI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Configuration;

namespace Try_WebAPI
{
    public class StartUp
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Dependency Injection
            services.AddScoped<ProjectsServices>();
            services.AddScoped<UsersServices>();


            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
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

    }
}
