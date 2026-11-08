using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace EstiloCordobaEntidades
{
    public class Estado
    {

        [Key]
        public int id { get; set; }

        public string nombreEstado { get; set; }
    }
}
