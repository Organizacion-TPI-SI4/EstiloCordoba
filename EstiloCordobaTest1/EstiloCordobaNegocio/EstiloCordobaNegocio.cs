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

        public bool RegistrarAtencion(Atencion atencion)
        {
            return _datos.RegistrarAtencion(atencion);
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
            if (servicio.Precio == 0 || servicio.Precio < 0)
            {
                return false;
            }
            else
            {
                return _datos.RegistrarServicio(servicio);
            }  
        }

        public bool RegistrarProducto(Producto producto)
        {
            ValidarProducto(producto);
            return _datos.RegistrarProducto(producto);
        }

        public bool ModificarProducto(Producto producto)
        {
            if (producto.Id <= 0)
            {
                throw new ArgumentException(
                    "El producto seleccionado no es válido.");
            }

            ValidarProducto(producto);
            return _datos.ModificarProducto(producto);
        }

        private static void ValidarProducto(Producto producto)
        {
            producto.Nombre = producto.Nombre.Trim();
            producto.Marca = producto.Marca.Trim();

            if (string.IsNullOrWhiteSpace(producto.Nombre))
            {
                throw new ArgumentException(
                    "El nombre del producto es obligatorio.");
            }

            if (string.IsNullOrWhiteSpace(producto.Marca))
            {
                throw new ArgumentException(
                    "La marca del producto es obligatoria.");
            }

            if (producto.PrecioVenta <= 0)
            {
                throw new ArgumentException(
                    "El precio de venta debe ser mayor a cero.");
            }

            if (producto.Stock < 0)
            {
                throw new ArgumentException(
                    "El stock no puede ser negativo.");
            }
        }

        public List<MedioPago> ObtenerMedios()
        {
            return _datos.ObtenerMedios();
        }

        public List<Producto> ObtenerProductos()
        {
            return _datos.ObtenerProductos();
        }


        public Producto ObtenerProductoPorId(int id)
        {
            return _datos.ObtenerProductoPorId(id);
        }


        public List<Atencion> ObtenerAtenciones()
        {
            return _datos.ObtenerAtenciones();
        }

        public Atencion ObtenerAtencionPorId(int id)
        {
            return _datos.ObtenerAtencionPorId(id);
        }

        public List<Atencion> ObtenerAtencionesPorEstado(int idEstado)
        {
            return _datos.ObtenerAtencionesPorEstado(idEstado);
        }

        public List<Atencion> ObtenerAtencionesPorBarbero(int idBarbero)
        {
            return _datos.ObtenerAtencionesPorBarbero(idBarbero);
        }

        public bool CambiarEstadoAtencion(int idEstado, int idAtencion)
        {

            int nuevoEstado;

            switch (idEstado)
            {
                case 1:
                    nuevoEstado = 2;
                    break;

                case 2:
                    nuevoEstado = 3;
                    break;

                case 3:
                    nuevoEstado = 4;
                    break;

                case 4:
                    nuevoEstado = 5;
                    break;

                default:
                    return false;
            }

            return _datos.CambiarEstadoAtencion(nuevoEstado, idAtencion);
        }

        public bool ActualizarAtencion(Atencion atencion)
        {
            foreach (var detalle in atencion.DetallesAtencion)
            {
                var producto = _datos.ObtenerProductoPorId(detalle.idProducto);

                if (producto == null)
                    return false;

                if (detalle.cantidad > producto.Stock)
                {
                    return false;
                }
            }

            return _datos.ActualizarAtencion(atencion);
        }

        public bool CobrarAtencion(int idEstado, int idAtencion, int idMedioPago)
        {
            return _datos.CobrarAtencion(idEstado, idAtencion, idMedioPago);
        }

        public Estado ObtenerEstadoPorId(int id)
        {
            return _datos.ObtenerEstadoPorId(id);
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

        public List<Turno> ObtenerNoAsignadosTurnos()
        {
            return _datos.ObtenerTurnosNoAsignados();
        }

        public Turno ObtenerTurnoPorId(int id)
        {
            return _datos.ObtenerTurnoPorId(id);
        }

        public List<DetTurno> ObtenerDetallesTurno(int id)
        {
            return _datos.ObtenerDetallesTurno(id);
        }

        public List<Categoria> ObtenerCategoria()
        {
            return _datos.ObtenerCategorias();
        }
       
        public List<Servicio> ObtenerServicios()
        {
            return _datos.ObtenerServicios();
        }

        public Servicio ObtenerServiciosPorId(int id)
        {
            return _datos.ObtenerServiciosPorId(id);
        }

        public List<Empleado> ObtenerEmpleados()
        {
            return _datos.ObtenerEmpleados();
        }

        public List<Empleado> ObtenerEmpleadosBarberos()
        {
            return _datos.ObtenerEmpleadosBarberos();
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
