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

        public List<Atencion> ObtenerAtenciones()
        {
            return _datos.ObtenerAtenciones();
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
