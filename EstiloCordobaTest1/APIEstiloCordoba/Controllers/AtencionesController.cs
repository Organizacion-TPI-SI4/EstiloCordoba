using APIEstiloCordoba.DTOs;
using EstiloCordobaEntidades;
using Microsoft.AspNetCore.Mvc;

namespace APIEstiloCordoba.Controllers
{


    [ApiController]
    [Route("api/[controller]")]
    public class AtencionesController : ControllerBase
    {

        private readonly EstiloCordobaNegocio.EstiloCordobaNegocio _negocio;

        public AtencionesController(EstiloCordobaNegocio.EstiloCordobaNegocio negocio)
        {
            _negocio = negocio;
        }

        [HttpGet]
        public IActionResult ObtenerAtenciones()
        {
            List<Atencion> atenciones = _negocio.ObtenerAtenciones();
            return Ok(atenciones);
        }

        [HttpGet("barberos/{idBarbero}")]
        public IActionResult ObtenerAtencionesPorBarbero(int idBarbero)
        {
            List<Atencion> atenciones = _negocio.ObtenerAtencionesPorBarbero(idBarbero);
            return Ok(atenciones);
        }

        [HttpGet("atencionesPorEstado/{idEstado}")]
        public IActionResult ObtenerAtencionesPorEstado(int idEstado)
        {
            List<Atencion> atenciones = _negocio.ObtenerAtencionesPorEstado(idEstado);
            return Ok(atenciones);
        }

        [HttpGet("{id}")]
        public IActionResult ObtenerAtencionesPorId(int id)
        {
            Atencion atencion = _negocio.ObtenerAtencionPorId(id);
            return Ok(atencion);
        }

        [HttpPost]
        public IActionResult Registrar([FromBody] Atencion atencion)
        {
            try
            {
                if (_negocio.RegistrarAtencion(atencion))
                {
                    return Ok("Atencion registrada correctamente.");
                }
                else { 
                    return Conflict("El turno seleccionado ya fue registrado en atenciones.");
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

        [HttpPost("cambiarEstado/{idEstado}/{idAtencion}")]
        public IActionResult CambiarEstado(int idEstado, int idAtencion)
            { 

            try
            {
                if (_negocio.CambiarEstadoAtencion(idEstado, idAtencion))
                {
                    return Ok("Estado actualizado correctamente.");
                }
                else
                {
                    return Conflict("Ocurrio un error.(Negocio)");
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

        [HttpPost("CobrarAtencion/{idEstado}/{idAtencion}/{idMedioPago}")]
        public IActionResult CobrarAtencion(int idEstado, int idAtencion, int idMedioPago)
        {
            try
            {
                if (_negocio.CobrarAtencion(idEstado, idAtencion, idMedioPago))
                {
                    return Ok("Atención cobrada correctamente.");
                }
                else
                {
                    return Conflict("Ocurrio un error.(Negocio)");
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


        [HttpPut]
        public IActionResult Actualizar([FromBody] Atencion atencion)
        {
            try
            {
                if (_negocio.ActualizarAtencion(atencion))
                {
                    return Ok("Atención actualizada correctamente.");
                }

                return NotFound("No se encontró la atención.");
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
