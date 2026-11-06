using Microsoft.AspNetCore.Mvc;
using EstiloCordobaEntidades;

namespace APIEstiloCordoba.Controllers
{


    [ApiController]
    [Route("api/[controller]")]
    public class ServiciosController : ControllerBase
    {
        private readonly EstiloCordobaNegocio.EstiloCordobaNegocio _negocio;

        public ServiciosController(
            EstiloCordobaNegocio.EstiloCordobaNegocio negocio)
        {
            _negocio = negocio;
        }


        //Este GET trae informacion desde la capa de negocio a la API y esta la entrega a la capa de presentacion.
        [HttpGet]
        public IActionResult ObtenerServicios()
        {
            List<Servicio> servicios = _negocio.ObtenerServicios();
            return Ok(servicios);
        }

        [HttpGet("{id}")]
        public IActionResult ObtenerServiciosPorId(int id)
        {
            var servicio = _negocio.ObtenerServiciosPorId(id);

            if (servicio == null)
                return NotFound("No se encontró el servicio.");

            return Ok(servicio);
        }


        //Este post envia informacion desde la API a la capa de negocios.
        [HttpPost]
        public IActionResult Registrar([FromBody] Servicio servicio)
        {
            try
            {
                if (_negocio.RegistrarServicio(servicio))
                {
                    return Ok("Servicio registrado correctamente.");
                }
                else
                {
                    return Conflict("El servicio ya existe.");
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
