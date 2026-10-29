using EstiloCordobaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Http.Json;

namespace EstiloCordobaPresentacion
{
    public partial class AdministracionCategorias : Form
    {

        private readonly HttpClient _httpClient = new HttpClient();
        private readonly Session _usuario;
        public AdministracionCategorias(Session session)
        {
            InitializeComponent();

            _usuario = session;

            dgvCategorias.DataSource = bsCategorias;

            CargarCategoriasAsync();
        }

        private async Task CargarCategoriasAsync()
        {
            try
            {
                var categorias = await _httpClient.GetFromJsonAsync<List<Categoria>>(
                    "https://localhost:7071/api/categorias");

                bsCategorias.DataSource = categorias ?? new List<Categoria>();
                dgvCategorias.DataSource = bsCategorias;
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"No se pudieron cargar las categorías: {ex.Message}");
            }
        }

        private void AdministracionCategorias_Load(object sender, EventArgs e)
        {

            if (_usuario.IdRol == 2)
            {
                btnRegistrar.Enabled = false;
                btnModificar.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarCategoriasAsync();
        }
    }
}
