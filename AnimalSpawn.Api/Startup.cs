using AnimalSpawn.Domain.Interfaces;
using AnimalSpawn.Infraestructure.Data;
using AnimalSpawn.Infraestructure.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using FluentValidation;
using AnimalSpawn.Application;

namespace AnimalSpawn.Api {
    public class Startup {
        public Startup (IConfiguration configuration) {
            Configuration = configuration;
            // var builder = new ConfigurationBuilder ()
            //     .SetBasePath (env.ContentRootPath)
            //     .AddJsonFile ("appsettings.json", optional : true, reloadOnChange : true)
            //     .AddJsonFile ($"appsettings.{env.EnvironmentName}.json", optional : true)
            //     .AddEnvironmentVariables ();
            // Configuration = builder.Build ();
        }

        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices (IServiceCollection services) {

            services.AddDbContextPool<AnimalSpawnContext> (option => {
                option.UseSqlServer (Configuration.GetConnectionString ("BDCONECCTION"));
            });
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddControllers ();
            // services.AddDbContext<AnimalSpawnContext> (options => options.UseSqlServer(Configuration.GetConnectionString("BDCONECCTION")));
            services.AddScoped<AnimalSpawnContext> ();
            services.AddTransient<IAnimalService, AnimalService>();
            services.AddScoped(typeof(IRepository<>), typeof(SQLRepository<>));
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure (IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment ()) {
                app.UseDeveloperExceptionPage ();
            }

            app.UseHttpsRedirection ();

            app.UseRouting ();

            app.UseAuthorization ();

            app.UseEndpoints (endpoints => {
                endpoints.MapControllers ();
            });
        }
    }
}