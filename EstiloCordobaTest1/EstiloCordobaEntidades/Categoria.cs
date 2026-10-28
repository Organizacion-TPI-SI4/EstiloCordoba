using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EstiloCordobaEntidades
{
    public class Categoria
    {

        [Key]
        public int Id { get; set; }

        public string descripcion { get; set; } = string.Empty;
    }
}
