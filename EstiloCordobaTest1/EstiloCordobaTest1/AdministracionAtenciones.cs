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
    public partial class AdministracionAtenciones : Form
    {
        private readonly HttpClient _httpClient = new HttpClient()
        {
            BaseAddress = new Uri("https://localhost:7071/")
        };

        Session _usuario = new Session();

        public AdministracionAtenciones(Session session)
        {
            InitializeComponent();
            _usuario = session;
        }

        private async void CargarAtenciones()
        {
            try
            {
                var atenciones = await _httpClient.GetFromJsonAsync<List<Atencion>>("api/atenciones");

                bsAtencion.DataSource = atenciones ?? new List<Atencion>();
                dgvAtencion.DataSource = bsAtencion;
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"No se pudieron cargar las atenciones: {ex.Message}");
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            foreach (Form formulario in this.MdiParent.MdiChildren)
            {
                if (formulario is RegistrarAtencion)
                {
                    formulario.BringToFront();
                    formulario.Activate();
                    return;
                }
            }

            RegistrarAtencion formHijo = new RegistrarAtencion();
            formHijo.MdiParent = this.MdiParent;
            formHijo.Show();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CargarAtenciones();
        }

        private void AdministracionAtenciones_Load(object sender, EventArgs e)
        {

        }

        private void btnFinalizada_Click(object sender, EventArgs e)
        {
            foreach (Form formulario in this.MdiParent.MdiChildren)
            {
                if (formulario is AtencionFinalizadas)
                {
                    formulario.BringToFront();
                    formulario.Activate();
                    return;
                }
            }

            AtencionFinalizadas formHijo = new AtencionFinalizadas();
            formHijo.MdiParent = this.MdiParent;
            formHijo.Show();
        }
    }
}
