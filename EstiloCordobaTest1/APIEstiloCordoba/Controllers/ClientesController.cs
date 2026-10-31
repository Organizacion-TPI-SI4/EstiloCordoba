using EstiloCordobaEntidades;
using Microsoft.AspNetCore.Mvc;

namespace APIEstiloCordoba.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : ControllerBase
    {

        private readonly EstiloCordobaNegocio.EstiloCordobaNegocio _negocio;

        public ClientesController(EstiloCordobaNegocio.EstiloCordobaNegocio negocio)
        {
            _negocio = negocio;
        }

        [HttpGet]
        public ActionResult<List<Cliente>> ObtenerClientes()
        {
            var clientes = _negocio.ObtenerClientes();

            return Ok(clientes);
        }
    }
}
