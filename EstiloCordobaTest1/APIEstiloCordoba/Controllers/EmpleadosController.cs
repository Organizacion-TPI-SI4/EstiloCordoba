using EstiloCordobaEntidades;
using Microsoft.AspNetCore.Mvc;

namespace APIEstiloCordoba.Controllers
{
        [ApiController]
        [Route("api/[controller]")]
        public class EmpleadosController : ControllerBase
        {
            private readonly EstiloCordobaNegocio.EstiloCordobaNegocio _negocio;

            public EmpleadosController(
                EstiloCordobaNegocio.EstiloCordobaNegocio negocio)
            {
                _negocio = negocio;
            }

            [HttpGet]
            public ActionResult<List<Empleado>> ObtenerEmpleados()
            {
                var empleados = _negocio.ObtenerEmpleados();

                return Ok(empleados);
            }
        }
    }


