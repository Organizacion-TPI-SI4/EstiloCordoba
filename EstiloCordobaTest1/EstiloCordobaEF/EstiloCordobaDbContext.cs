using EstiloCordobaEntidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace EstiloCordobaEF
{
    public class EstiloCordobaDbContext: DbContext
    {
        public EstiloCordobaDbContext(
            DbContextOptions<EstiloCordobaDbContext> options)
            : base(options)
        {
        }

        public DbSet<Empleado> Empleados => Set<Empleado>();
        public DbSet<Producto> Productos => Set<Producto>();
        public DbSet<Servicio> Servicios => Set<Servicio>();
        public DbSet<Rol> Roles => Set<Rol>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Producto>()
                .Property(p => p.PrecioVenta)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Servicio>()
                .Property(s => s.Precio)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Rol>().HasData(
            new Rol
            {
                Id = 1,
                Descripcion = "Administrador"
            },
            new Rol
            {
                Id = 2,
                Descripcion = "Empleado"
            });

            modelBuilder.Entity<Empleado>().HasData(
            new Empleado
            {
                Id = 1,
                Nombre = "Administrador",
                Domicilio = "Cordoba",
                Telefono = "3510000001",
                Email = "admin@estilocordoba.com",
                Clave = "Admin",
                IdRol = 1
            },
            new Empleado
            {
                Id = 2,
                Nombre = "Empleado de prueba",
                Domicilio = "Cordoba",
                Telefono = "3510000002",
                Email = "empleado@estilocordoba.com",
                Clave = "Test123",
                IdRol = 2
            }
            );
        }   
    }
}


