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


            [HttpPost]
            public IActionResult Registrar([FromBody] Empleado empleado)
            {
                try
                {
                    if (_negocio.RegistrarEmpleado(empleado))
                    {
                        return Ok("Empleado registrado correctamente.");
                    }
                    else
                    {
                        return Conflict("El empleado ya existe.");
                    }
                }
                catch (Exception ex)
                {
                    return BadRequest(new
                    {
                        mensaje = ex.Message
                    });
                }
            }
        }
    }


