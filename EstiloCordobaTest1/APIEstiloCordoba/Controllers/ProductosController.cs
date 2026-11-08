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

        [HttpGet("productoPorId/{id}")]
        public IActionResult ObtenerProductoPorId(int id)
        {
            Producto producto = _negocio.ObtenerProductoPorId(id);
            return Ok(producto);
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
        [HttpPut("{id:int}")]
        public IActionResult Modificar(int id,[FromBody] Producto producto)
        {
            try
            {
                if (id != producto.Id)
                {
                    return BadRequest(new
                    {
                        mensaje = "El identificador del producto no coincide."
                    });
                }

                if (_negocio.ModificarProducto(producto))
                {
                    return Ok("Producto modificado correctamente.");
                }

                return Conflict(
                    "No se pudo modificar el producto. " +
                    "Verificá que exista y que no haya otro " +
                    "con el mismo nombre y marca.");
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
                    mensaje = "Ocurrió un error al modificar el producto."
                });
            }
        }



    }

}