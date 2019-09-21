using GetTogether.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GetTogether.Core.Persistance.Contexts
{
    public class AppDbcontext : DbContext
    {
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Lugar> Lugares { get; set; }
        public DbSet<OpcionComida> OpcionesComida { get; set; }
        public DbSet<Votacion> Votaciones { get; set; }

        public AppDbcontext(DbContextOptions<AppDbcontext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Empleado>().ToTable("Empleados");
            builder.Entity<Empleado>().HasKey(e => e.IdEmpleado); // LLave primaria
            builder.Entity<Empleado>().Property(e => e.IdEmpleado).IsRequired().HasColumnType("INT");//.ValueGeneratedOnAdd();
            builder.Entity<Empleado>().Property(e => e.NumeroEmpleado).IsRequired().HasColumnType("INT");
            builder.Entity<Empleado>().Property(e => e.Nombre).IsRequired().HasMaxLength(250).HasColumnType("VARCHAR(250)");
            builder.Entity<Empleado>().Property(e => e.Rol).IsRequired().HasColumnType("INT");

            builder.Entity<Lugar>().ToTable("Lugares");
            builder.Entity<Lugar>().HasKey(l => l.IdLugar); // LLave primaria
            builder.Entity<Lugar>().Property(l => l.IdLugar).IsRequired().ValueGeneratedOnAdd().HasColumnType("INT");
            builder.Entity<Lugar>().Property(l => l.NombreLugar).IsRequired().HasMaxLength(250).HasColumnType("VARCHAR(250)");
            builder.Entity<Lugar>().Property(l => l.DireccionLugar).IsRequired().HasMaxLength(250).HasColumnType("VARCHAR(250)");
            builder.Entity<Lugar>().Property(l => l.FechaLugar).IsRequired().HasDefaultValue(DateTime.Now).ValueGeneratedOnAdd().HasColumnType("DATETIME");
            builder.Entity<Lugar>().Property(l => l.FechaLugarModificacion).IsRequired().HasDefaultValue(DateTime.Now).ValueGeneratedOnAdd().HasColumnType("DATETIME"); ;
            builder.Entity<Lugar>().HasMany<OpcionComida>(l => l.OpcionesComida).WithOne().HasForeignKey(p => p.LugarId);
            //builder.Entity<Lugar>().HasMany<Votacion>(l => l.Votacion).WithOne(l => l.Lugar).HasForeignKey(l => l.IdVotacion);

            builder.Entity<OpcionComida>().ToTable("OpcionesComida");
            builder.Entity<OpcionComida>().HasKey(oc => oc.IdOpcion); // LLave primaria
            builder.Entity<OpcionComida>().Property(oc => oc.IdOpcion).IsRequired().ValueGeneratedOnAdd().HasColumnType("INT");
            builder.Entity<OpcionComida>().Property(oc => oc.Nombre).IsRequired().HasMaxLength(250).HasColumnType("VARCHAR(250)");
            builder.Entity<OpcionComida>().Property(oc => oc.Descripcion).IsRequired().HasMaxLength(250).HasColumnType("VARCHAR(250)");
            builder.Entity<OpcionComida>().Property(oc => oc.Costo).IsRequired().HasColumnType("DECIMAL(18, 2)");
            builder.Entity<OpcionComida>().Property(oc => oc.FechaOpcion).IsRequired().HasDefaultValue(DateTime.Now).ValueGeneratedOnAdd().HasColumnType("DATETIME");
            builder.Entity<OpcionComida>().Property(oc => oc.FechaOpcionModificacion).IsRequired().HasDefaultValue(DateTime.Now).ValueGeneratedOnAdd().HasColumnType("DATETIME");
            //builder.Entity<OpcionComida>().HasOne<Lugar>(oc => oc.Lugar).WithMany(oc => oc.OpcionesComida).HasForeignKey(oc => oc.LugarId);
            //builder.Entity<OpcionComida>().HasMany<Votacion>(oc => oc.Votacion).WithOne(oc => oc.OpcionComida).HasForeignKey(oc => oc.IdVotacion);


            builder.Entity<Votacion>().ToTable("Votaciones");
            builder.Entity<Votacion>().HasKey(v => v.IdVotacion); // LLave primaria
            builder.Entity<Votacion>().Property(v => v.IdVotacion).IsRequired().ValueGeneratedOnAdd().HasColumnType("INT");
            builder.Entity<Votacion>().Property(v => v.FechaRegistro).IsRequired().HasDefaultValue(DateTime.Now).ValueGeneratedOnAdd().HasColumnType("DATETIME");
            builder.Entity<Votacion>().Property(v => v.FechaModificacion).IsRequired().HasDefaultValue(DateTime.Now).ValueGeneratedOnAddOrUpdate().HasColumnType("DATETIME");
            builder.Entity<Votacion>().HasOne<Empleado>(v => v.Empleado).WithOne();
            //builder.Entity<Votacion>().HasOne<Lugar>(v => v.Lugar).WithMany().HasForeignKey(v => v.LugarId);
            builder.Entity<Votacion>().HasOne<OpcionComida>(v => v.OpcionComida).WithMany().HasForeignKey(v => v.OpcionComidaId);


            base.OnModelCreating(builder);
        }

    }
}
