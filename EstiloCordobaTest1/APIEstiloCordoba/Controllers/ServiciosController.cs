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


        //Este post envia informacion desde la API a la capa de negocios.
        [HttpPost]
        public IActionResult Registrar([FromBody] Servicio servicio)
        {
            try
            {
                _negocio.RegistrarServicio(servicio);

                return Ok(new
                {
                    mensaje = "Servicio registrado correctamente."
                });
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
