using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using EstiloCordobaEntidades;
using EstiloCordobaPresentacion;

namespace EstiloCordobaTest1
{
    public partial class IniciarSesion : Form
    {
        private static readonly HttpClient cliente = new HttpClient();

        private const string urlApi = "https://localhost:7071/api/auth/login";

        public IniciarSesion()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            {
                string email = txtEmail.Text.Trim();
                string clave = txtClave.Text;

                if (string.IsNullOrWhiteSpace(email) ||
                    string.IsNullOrEmpty(clave))
                {
                    MessageBox.Show("Ingresá tu email y clave.");
                    return;
                }
                
                var datosLogin = new
                {
                    Email = email,
                    Clave = clave
                };

                try
                {
                    HttpResponseMessage respuesta =
                        await cliente.PostAsJsonAsync(urlApi, datosLogin);

                    string contenido =
                        await respuesta.Content.ReadAsStringAsync();

                    using JsonDocument documento =
                        JsonDocument.Parse(contenido);

                    JsonElement raiz = documento.RootElement;

                    bool exito = raiz.TryGetProperty("exito", out var propiedadExito)
                        && propiedadExito.GetBoolean();

                    string mensaje =
                        raiz.TryGetProperty("mensaje", out var propiedadMensaje)
                            ? propiedadMensaje.GetString() ?? ""
                            : "No se pudo interpretar la respuesta de la API.";

                    if (respuesta.IsSuccessStatusCode && exito)
                    {
                        MessageBox.Show(
                            mensaje,
                            "Login correcto",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        Session _usuario = new Session
                        {
                            IdEmpleado = raiz.GetProperty("idEmpleado").GetInt32(),
                            Nombre = raiz.GetProperty("nombre").GetString() ?? "",
                            IdRol = raiz.GetProperty("idRol").GetInt32()
                        };

                        MenuPrincipal menuPrincipal = new MenuPrincipal(_usuario);

                        menuPrincipal.FormClosed += (s, args) => this.Show();

                        menuPrincipal.Show();

                        txtEmail.Clear();
                        txtClave.Clear();

                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show(
                            mensaje,
                            "Error de inicio de sesión",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
                catch (HttpRequestException)
                {
                    MessageBox.Show(
                        "No se pudo conectar con la API. Verificá que esté ejecutándose.");
                }
                catch (JsonException)
                {
                    MessageBox.Show("La API devolvió una respuesta que no se pudo leer.");
                }
            }
        }
    }
}
