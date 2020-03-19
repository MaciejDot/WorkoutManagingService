using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using WorkoutManagingService.Data;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using RestSharp;
using System.Security.Cryptography;
using System.Reflection;
using WorkoutManagingService.Configuration;
using Microsoft.OpenApi.Models;
using WorkoutManagingService.Configuration.ServiceCollectionExtensions;
using WorkoutManagingService.Configuration.UsersStartUpConfiguration;

namespace WorkoutManagingService
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<WorkoutManagingServiceContext>(x => 
                x.UseSqlServer(
                    Configuration.GetConnectionString("WorkoutManagingService")
                )
            );
            services.AddControllers();
            services.AddHealthChecks();
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                builder =>
                {
                    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                });
            });
                //should ??
            services.ConfigureJWTTokenAuthorization(Configuration.GetValue<string>("TokenServiceRSAAddress"));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Workout Managing Service Api", Version = "v1" });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // should be job and it should be in nuget packages ??
            var userStartUp = new UsersStartUp(
                new RestClient(),
                new WorkoutManagingServiceContext(new DbContextOptionsBuilder<WorkoutManagingServiceContext>()
                    .UseSqlServer(Configuration.GetConnectionString("WorkoutManagingService")).Options));
            var users = userStartUp.DownloadUsers(Configuration.GetValue<string>("AccountsDataAddress"));
            userStartUp.SaveUsers(users).Wait();
            //
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Workout Managing Service Api");
            });
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseCors();
            app.UseHttpsRedirection();
            app.UseHealthChecks("/Health");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
