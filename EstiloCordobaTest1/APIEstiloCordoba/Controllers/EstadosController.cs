using Microsoft.AspNetCore.Mvc;
using EstiloCordobaEntidades;

namespace APIEstiloCordoba.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class EstadosController : ControllerBase
    {
        private readonly EstiloCordobaNegocio.EstiloCordobaNegocio _negocio;
        public EstadosController(EstiloCordobaNegocio.EstiloCordobaNegocio negocio)
        {
            _negocio = negocio;
        }


        [HttpGet("{id}")]
        public IActionResult ObtenerEstadoPorId(int id)
        {
            Estado estado = _negocio.ObtenerEstadoPorId(id);
            return Ok(estado);
        }
    }
}
