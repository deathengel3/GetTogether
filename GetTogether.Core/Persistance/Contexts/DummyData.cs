using GetTogether.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetTogether.Core.Persistance.Contexts
{
    public class DummyData
    {
        public static void InitializeDb(IApplicationBuilder app)
        {
            using ( var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbcontext>();
                context.Database.EnsureCreated();

                //Si la Bd contiene datos
                if (context.Empleados != null && context.Empleados.Any())
                    return;

                if (context.Lugares != null && context.Lugares.Any())
                    return;

                if (context.OpcionesComida != null && context.OpcionesComida.Any())
                    return;
            }
        }

        //Datos de empleados
        public static List<Empleado> ObtenerEmpleados()
        {
            List<Empleado> empleados = new List<Empleado>()
            {
                new Empleado { IdEmpleado = 361591, Nombre = "Noel Alejandro Hdez Baca"},
                new Empleado { IdEmpleado = 297396, Nombre = "Gabino Adrían Rufino Cruz"},
            };

            return empleados;
        }

        //Datos de Lugares
        public static List<Lugar> ObtenerLugares()
        {
            List<Lugar> empleados = new List<Lugar>()
            {
                new Lugar { NombreLugar = "Asado Argentino", DireccionLugar = "Av. De los Insurgentes sur #30045, La Joya", FechaLugar = DateTime.Now},
                new Lugar { NombreLugar = "La Casa de Toño", DireccionLugar = "Paseo Acoxpa #2339, Acoxpa", FechaLugar = DateTime.Now},
            };

            return empleados;
        }

        //Datos de OpcionesComida
        public static List<OpcionComida> ObtenerOpciones(AppDbcontext db)
        {
            //List<OpcionComida> empleados = new List<OpcionComida>()
            //{
            //    new OpcionComida { Nombre = "", Descripcion = "", Costo = 325.90, FechaOpcion = DateTime.Now, Lugar =,
            //    new OpcionComida { NombreLugar = "La Casa de Toño", DireccionLugar = "Paseo Acoxpa #2339, Acoxpa", FechaLugar = DateTime.Now},
            //};

            //return empleados;
            return null;
        }

    }
}
