using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreTraining.Data;
using AspNetCoreTraining.Data.Repos;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace AspNetCoreTraining
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ASPNET CORE Training", Version = "v1" });
            });

            services.AddDbContext<TrainingContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("TrainingContext")));

            services.AddScoped<StudentRepo>();
            services.AddScoped<CourseRepo>();
            services.AddScoped<EnrollmentRepo>();

            services.AddScoped<GuidGenerator>();

            services.AddScoped<GuidFactory>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "ASPNET CORE Training");
                c.RoutePrefix = string.Empty;
            });

            app.Use(async (context, next) =>
            {
                context.Request.Headers.Add("X-Testing", "Yassir");
                await next.Invoke();
                context.Response.Cookies.Append("X-Testing", "Yassir");
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
