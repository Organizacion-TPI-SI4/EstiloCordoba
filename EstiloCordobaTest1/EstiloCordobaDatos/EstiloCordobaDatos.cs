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


        //Devuelve la lista de servicios desde la base de datos
        public List<Servicio> ObtenerServicios()
        {
            return _contexto.Servicios.AsNoTracking().ToList();
        }

        //Devuelve la lista de empleados desde la base de datos
        public List<Empleado> ObtenerEmpleados()
        {
            return _contexto.Empleados.AsNoTracking().ToList();
        }


        //Devuelve un empleado que cumpla con el criterio.
        public Empleado? ObtenerEmpleadoPorEmail(string email)
        {
            return _contexto.Empleados.AsNoTracking().FirstOrDefault(e => e.Email == email);
        }
    }
}
