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

        public DbSet<Categoria> Categorias => Set<Categoria>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Producto>()
                .Property(p => p.PrecioVenta)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Servicio>()
                .Property(s => s.Precio)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Servicio>()
                .HasOne<Categoria>()
                .WithMany()
                .HasForeignKey(s => s.CategoriaId);

            modelBuilder.Entity<Empleado>()
                .HasOne<Rol>()
                .WithMany()
                .HasForeignKey(e => e.IdRol);

            modelBuilder.Entity<Rol>().HasData(
            new Rol
            {
                Id = 1,
                Descripcion = "Administrador"
            },
            new Rol
            {
                Id = 2,
                Descripcion = "Recepcionista"
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

            modelBuilder.Entity<Servicio>().HasData(
            new Servicio
            {
                Id = 1,
                Nombre = "Corte de cabello",
                Precio = 8000m,
                Duracion = "30 minutos",
                CategoriaId = 1
            },
            new Servicio
            {
                Id = 2,
                Nombre = "Coloración",
                Precio = 25000m,
                Duracion = "120 minutos",
                CategoriaId = 2
            },
            new Servicio
            {
                Id = 3,
                Nombre = "Peinado",
                Precio = 12000m,
                Duracion = "45 minutos",
                CategoriaId = 1
            }
        );

            modelBuilder.Entity<Categoria>().HasData(
            new Categoria { Id = 1, descripcion = "Corte y Estilizado" },
            new Categoria { Id = 2, descripcion = "Colorimetria" }
        );
        }   
    }
}


