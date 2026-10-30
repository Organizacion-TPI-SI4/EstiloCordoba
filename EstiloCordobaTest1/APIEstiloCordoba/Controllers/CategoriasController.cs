using EstiloCordobaEntidades;
using Microsoft.AspNetCore.Mvc;

namespace APIEstiloCordoba.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriasController : ControllerBase
    {
        private readonly EstiloCordobaNegocio.EstiloCordobaNegocio _negocio;

        public CategoriasController(EstiloCordobaNegocio.EstiloCordobaNegocio negocio)
        {
            _negocio = negocio;
        }

        [HttpGet]
        public IActionResult ObtenerCategorias()
        {
            List<Categoria> categoria = _negocio.ObtenerCategoria();
            return Ok(categoria);
        }

        [HttpPost]
        public IActionResult Registrar([FromBody] Categoria categoria)
        {
            try

            {
                if (_negocio.RegistrarCategoria(categoria))
                {
                    return Ok("Categoría registrada correctamente.");
                }
                else
                {
                    return Conflict("La categoria ya existe.");
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


