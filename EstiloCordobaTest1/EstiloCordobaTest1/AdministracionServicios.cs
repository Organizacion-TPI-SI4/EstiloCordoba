using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http.Json;
using System.Text;
using System.Windows.Forms;
using EstiloCordobaEntidades;

namespace EstiloCordobaPresentacion
{
    public partial class AdministracionServicios : Form
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private readonly Session _usuario;
        public AdministracionServicios(Session session)
        {
            InitializeComponent();

            _usuario = session;

            dgvServicios.DataSource = bsServicios;

            CargarServiciosAsync();
        }

        private void AdministracionServicios_Load(object sender, EventArgs e)
        {
            if (_usuario.IdRol == 2)
            {
                btnRegistrar.Enabled = false;
                btnModificar.Enabled = false;
            }
        }

        private async Task CargarServiciosAsync()
        {
            try
            {
                var servicios = await _httpClient.GetFromJsonAsync<List<Servicio>>(
                    "https://localhost:7071/api/servicios");

                bsServicios.DataSource = servicios ?? new List<Servicio>();
                dgvServicios.DataSource = bsServicios;
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"No se pudieron cargar los servicios: {ex.Message}");
            }
        }



        private void dgvServicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CargarServiciosAsync();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            foreach (Form formulario in this.MdiParent.MdiChildren)
            {
                if (formulario is RegistrarServicio)
                {
                    formulario.BringToFront();
                    formulario.Activate();
                    return;
                }
            }

            RegistrarServicio formHijo = new RegistrarServicio();
            formHijo.MdiParent = this.MdiParent;
            formHijo.Show();
        }
    }
}
