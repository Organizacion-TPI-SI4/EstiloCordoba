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
    public partial class AdministracionClientes : Form
    {

        private static readonly HttpClient cliente = new HttpClient()
        {
            BaseAddress = new Uri("https://localhost:7071/")
        };

        public AdministracionClientes(Session session)
        {
            InitializeComponent();
        }

        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            await CargarEmpleadosAsync();
        }

        private async Task CargarEmpleadosAsync()
        {
            try
            {
                var empleados = await cliente.GetFromJsonAsync<List<Cliente>>("api/clientes");

                bsClientes.DataSource = empleados ?? new List<Cliente>();
                dgvClientes.DataSource = bsClientes;
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"No se pudieron cargar los clientes: {ex.Message}");
            }
        }
    }
}
