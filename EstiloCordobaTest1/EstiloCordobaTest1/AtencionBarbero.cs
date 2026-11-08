using EstiloCordobaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http.Json;
using System.Text;
using System.Windows.Forms;

namespace EstiloCordobaPresentacion
{
    public partial class AtencionBarbero : Form
    {
        private readonly HttpClient _httpClient = new HttpClient()
        {
            BaseAddress = new Uri("https://localhost:7071/")
        };

        Session _usuario = new Session();

        private BindingList<Servicio> serviciosSeleccionados = new BindingList<Servicio>();

        public AtencionBarbero(Session session)
        {
            InitializeComponent();

            _usuario = session;

            btnIniciar.Enabled = false;
            btnFinalizar.Enabled = false;
        }

        private async void CargarAtencionesPorIdBarbero(int id)
        {
            try
            {
                var atenciones = await _httpClient.GetFromJsonAsync<List<Atencion>>($"api/atenciones/barberos/{id}");

                bsAtencionAsignada.DataSource = atenciones ?? new List<Atencion>();
                dgvAtencionAsignada.DataSource = bsAtencionAsignada;


                cmbAtencionAsignada.DisplayMember = "Descripcion";
                cmbAtencionAsignada.ValueMember = "id";
                cmbAtencionAsignada.DataSource = atenciones.Select(a => new { a.id, Descripcion = "ID Atencion: " + a.id + " - Cliente: " + a.Cliente?.Nombre + " " + a.Cliente?.Apellido }).ToList();
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"No se pudieron cargar las atenciones: {ex.Message}");
            }
        }

        private async void cmbAtencionAsignada_SelectedIndexChanged(object sender, EventArgs e)
        {
            serviciosSeleccionados.Clear();

            var atencionPorId = await _httpClient.GetFromJsonAsync<Atencion>($"api/atenciones/{cmbAtencionAsignada.SelectedValue}");

            var estado = await _httpClient.GetFromJsonAsync<Estado>($"api/estados/{atencionPorId.idEstado}");

            lblEstadoAtencion.Text = estado.nombreEstado;
            lblNombreCliente.Text = atencionPorId.Cliente?.Nombre + " " + atencionPorId.Cliente?.Apellido;
            lblIdAtencion.Text = atencionPorId.id.ToString();


            int id = atencionPorId.idTurno;
            var detallesTurno = await _httpClient.GetFromJsonAsync<List<DetTurno>>($"api/detturnos/{id}");
            dgvServicioSolicitado.DataSource = serviciosSeleccionados;

            foreach (var detalle in detallesTurno)
            {
                var servicio = await _httpClient.GetFromJsonAsync<Servicio>($"api/servicios/{detalle.idServicio}");
                if (servicio != null)
                {
                    serviciosSeleccionados.Add(servicio);
                }
            }

            if(atencionPorId.idEstado == 1)
            {
                btnIniciar.Enabled = true;
                btnFinalizar.Enabled = false;
            }
            else if (atencionPorId.idEstado == 2)
            {
                btnIniciar.Enabled = false;
                btnFinalizar.Enabled = true;
            }
            else
            {
                btnIniciar.Enabled = false;
                btnFinalizar.Enabled = false;
            }
        }

        private async void btnIniciar_Click(object sender, EventArgs e)
        {
            var atencionPorId = await _httpClient.GetFromJsonAsync<Atencion>($"api/atenciones/{cmbAtencionAsignada.SelectedValue}");

            if (atencionPorId.idEstado != 1)
            {
                MessageBox.Show("Solo puede iniciar una atencion en estado 'Registrada'.");
                return;
            }

            var respuesta = await _httpClient.PostAsync($"api/atenciones/cambiarEstado/{atencionPorId.idEstado}/{atencionPorId.id}", null);

            if (respuesta.IsSuccessStatusCode)
            {
                MessageBox.Show("Estado actualizado.");
            }
            else
            {
                string error = await respuesta.Content.ReadAsStringAsync();
                MessageBox.Show(error);
            }
            CargarAtencionesPorIdBarbero(_usuario.IdEmpleado);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private async void btnFinalizar_Click(object sender, EventArgs e)
        {
            var atencionPorId = await _httpClient.GetFromJsonAsync<Atencion>($"api/atenciones/{cmbAtencionAsignada.SelectedValue}");

            if (atencionPorId.idEstado != 2)
            {
                MessageBox.Show("Solo puede finalizar una atencion en estado 'Iniciada'.");
                return;
            }

            var respuesta = await _httpClient.PostAsync($"api/atenciones/cambiarEstado/{atencionPorId.idEstado}/{atencionPorId.id}", null);

            if (respuesta.IsSuccessStatusCode)
            {
                MessageBox.Show("Estado actualizado.");
            }
            else
            {
                string error = await respuesta.Content.ReadAsStringAsync();
                MessageBox.Show(error);
            }

            CargarAtencionesPorIdBarbero(_usuario.IdEmpleado);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CargarAtencionesPorIdBarbero(_usuario.IdEmpleado);
        }
    }
}
