using EstiloCordobaEntidades;
using System.Net.Http.Json;

namespace EstiloCordobaPresentacion
{
    public partial class AdministracionProductos : Form
    {
        private static readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("http://localhost:5078/")
        };

        private readonly Session _usuario;

        public AdministracionProductos(Session session)
        {
            InitializeComponent();

            _usuario = session;

            Load += AdministracionProductos_Load;
            btnConsultar.Click += btnConsultar_Click;
            btnRegistrar.Click += btnRegistrar_Click;
        }

        private async void AdministracionProductos_Load(
            object? sender,
            EventArgs e)
        {
            // Solamente el administrador puede registrar productos.
            if (_usuario.IdRol != 1)
            {
                btnRegistrar.Enabled = false;
            }

            // Esta funcionalidad se implementará en PE-16.
            btnModificar.Enabled = false;

            await CargarProductosAsync();
        }

        private async Task CargarProductosAsync()
        {
            try
            {
                btnConsultar.Enabled = false;

                List<Producto>? productos =
                    await _httpClient.GetFromJsonAsync<List<Producto>>(
                        "api/productos");

                dgvProductos.DataSource = null;
                dgvProductos.DataSource =
                    productos ?? new List<Producto>();
            }
            catch (HttpRequestException)
            {
                MessageBox.Show(
                    "No se pudieron cargar los productos. " +
                    "Verificá que la API esté ejecutándose.",
                    "Error de conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                btnConsultar.Enabled = true;
            }
        }

        private async void btnConsultar_Click(
            object? sender,
            EventArgs e)
        {
            await CargarProductosAsync();
        }

        private async void btnRegistrar_Click(
            object? sender,
            EventArgs e)
        {
            if (MdiParent != null)
            {
                foreach (Form formulario in MdiParent.MdiChildren)
                {
                    if (formulario is RegistrarProducto)
                    {
                        formulario.BringToFront();
                        formulario.Activate();
                        return;
                    }
                }

                RegistrarProducto formularioRegistro =
                    new RegistrarProducto();

                formularioRegistro.MdiParent = MdiParent;

                formularioRegistro.FormClosed += async (_, _) =>
                {
                    await CargarProductosAsync();
                };

                formularioRegistro.Show();
            }
            else
            {
                using RegistrarProducto formularioRegistro =
                    new RegistrarProducto();

                formularioRegistro.ShowDialog(this);
                await CargarProductosAsync();
            }
        }
    }
}