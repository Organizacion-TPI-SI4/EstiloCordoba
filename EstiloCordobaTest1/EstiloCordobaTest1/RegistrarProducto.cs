using EstiloCordobaEntidades;
using System.Net.Http.Json;

namespace EstiloCordobaPresentacion
{
    public partial class RegistrarProducto : Form
    {
        private static readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("http://localhost:5078/")
        };

        public RegistrarProducto()
        {
            InitializeComponent();

            btnRegistrar.Click += btnRegistrar_Click;
            btnCancelar.Click += btnCancelar_Click;
        }

        private async void btnRegistrar_Click(object? sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string marca = txtMarca.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show(
                    "Ingresá el nombre del producto.",
                    "Dato obligatorio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNombre.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(marca))
            {
                MessageBox.Show(
                    "Ingresá la marca del producto.",
                    "Dato obligatorio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtMarca.Focus();
                return;
            }

            if (nudPrecioVenta.Value <= 0)
            {
                MessageBox.Show(
                    "El precio de venta debe ser mayor a cero.",
                    "Precio inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                nudPrecioVenta.Focus();
                return;
            }

            Producto producto = new()
            {
                Nombre = nombre,
                Marca = marca,
                PrecioVenta = nudPrecioVenta.Value,
                Stock = Decimal.ToInt32(nudStock.Value)
            };

            try
            {
                btnRegistrar.Enabled = false;

                HttpResponseMessage respuesta =
                    await _httpClient.PostAsJsonAsync(
                        "api/productos",
                        producto);

                if (respuesta.IsSuccessStatusCode)
                {
                    MessageBox.Show(
                        "Producto registrado correctamente.",
                        "Registro exitoso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    txtNombre.Clear();
                    txtMarca.Clear();
                    nudPrecioVenta.Value = 0;
                    nudStock.Value = 0;
                    txtNombre.Focus();
                }
                else
                {
                    string error =
                        await respuesta.Content.ReadAsStringAsync();

                    MessageBox.Show(
                        "No se pudo registrar el producto: " + error,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (HttpRequestException)
            {
                MessageBox.Show(
                    "No se pudo conectar con la API.",
                    "Error de conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                btnRegistrar.Enabled = true;
            }
        }

        private void btnCancelar_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}
