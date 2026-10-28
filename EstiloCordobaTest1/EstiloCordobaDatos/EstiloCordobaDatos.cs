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

        public List<Empleado> ObtenerEmpleados()
        {
            return _contexto.Empleados
                .AsNoTracking()
                .ToList();
        }

        public Empleado? ObtenerEmpleadoPorEmail(string email)
        {
            return _contexto.Empleados
                .AsNoTracking()
                .FirstOrDefault(e => e.Email == email);
        }
    }
}
