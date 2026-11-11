using Microsoft.AspNetCore.Mvc;

namespace APIEstiloCordoba.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class MediosController : ControllerBase
    {
        private readonly EstiloCordobaNegocio.EstiloCordobaNegocio _negocio;

        public MediosController(EstiloCordobaNegocio.EstiloCordobaNegocio negocio)
        {
            _negocio = negocio;
        }

        [HttpGet]
        public IActionResult ObtenerMedios()
        {
            var medios = _negocio.ObtenerMedios();
            return Ok(medios);
        }
    }
}
