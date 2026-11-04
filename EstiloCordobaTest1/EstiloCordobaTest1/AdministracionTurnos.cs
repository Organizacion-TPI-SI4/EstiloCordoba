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
    public partial class AdministracionTurnos : Form
    {
        private static readonly HttpClient cliente = new HttpClient()
        {
            BaseAddress = new Uri("https://localhost:7071/")
        };

        private readonly Session _usuario;


        public AdministracionTurnos(Session session)
        {
            InitializeComponent();
            _usuario = session;
        }

        private async Task CargarTurnosAsync()
        {
            try
            {
                var turnos = await cliente.GetFromJsonAsync<List<Turno>>("api/turnos");

                bsTurnos.DataSource = turnos ?? new List<Turno>();
                dgvTurnos.DataSource = bsTurnos;
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"No se pudieron cargar los turnos: {ex.Message}");
            }
        }

        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            await CargarTurnosAsync();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            foreach (Form formulario in this.MdiParent.MdiChildren)
            {
                if (formulario is RegistrarTurno)
                {
                    formulario.BringToFront();
                    formulario.Activate();
                    return;
                }
            }

            RegistrarTurno formHijo = new RegistrarTurno(_usuario);
            formHijo.MdiParent = this.MdiParent;
            formHijo.Show();
        }

        private void AdministracionTurnos_Load(object sender, EventArgs e)
        {

        }
    }
}
