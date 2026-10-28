using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EstiloCordobaEntidades
{
    public class Servicio
    {

        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        public string Duracion { get; set; }


        [ForeignKey("Categoria")]//EF]
        public int CategoriaId { get; set; }
    }
}
