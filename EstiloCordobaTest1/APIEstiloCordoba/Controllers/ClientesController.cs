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

        [HttpPost]
        public IActionResult Registrar([FromBody] Cliente cliente)
        {
            try
            {
                if (_negocio.RegistrarCliente(cliente))
                {
                    return Ok("Cliente registrado correctamente.");
                }
                else
                {
                    return Conflict("El cliente ya existe.");
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
