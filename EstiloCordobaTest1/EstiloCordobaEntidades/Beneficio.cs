using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EstiloCordobaEntidades
{
    public class Beneficio
    {
        [Key]
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}
