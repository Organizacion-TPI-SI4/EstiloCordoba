using APIEstiloCordoba.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace APIEstiloCordoba.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly EstiloCordobaNegocio.EstiloCordobaNegocio _negocio;

        public AuthController(
            EstiloCordobaNegocio.EstiloCordobaNegocio negocio)
        {
            _negocio = negocio;
        }

        [HttpPost("login")]
        public ActionResult<LoginResponse> Login(
            [FromBody] LoginRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Email) ||
                string.IsNullOrEmpty(request.Clave))
            {
                return BadRequest(new LoginResponse
                {
                    Exito = false,
                    Mensaje = "Ingresá email y clave."
                });
            }

            var empleado = _negocio.ValidarLogin(
                request.Email,
                request.Clave);

            if (empleado == null)
            {
                return Unauthorized(new LoginResponse
                {
                    Exito = false,
                    Mensaje = "Email o clave incorrectos."
                });
            }

            return Ok(new LoginResponse
            {
                Exito = true,
                Mensaje = "Inicio de sesión exitoso.",
                IdEmpleado = empleado.Id,
                Nombre = empleado.Nombre,
                IdRol = empleado.IdRol
            });
        }
    }
}
