using EstiloCordobaEF;
using EstiloCordobaEntidades;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace EstiloCordobaDatos
{
    public class EstiloCordobaDatos
    {
        private readonly EstiloCordobaDbContext _contexto;

        public EstiloCordobaDatos(EstiloCordobaDbContext contexto)
        {
            _contexto = contexto;
        }

        public bool RegistrarAtencion(Atencion atencion)
        {
            bool existe = _contexto.Atenciones
        .Any(a => a.idTurno == atencion.idTurno);

            if (existe)
                return false;

            try
            {
                _contexto.Atenciones.Add(atencion);
                _contexto.SaveChanges();

                return true;
            }
            catch (DbUpdateException ex)
            {
                throw new Exception(
                    "Error SQL: " + ex.InnerException?.Message, ex);
            }
        }

        public bool RegistrarTurno(Turno turno)
        {
                _contexto.Turnos.Add(turno);
                _contexto.SaveChanges();
                return true;   
        }

        public bool RegistrarCliente(Cliente cliente)
        {

            bool existe = _contexto.Clientes.Any(c => c.numeroDni == cliente.numeroDni);

            if (existe)
            {
                return false;
            }
            else
            {
                _contexto.Clientes.Add(cliente);
                _contexto.SaveChanges();
                return true;
            }
        }

        public bool RegistrarEmpleado(Empleado empleado)
        {

            bool existe = _contexto.Empleados.Any(e => e.Email.ToLower() == empleado.Email.ToLower());

            if (existe)
            {
                return false;
            }
            else
            {
                _contexto.Empleados.Add(empleado);
                _contexto.SaveChanges();
                return true;
            }
        }

        public bool RegistrarCategoria(Categoria categoria)
        {
            bool existe = _contexto.Categorias.Any(c => c.descripcion.ToLower() == categoria.descripcion.ToLower());

            if (existe)
            {
                return false;
            }
            else
            {
                _contexto.Categorias.Add(categoria);
                _contexto.SaveChanges();
                return true;
            }
        }

        public bool RegistrarServicio(Servicio servicio)
        {

            bool existe = _contexto.Servicios.Any(c => c.Nombre.ToLower() == servicio.Nombre.ToLower());

            if (existe)
            {
                return false;
            }
            else
            {
                _contexto.Servicios.Add(servicio);
                _contexto.SaveChanges();
                return true;
            }
        }

        public bool RegistrarProducto(Producto producto)
        {
            bool existe = _contexto.Productos.Any(p =>
                p.Nombre.ToLower() == producto.Nombre.ToLower() &&
                p.Marca.ToLower() == producto.Marca.ToLower());

            if (existe)
            {
                return false;
            }

            _contexto.Productos.Add(producto);
            _contexto.SaveChanges();
            return true;
        }


        public bool ModificarProducto(Producto producto)
        {
            Producto? productoExistente = _contexto.Productos
                .FirstOrDefault(p => p.Id == producto.Id);

            if (productoExistente == null)
            {
                return false;
            }

            bool existeDuplicado = _contexto.Productos.Any(p =>
                p.Id != producto.Id &&
                p.Nombre.ToLower() == producto.Nombre.ToLower() &&
                p.Marca.ToLower() == producto.Marca.ToLower());

            if (existeDuplicado)
            {
                return false;
            }

            productoExistente.Nombre = producto.Nombre.Trim();
            productoExistente.Marca = producto.Marca.Trim();
            productoExistente.PrecioVenta = producto.PrecioVenta;
            productoExistente.Stock = producto.Stock;

            _contexto.SaveChanges();
            return true;
        }



        public List<Producto> ObtenerProductos()
        {
            return _contexto.Productos
                .AsNoTracking()
                .ToList();
        }

        public List<Turno> ObtenerTurnos()
        {
            return _contexto.Turnos.Include(t => t.usuario).Include(t => t.cliente).Include(t => t.DetallesTurno).ThenInclude(d => d.servicio)
            .AsNoTracking()
            .ToList();
        }

        public Turno ObtenerTurnoPorId(int id)
        {
            if(!_contexto.Turnos.Any(t => t.id == id))
            {
                return null;
            }
            else
            {
                return _contexto.Turnos.AsNoTracking().Include(t => t.cliente).FirstOrDefault(t => t.id == id);
            }   
        }

        public List<Atencion> ObtenerAtenciones()
        {
            return _contexto.Atenciones.AsNoTracking().ToList();
        }

        public List<Cliente> ObtenerClientes()
        {
            return _contexto.Clientes.AsNoTracking().ToList();
        }

        public List<Rol> ObtenerRoles()
        {
            return _contexto.Roles.AsNoTracking().ToList();
        }

        public List<Categoria> ObtenerCategorias()
        {
            return _contexto.Categorias.AsNoTracking().ToList();
        }

        public List<DetTurno> ObtenerDetallesTurno(int id)
        {
            return _contexto.DetallesTurno.AsNoTracking().Where(d => d.idTurnoPadre == id).ToList();
        }


        //Devuelve la lista de servicios desde la base de datos
        public List<Servicio> ObtenerServicios()
        {
            return _contexto.Servicios.AsNoTracking().ToList();
        }

        public Servicio ObtenerServiciosPorId(int id)
        {
            return _contexto.Servicios.AsNoTracking().FirstOrDefault(s => s.Id == id);
        }

        //Devuelve la lista de empleados desde la base de datos
        public List<Empleado> ObtenerEmpleados()
        {
            return _contexto.Empleados.AsNoTracking().ToList();
        }

        public List<Empleado> ObtenerEmpleadosBarberos()
        {
            return _contexto.Empleados.AsNoTracking().Where(e => e.IdRol == 3).ToList();
        }


        //Devuelve un empleado que cumpla con el criterio.
        public Empleado? ObtenerEmpleadoPorEmail(string email)
        {
            return _contexto.Empleados.AsNoTracking().FirstOrDefault(e => e.Email == email);
        }
    }
}
