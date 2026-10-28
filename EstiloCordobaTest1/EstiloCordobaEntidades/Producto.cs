using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EstiloCordobaEntidades
{
    public class Producto
    {

        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Marca { get; set; } = string.Empty;

        public decimal PrecioVenta { get; set; }

    }
}
