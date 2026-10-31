using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EstiloCordobaEntidades;
using System.Net.Http.Json;

namespace EstiloCordobaPresentacion
{
    public partial class AdministracionPersonal : Form
    {
        private readonly Session _usuario;
        private static readonly HttpClient cliente = new HttpClient()
        {
            BaseAddress = new Uri("https://localhost:7071/")
        };

        public AdministracionPersonal(Session session)
        {
            InitializeComponent();
            _usuario = session;
        }

        private async Task CargarEmpleadosAsync()
        {
            try
            {
                var empleados = await cliente.GetFromJsonAsync<List<Empleado>>("api/empleados");

                bsEmpleados.DataSource = empleados ?? new List<Empleado>();
                dgvEmpleados.DataSource = bsEmpleados;
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"No se pudieron cargar los empleados: {ex.Message}");
            }
        }

        public async void btnConsultar_Click(object sender, EventArgs e)
        {
            await CargarEmpleadosAsync();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            foreach (Form formulario in this.MdiParent.MdiChildren)
            {
                if (formulario is RegistrarPersonal)
                {
                    formulario.BringToFront();
                    formulario.Activate();
                    return;
                }
            }

            RegistrarPersonal formHijo = new RegistrarPersonal();
            formHijo.MdiParent = this.MdiParent;
            formHijo.Show();
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
