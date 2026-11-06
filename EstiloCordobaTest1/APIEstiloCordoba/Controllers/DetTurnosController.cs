using EstiloCordobaEntidades;
using Microsoft.AspNetCore.Mvc;

namespace APIEstiloCordoba.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class DetTurnosController : ControllerBase
    {
        private readonly EstiloCordobaNegocio.EstiloCordobaNegocio _negocio;

        public DetTurnosController(EstiloCordobaNegocio.EstiloCordobaNegocio negocio)
        {
            _negocio = negocio;
        }

        [HttpGet("{id}")]
        public IActionResult ObtenerDetallesTurno(int id)
        {
            var detalles = _negocio.ObtenerDetallesTurno(id);

            return Ok(detalles);
        }
    }
}
