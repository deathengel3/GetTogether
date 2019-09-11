using GetTogether.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GetTogether.Core.Persistance.Contexts
{
    public class AppDbcontext : DbContext
    {
        public DbSet<Empleado> Empleados { get; set; }
        //public DbSet<Lugar> Lugares { get; set; }
        //public DbSet<OpcionComida> OpcionesComida { get; set; }
        //public DbSet<Votacion> Votaciones { get; set; }

        public AppDbcontext(DbContextOptions<AppDbcontext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Empleado>().ToTable("Empleados");
            builder.Entity<Empleado>().HasKey(e => e.IdEmpleado); // LLave primaria
            builder.Entity<Empleado>().Property(e => e.IdEmpleado).IsRequired();//.ValueGeneratedOnAdd();
            builder.Entity<Empleado>().Property(e => e.Nombre).IsRequired().HasMaxLength(250);

            /*
            builder.Entity<Lugar>().ToTable("Lugares");
            builder.Entity<Lugar>().HasKey(l => l.IdLugar); // LLave primaria
            builder.Entity<Lugar>().Property(l => l.IdLugar).IsRequired().ValueGeneratedOnAdd().HasColumnType("INT");
            builder.Entity<Lugar>().Property(l => l.NombreLugar).IsRequired().HasMaxLength(250).HasColumnType("VARCHAR(250)");
            builder.Entity<Lugar>().Property(l => l.DireccionLugar).IsRequired().HasMaxLength(250).HasColumnType("VARCHAR(250)");
            builder.Entity<Lugar>().Property(l => l.FechaLugar).IsRequired().HasDefaultValue(DateTime.Now).ValueGeneratedOnAdd().HasColumnType("DATETIME"); ;
            builder.Entity<Lugar>().HasMany<OpcionComida>(l => l.OpcionesComida).WithOne(l => l.Lugar).HasForeignKey(p => p.LugarId);

            builder.Entity<OpcionComida>().ToTable("OpcionesComida");
            builder.Entity<OpcionComida>().HasKey(oc => oc.IdOpcion); // LLave primaria
            builder.Entity<OpcionComida>().Property(oc => oc.IdOpcion).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<OpcionComida>().Property(oc => oc.Descripcion).IsRequired().HasMaxLength(250);
            builder.Entity<OpcionComida>().Property(oc => oc.FechaOpcion).IsRequired().HasDefaultValue(DateTime.Now).ValueGeneratedOnAdd();
            builder.Entity<OpcionComida>().HasOne<Lugar>(oc => oc.Lugar).WithMany(oc => oc.OpcionesComida).HasForeignKey(oc => oc.LugarId);

            builder.Entity<Votacion>().ToTable("Votaciones");
            builder.Entity<Votacion>().HasKey(v => v.IdVotacion); // LLave primaria
            builder.Entity<Votacion>().Property(v => v.IdVotacion).IsRequired().HasDefaultValue(DateTime.Now).ValueGeneratedOnAdd();
            builder.Entity<Votacion>().Property(v => v.FechaRegistro).IsRequired().HasDefaultValue(DateTime.Now).ValueGeneratedOnAdd();
            builder.Entity<Votacion>().Property(v => v.FechaRegistro).IsRequired().HasDefaultValue(DateTime.Now).ValueGeneratedOnAddOrUpdate();
            builder.Entity<Votacion>().HasOne<Empleado>(v => v.Empleado).WithOne(v => v.Votacion);
            builder.Entity<Votacion>().HasOne<Lugar>(v => v.Lugar).WithMany(v => v.Votacion).HasForeignKey(v => v.LugarId);
            builder.Entity<Votacion>().HasOne<OpcionComida>(v => v.OpcionComida).WithMany(v => v.Votacion).HasForeignKey(v => v.OpcionComidaId);
            */
        }

    }
}
