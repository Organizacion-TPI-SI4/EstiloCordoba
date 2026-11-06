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
            btnModificar.Click += btnModificar_Click;

            dgvProductos.SelectionChanged +=
                dgvProductos_SelectionChanged;
        }

        private async void AdministracionProductos_Load(
            object? sender,
            EventArgs e)
        {
            bool esAdministrador = _usuario.IdRol == 1;

            btnRegistrar.Enabled = esAdministrador;
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

                dgvProductos.ClearSelection();
                dgvProductos.CurrentCell = null;

                ActualizarEstadoBotonModificar();
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

        private void dgvProductos_SelectionChanged(
            object? sender,
            EventArgs e)
        {
            ActualizarEstadoBotonModificar();
        }

        private void ActualizarEstadoBotonModificar()
        {
            bool hayProductoSeleccionado =
                dgvProductos.SelectedCells.Count > 0 &&
                dgvProductos.CurrentRow?.DataBoundItem is Producto;

            btnModificar.Enabled =
                _usuario.IdRol == 1 &&
                hayProductoSeleccionado;
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

        private async void btnModificar_Click(
            object? sender,
            EventArgs e)
        {
            if (_usuario.IdRol != 1)
            {
                MessageBox.Show(
                    "Solamente un administrador puede " +
                    "modificar productos.",
                    "Acceso restringido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (dgvProductos.SelectedCells.Count == 0 ||
                dgvProductos.CurrentRow?.DataBoundItem
                    is not Producto productoSeleccionado)
            {
                MessageBox.Show(
                    "Seleccioná un producto para modificar.",
                    "Producto no seleccionado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (MdiParent != null)
            {
                RegistrarProducto formularioModificacion =
                    new RegistrarProducto(productoSeleccionado);

                formularioModificacion.MdiParent = MdiParent;

                formularioModificacion.FormClosed += async (_, _) =>
                {
                    await CargarProductosAsync();
                };

                formularioModificacion.Show();
            }
            else
            {
                using RegistrarProducto formularioModificacion =
                    new RegistrarProducto(productoSeleccionado);

                formularioModificacion.ShowDialog(this);
                await CargarProductosAsync();
            }
        }
    }
}