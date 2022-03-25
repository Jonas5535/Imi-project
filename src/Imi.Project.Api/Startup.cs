using Imi.Project.Api.Core.Infrastructure.Repositories;
using Imi.Project.Api.Core.Infrastructure.Services;
using Imi.Project.Api.Core.Services;
using Imi.Project.Api.Infrastructure.Data;
using Imi.Project.Api.Infrastructure.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Api
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
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            //Repository classes and interfaces
            services.AddScoped<IAircraftTypeRepository, AircraftTypeRepository>();
            services.AddScoped<IAirlineRepository, AirlineRepository>();
            services.AddScoped<IAirportRepository, AirportRepository>();
            services.AddScoped<IAircraftRepository, AircraftRepository>();

            //Service classes and interfaces
            services.AddScoped<IAircraftService, AircraftService>();
            services.AddScoped<IAircraftTypeService, AircraftTypeService>();
            services.AddScoped<IAirlineService, AirlineService>();
            services.AddScoped<IAirportService, AirportService>();

            //Register the Swagger generator, defining 1 or more Swagger documents.
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "IMI-Lampaert-Jonas", Version = "v1" });
                var filePath = Path.Combine(AppContext.BaseDirectory, "ApiDocs.xml");
                c.IncludeXmlComments(filePath);
            });

            services.AddControllers();
            services.AddCors();
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
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "IMI-Lampaert-Jonas");
                c.RoutePrefix = string.Empty;
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseCors(builder => builder.AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod());
        }
    }
}
