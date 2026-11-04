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
