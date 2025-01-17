﻿using AutoMapper;
using GetTogether.Core.Persistance.Contexts;
using GetTogether.Core.Persistance.Repositories;
using GetTogether.Core.Services;
using GetTogether.Data.Repositories;
using GetTogether.Data.Services;
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
            //Empleados
            services.AddScoped<IEmpleadoRepository, EmpleadoRepository>();
            services.AddScoped<IEmpleadoService, EmpleadoService>();
            
            //Lugares
            services.AddScoped<ILugarRepository, LugarRepository>();
            services.AddScoped<ILugarService, LugarService>();

            //OpcionesComida
            services.AddScoped<IOpcionComidaRepository, OpcionComidaRepository>();
            services.AddScoped<IOpcionComidaService, OpcionComidaService>();

            //Votaciones
            services.AddScoped<IVotacionRepository, VotacionRepository>();
            services.AddScoped<IVotacionService, VotacionService>();

            // Login
            services.AddScoped<ILoginRepository, LoginRepository>();
            services.AddScoped<ILoginService, LoginService>();
        }
    }
}
