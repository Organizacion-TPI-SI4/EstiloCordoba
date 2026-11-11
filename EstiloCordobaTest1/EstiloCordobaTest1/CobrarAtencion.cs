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
    public partial class CobrarAtencion : Form
    {

        HttpClient _httpClient = new HttpClient()
        {
            BaseAddress = new Uri("https://localhost:7071/")
        };

        public CobrarAtencion()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void cmbAtencionCobrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            var atencionSeleccionada = await _httpClient.GetFromJsonAsync<Atencion>($"api/atenciones/{cmbAtencionCobrar.SelectedValue}");

            if(atencionSeleccionada.idEstado == 4)
            {
                btnCobrar.Enabled = true;
            }
            else
            {
                btnCobrar.Enabled = false;
            }

            lblIdAtencion.Text = atencionSeleccionada.id.ToString();
            lblNombreCliente.Text = atencionSeleccionada.Cliente?.Nombre + " " + atencionSeleccionada.Cliente?.Apellido;
            lblTotalCobrar.Text = atencionSeleccionada.totalCalculado.ToString();
        }

        private async void CobrarAtencion_Load(object sender, EventArgs e)
        {
            btnCobrar.Enabled = false;

            var atencionesCobrar = await _httpClient.GetFromJsonAsync<List<Atencion>>($"api/atenciones/atencionesPorEstado/4");
            var mediosPago = await _httpClient.GetFromJsonAsync<List<MedioPago>>($"api/medios");

            dgvAtencionCobrar.DataSource = atencionesCobrar;

            cmbMedioPago.DisplayMember = "descripcion";
            cmbMedioPago.ValueMember = "id";
            cmbMedioPago.DataSource = mediosPago;

            cmbAtencionCobrar.DisplayMember = "Descripcion";
            cmbAtencionCobrar.ValueMember = "id";
            cmbAtencionCobrar.DataSource = atencionesCobrar.Select(a => new { a.id, Descripcion = "ID Atencion: " + a.id + " - Cliente: " + a.Cliente?.Nombre + " " + a.Cliente?.Apellido }).ToList();
        }

        private async void btnCobrar_Click(object sender, EventArgs e)
        {
            var Mensaje = MessageBox.Show("¿Está seguro que desea cobrar la atención?", "Confirmar Cobro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Mensaje == DialogResult.Yes)
            {
                var atencionSeleccionada = await _httpClient.GetFromJsonAsync<Atencion>($"api/atenciones/{cmbAtencionCobrar.SelectedValue}");

                var response = _httpClient.PostAsJsonAsync($"api/atenciones/CobrarAtencion/5/{atencionSeleccionada.id}/{cmbMedioPago.SelectedValue}", new { });


                if (response.Result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Atención cobrada correctamente.", "Cobro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al cobrar la atención.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
