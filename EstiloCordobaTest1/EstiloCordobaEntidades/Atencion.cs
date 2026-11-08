using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Text;

namespace EstiloCordobaEntidades
{
    public class Atencion
    {

        [Key]
        public int id { get; set; }
        
        public DateOnly fecha { get; set; }

        public TimeOnly hora { get; set; }

        public decimal? totalCalculado { get; set; }

        public decimal totalServicios { get; set; }

        public decimal? totalProductos { get; set; }

        public int? idBarbero { get; set; }

        public int idCliente { get; set; }

        public int idTurno { get; set; }

        public int idEstado { get; set; }

        public int? idMedioPago { get; set; }


        [ForeignKey("idCliente")]
        public Cliente? Cliente { get; set; } = null!;

        [ForeignKey("idTurno")]
        public Turno? Turno { get; set; } = null!;


        [ForeignKey("idEstado")]
        public Estado? Estado { get; set; } = null!;

        [ForeignKey("idBarbero")]
        public Empleado? Empleado { get; set; } = null!;


        public List<DetAtencion> DetallesAtencion { get; set; } = new List<DetAtencion>();
    }
}
