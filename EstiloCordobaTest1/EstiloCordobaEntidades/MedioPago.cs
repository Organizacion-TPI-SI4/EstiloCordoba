using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EstiloCordobaEntidades
{
    public class MedioPago
    {

        [Key]
        public int id { get; set; }
        public required string descripcion { get; set; }
    }
}
