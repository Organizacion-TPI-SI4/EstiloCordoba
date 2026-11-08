using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace EstiloCordobaEntidades
{
    public class DetAtencion
    {

        [Key]
        public int id { get; set; }

        public int idAtencion { get; set; }

        public int idProducto { get; set; }

        public int cantidad { get; set; }



        [NotMapped][JsonIgnore]
        public Atencion? atencion { get; set; }

        public Producto? producto { get; set; }


    }
}
