using System;
using System.Collections.Generic;
using System.Text;

namespace EstiloCordobaEntidades
{
    public class Cliente
    {

        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string tipoDni { get; set; }

        public int numeroDni { get; set; }

        public string? Telefono { get; set; }

        public string? Email { get; set; }

        public string? localidad { get; set; }

        public string? Red_social { get; set; }




        public int? IdBeneficio { get; set; }
    }
}
