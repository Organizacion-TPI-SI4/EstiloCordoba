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

        public void RegistrarServicio(Servicio servicio)
        {
            _contexto.Servicios.Add(servicio);
            _contexto.SaveChanges();
        }

        public List<Categoria> ObtenerCategorias()
        {
            return _contexto.Categorias
                .AsNoTracking()
                .ToList();
        }


        //Devuelve la lista de servicios desde la base de datos
        public List<Servicio> ObtenerServicios()
        {
            return _contexto.Servicios
                .AsNoTracking()
                .ToList();
        }

        //Devuelve la lista de empleados desde la base de datos
        public List<Empleado> ObtenerEmpleados()
        {
            return _contexto.Empleados
                .AsNoTracking()
                .ToList();
        }


        //Devuelve un empleado que cumpla con el criterio.
        public Empleado? ObtenerEmpleadoPorEmail(string email)
        {
            return _contexto.Empleados
                .AsNoTracking()
                .FirstOrDefault(e => e.Email == email);
        }
    }
}
