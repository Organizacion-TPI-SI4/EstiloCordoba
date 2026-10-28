namespace APIEstiloCordoba.DTOs
{
    public class LoginResponse
    {
        public bool Exito { get; set; }

        public string Mensaje { get; set; } = string.Empty;

        public int? IdEmpleado { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public int? IdRol { get; set; }
    }
}
