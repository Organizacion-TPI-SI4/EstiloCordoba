using EstiloCordobaEntidades;
using Microsoft.AspNetCore.Mvc;

namespace APIEstiloCordoba.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class TurnosController : ControllerBase
    {
        private readonly EstiloCordobaNegocio.EstiloCordobaNegocio _negocio;

        public TurnosController(EstiloCordobaNegocio.EstiloCordobaNegocio negocio)
        {
            _negocio = negocio;
        }

        [HttpGet]
        public IActionResult ObtenerTurnos()
        {
            List<Turno> turnos = _negocio.ObtenerTurnos();
            return Ok(turnos);
        }

        [HttpGet("noasignados")]
        public IActionResult ObtenerTurnosNoAsignados()
        {
            List<Turno> turnos = _negocio.ObtenerNoAsignadosTurnos();
            return Ok(turnos);
        }

        [HttpGet("{id}")]
        public IActionResult ObtenerTurnosPorId(int id)
        {
            Turno turno = _negocio.ObtenerTurnoPorId(id);

            if (turno == null)
                return NotFound("No se encontró el turno.");

            return Ok(turno);
        }

        [HttpPost]
        public IActionResult Registrar([FromBody] Turno turno)
        {
            try
            {
                if (_negocio.RegistrarTurno(turno))
                {
                    return Ok("Turno registrado correctamente.");
                }
                else
                {
                    return Conflict("El turno ya existe.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    mensaje = ex.ToString()
                });
            }
        }
    }
}
