using EstiloCordobaEntidades;
using Microsoft.AspNetCore.Mvc;

namespace APIEstiloCordoba.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductosController : ControllerBase
    {
        private readonly EstiloCordobaNegocio.EstiloCordobaNegocio _negocio;

        public ProductosController(
            EstiloCordobaNegocio.EstiloCordobaNegocio negocio)
        {
            _negocio = negocio;
        }

        [HttpGet]
        public IActionResult ObtenerProductos()
        {
            List<Producto> productos = _negocio.ObtenerProductos();
            return Ok(productos);
        }

        [HttpPost]
        public IActionResult Registrar([FromBody] Producto producto)
        {
            try
            {
                if (_negocio.RegistrarProducto(producto))
                {
                    return Ok("Producto registrado correctamente.");
                }

                return Conflict(
                    "Ya existe un producto con el mismo nombre y marca.");
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new
                {
                    mensaje = ex.Message
                });
            }
            catch (Exception)
            {
                return StatusCode(500, new
                {
                    mensaje = "Ocurrió un error al registrar el producto."
                });
            }
        }
    }
}