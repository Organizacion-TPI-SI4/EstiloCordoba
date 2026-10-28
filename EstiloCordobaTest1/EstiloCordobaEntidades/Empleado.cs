using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EstiloCordobaEntidades
{
    public class Empleado
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Domicilio { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Clave { get; set; } = string.Empty;


        [ForeignKey("Rol")]//EF
        public int IdRol { get; set; }

    }
}
