using EstiloCordobaEntidades;
using System.Net.Http.Json;
using System.Text.Json;

namespace EstiloCordobaPresentacion
{
    public partial class RegistrarProducto : Form
    {
        private static readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("http://localhost:5078/")
        };

        private readonly Producto? _productoModificar;

        private bool EsModificacion =>
            _productoModificar != null;

        // Constructor utilizado para registrar.
        public RegistrarProducto()
        {
            InitializeComponent();

            btnRegistrar.Click += btnRegistrar_Click;
            btnCancelar.Click += btnCancelar_Click;
        }

        // Constructor utilizado para modificar.
        public RegistrarProducto(Producto producto) : this()
        {
            _productoModificar = producto;

            Text = "Modificar producto";
            btnRegistrar.Text = "Guardar cambios";
            lblTitulo.Text = "Modificar producto";
            txtNombre.Text = producto.Nombre;
            txtMarca.Text = producto.Marca;
            nudPrecioVenta.Value = producto.PrecioVenta;
            nudStock.Value = producto.Stock;
        }

        private async void btnRegistrar_Click(
            object? sender,
            EventArgs e)
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
                Id = _productoModificar?.Id ?? 0,
                Nombre = nombre,
                Marca = marca,
                PrecioVenta = nudPrecioVenta.Value,
                Stock = Decimal.ToInt32(nudStock.Value)
            };

            try
            {
                btnRegistrar.Enabled = false;

                HttpResponseMessage respuesta;

                if (EsModificacion)
                {
                    respuesta = await _httpClient.PutAsJsonAsync(
                        $"api/productos/{producto.Id}",
                        producto);
                }
                else
                {
                    respuesta = await _httpClient.PostAsJsonAsync(
                        "api/productos",
                        producto);
                }

                if (respuesta.IsSuccessStatusCode)
                {
                    string mensaje = EsModificacion
                        ? "Producto modificado correctamente."
                        : "Producto registrado correctamente.";

                    string titulo = EsModificacion
                        ? "Modificación exitosa"
                        : "Registro exitoso";

                    MessageBox.Show(
                        mensaje,
                        titulo,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    if (EsModificacion)
                    {
                        Close();
                        return;
                    }

                    LimpiarCampos();
                }
                else
                {
                    string contenido =
                        await respuesta.Content.ReadAsStringAsync();

                    string error =
                        ObtenerMensajeError(contenido);

                    MessageBox.Show(
                        error,
                        "No se pudo guardar el producto",
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
                if (!IsDisposed)
                {
                    btnRegistrar.Enabled = true;
                }
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtMarca.Clear();
            nudPrecioVenta.Value = 0;
            nudStock.Value = 0;
            txtNombre.Focus();
        }

        private static string ObtenerMensajeError(
            string contenido)
        {
            try
            {
                using JsonDocument documento =
                    JsonDocument.Parse(contenido);

                JsonElement raiz = documento.RootElement;

                if (raiz.ValueKind == JsonValueKind.String)
                {
                    return raiz.GetString() ??
                        "No se pudo guardar el producto.";
                }

                if (raiz.ValueKind == JsonValueKind.Object &&
                    raiz.TryGetProperty(
                        "mensaje",
                        out JsonElement mensaje))
                {
                    return mensaje.GetString() ??
                        "No se pudo guardar el producto.";
                }
            }
            catch (JsonException)
            {
                // La respuesta no estaba en formato JSON.
            }

            return contenido;
        }

        private void btnCancelar_Click(
            object? sender,
            EventArgs e)
        {
            Close();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
