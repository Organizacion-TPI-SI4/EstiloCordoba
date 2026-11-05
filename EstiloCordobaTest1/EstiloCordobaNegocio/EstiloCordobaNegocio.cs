using EstiloCordobaEntidades;
using EstiloCordobaDatos;

namespace EstiloCordobaNegocio
{
    public class EstiloCordobaNegocio
    {
        private readonly EstiloCordobaDatos.EstiloCordobaDatos _datos;

        public EstiloCordobaNegocio(EstiloCordobaDatos.EstiloCordobaDatos datos)
        {
            _datos = datos;
        }

        public bool RegistrarTurno(Turno turno)
        {
            return _datos.RegistrarTurno(turno);
        }

        public bool RegistrarCliente(Cliente cliente)
        {
            return _datos.RegistrarCliente(cliente);
        }

        public bool RegistrarEmpleado(Empleado empleado)
        {
            return _datos.RegistrarEmpleado(empleado);
        }

        public bool RegistrarCategoria(Categoria categoria)
        {
            return _datos.RegistrarCategoria(categoria);
        }
            
        public bool RegistrarServicio(Servicio servicio)
        {
            return _datos.RegistrarServicio(servicio);
        }

        public bool RegistrarProducto(Producto producto)
        {
            producto.Nombre = producto.Nombre.Trim();
            producto.Marca = producto.Marca.Trim();

            if (string.IsNullOrWhiteSpace(producto.Nombre))
            {
                throw new ArgumentException("El nombre del producto es obligatorio.");
            }

            if (string.IsNullOrWhiteSpace(producto.Marca))
            {
                throw new ArgumentException("La marca del producto es obligatoria.");
            }

            if (producto.PrecioVenta <= 0)
            {
                throw new ArgumentException("El precio de venta debe ser mayor a cero.");
            }

            if (producto.Stock < 0)
            {
                throw new ArgumentException("El stock no puede ser negativo.");
            }

            return _datos.RegistrarProducto(producto);
        }

        public List<Producto> ObtenerProductos()
        {
            return _datos.ObtenerProductos();
        }



        public List<Cliente> ObtenerClientes()
        {
            return _datos.ObtenerClientes();
        }

        public List<Rol> ObtenerRoles()
        {
            return _datos.ObtenerRoles();
        }


        public List<Turno> ObtenerTurnos()
        {
            return _datos.ObtenerTurnos();
        }

        public List<Categoria> ObtenerCategoria()
        {
            return _datos.ObtenerCategorias();
        }
       

        public List<Servicio> ObtenerServicios()
        {
            return _datos.ObtenerServicios();
        }

        public List<Empleado> ObtenerEmpleados()
        {
            return _datos.ObtenerEmpleados();
        }

        public Empleado? ValidarLogin(string email, string clave)
        {
            var empleado = _datos.ObtenerEmpleadoPorEmail(email.Trim());

            if (empleado == null || empleado.Clave != clave)
            {
                return null;
            }

            return empleado;
        }
    }
}
