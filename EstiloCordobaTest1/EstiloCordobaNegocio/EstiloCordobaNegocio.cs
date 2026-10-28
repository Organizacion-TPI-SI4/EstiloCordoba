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
