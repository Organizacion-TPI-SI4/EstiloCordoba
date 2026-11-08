using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        public int Stock { get; set; }

        [NotMapped]
        public int Cantidad { get; set; }

        [NotMapped]
        public decimal Subtotal { get; set; }
    }
}
