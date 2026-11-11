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
        public DbSet<Cliente> Clientes => Set<Cliente>();
        public DbSet<Turno> Turnos => Set<Turno>();
        public DbSet<DetTurno> DetallesTurno => Set<DetTurno>();

        public DbSet<DetAtencion> DetallesAtencion => Set<DetAtencion>();

        public DbSet<Atencion> Atenciones => Set<Atencion>();

        public DbSet<Estado> Estados => Set<Estado>();

        public DbSet<MedioPago> MediosPago => Set<MedioPago>();

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

            modelBuilder.Entity<Cliente>()
                .HasOne<Beneficio>()
                .WithMany()
                .HasForeignKey(e => e.IdBeneficio);

            modelBuilder.Entity<DetTurno>() 
                .HasOne(d => d.turno)
                .WithMany(t => t.DetallesTurno)
                .HasForeignKey(d => d.idTurnoPadre);

            modelBuilder.Entity<DetTurno>()
                .HasOne(d => d.servicio)
                .WithMany()
                .HasForeignKey(d => d.idServicio);

            modelBuilder.Entity<Turno>()
                .HasOne(t => t.usuario)
                .WithMany()
                .HasForeignKey(t => t.idUsuario);

            modelBuilder.Entity<Turno>()
                .HasOne(t => t.cliente)
                .WithMany()
                .HasForeignKey(t => t.idCliente);

            modelBuilder.Entity<Atencion>()
                .Property(a => a.totalCalculado)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Atencion>()
                .Property(a => a.totalServicios)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Atencion>()
                .Property(a => a.totalProductos)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Atencion>()
               .HasOne(a => a.Cliente)
               .WithMany()
               .HasForeignKey(a => a.idCliente)
               .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Atencion>()
                .HasOne(a => a.Turno)
                .WithMany()
                .HasForeignKey(a => a.idTurno)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Atencion>()
               .HasOne(a => a.Estado)
               .WithMany()
               .HasForeignKey(a => a.idEstado)
               .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Atencion>()
               .HasOne(a => a.Empleado)
               .WithMany()
               .HasForeignKey(a => a.idBarbero)
               .OnDelete(DeleteBehavior.NoAction);

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
            },
            new Rol
            {
                Id = 3,
                Descripcion = "Barbero"
            },
            new Rol
            {
                Id = 4,
                Descripcion = "Compras"
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

            modelBuilder.Entity<Cliente>().HasData(
            new Cliente
            {
                Id = 1,
                Nombre = "Cliente de prueba",
                Apellido = "Apellido de prueba",
                tipoDni = "A",
                numeroDni = 12345678,
                Telefono = "3510000003",
                Email = "cliente@estilocordoba.com",
                localidad = "Cordoba",
                Red_social = "Instagram: @clientedeprueba"
            }
        );

            modelBuilder.Entity<Categoria>().HasData(
            new Categoria { Id = 1, descripcion = "Corte y Estilizado" },
            new Categoria { Id = 2, descripcion = "Colorimetria" }
        );

            modelBuilder.Entity<Estado>().HasData(
            new Estado
            {
                id = 1,
                nombreEstado = "Registrada"
            },
             new Estado
             {
                 id = 2,
                 nombreEstado = "Iniciada"
             },
             new Estado
             {
                 id = 3,
                 nombreEstado = "Finalizada"
             },
             new Estado
             {
                 id = 4,
                 nombreEstado = "Pendiente de pago"
             },
             new Estado
             {
                 id = 5,
                 nombreEstado = "Cobrada"
              }
             );

            modelBuilder.Entity<MedioPago>().HasData(
            new MedioPago
            {
                id = 1,
                descripcion = "Efectivo/Transferencia"
            },
            new MedioPago
            {
                id = 2,
                descripcion = "Tarjeta de crédito"
            },
            new MedioPago
            {
                id = 3,
                descripcion = "Tarjeta de débito"
            });
        }   
    }
}


