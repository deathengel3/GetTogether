using AutoMapper;
using GetTogether.Core.Persistance.Contexts;
using GetTogether.Core.Persistance.Repositories;
using GetTogether.Core.Services;
using GetTogether.Data.Repos;
using GetTogether.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetTogether.Extensions
{
    public static class ServicesExtentionsStartup
    {
        public static void ConfigureDataBase(this IServiceCollection services, IConfiguration _config)
        {
            services.AddDbContext<AppDbcontext>(options =>
            {
                options.UseSqlServer(_config.GetConnectionString("DefaultConnection").ToString());
            });
        }

        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            });
        }

        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IEmpleadoRepository, EmpleadoRepository>();
            services.AddScoped<IEmpleadoService, EmpleadoService>();
        }
    }
}
