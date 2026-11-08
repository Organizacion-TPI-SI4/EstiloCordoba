using System;
using System.Collections.Generic;
using System.Text;

namespace EstiloCordobaEntidades
{
    public class Turno
    {

        public int id { get; set; }
        public int idUsuario { get; set; }
        public int idCliente { get; set; }
        public DateOnly Fecha { get; set; }
        public TimeOnly Hora { get; set; }

        public List<DetTurno> DetallesTurno { get; set; } = new List<DetTurno>();
        public string ServiciosTexto
        {
            get
            {
                return string.Join(", ",DetallesTurno.Where(d => d.servicio != null).Select(d => d.servicio.Nombre));
            }
        }

        public Empleado? usuario { get; set; }
        public Cliente? cliente { get; set; }

        public string UsuarioNombre => usuario?.Nombre ?? "";
        public string ClienteNombre => cliente?.Nombre ?? "";

        public int asignado { get; set; }
    }
}
