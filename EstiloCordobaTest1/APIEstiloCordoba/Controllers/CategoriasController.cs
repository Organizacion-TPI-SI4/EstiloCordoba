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
         }

    }


