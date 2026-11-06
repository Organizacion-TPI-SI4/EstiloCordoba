using EstiloCordobaEntidades;
using Microsoft.AspNetCore.Mvc;

namespace APIEstiloCordoba.Controllers
{


    [ApiController]
    [Route("api/[controller]")]
    public class AtencionesController : ControllerBase
    {

        private readonly EstiloCordobaNegocio.EstiloCordobaNegocio _negocio;

        public AtencionesController(EstiloCordobaNegocio.EstiloCordobaNegocio negocio)
        {
            _negocio = negocio;
        }

        [HttpGet]
        public IActionResult ObtenerAtenciones()
        {
            List<Atencion> atenciones = _negocio.ObtenerAtenciones();
            return Ok(atenciones);
        }


        [HttpPost]
        public IActionResult Registrar([FromBody] Atencion atencion)
        {
            try
            {
                if (_negocio.RegistrarAtencion(atencion))
                {
                    return Ok("Atencion registrada correctamente.");
                }
                else { 
                    return Conflict("El turno seleccionado ya fue registrado en atenciones.");
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
