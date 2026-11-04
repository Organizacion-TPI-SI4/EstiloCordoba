using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace EstiloCordobaEntidades
{
    public class DetTurno
    {

        [Key]
        public int id { get; set; }

        public int idTurnoPadre { get; set; }

        public int idServicio { get; set; }

        [JsonIgnore]
        public Turno? turno { get; set; }

        public Servicio? servicio { get; set; }
    }
}
