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
    public partial class RegistrarTurno : Form
    {

        private BindingList<Servicio> serviciosSeleccionados = new BindingList<Servicio>();

        private readonly HttpClient _httpClient = new HttpClient()
        {
            BaseAddress = new Uri("https://localhost:7071/")
        };

        private readonly Session _usuario;


        public RegistrarTurno(Session session)
        {
            InitializeComponent();
            _usuario = session;
        }

        private async void RegistrarTurno_Load(object sender, EventArgs e)
        {
            await CargarServicios();
            await CargarClientes();

            dgvServicios.DataSource = serviciosSeleccionados;
        }
        private async Task CargarServicios()
        {
            var servicios = await _httpClient.GetFromJsonAsync<List<Servicio>>("api/servicios");

            cmbServicio.DataSource = servicios;
            cmbServicio.DisplayMember = "Nombre";
            cmbServicio.ValueMember = "Id";
        }

        private async Task CargarClientes()
        {
            var clientes = await _httpClient.GetFromJsonAsync<List<Cliente>>("api/clientes");

            cmbCliente.DataSource = clientes;
            cmbCliente.DisplayMember = "Nombre";
            cmbCliente.ValueMember = "Id";
        }

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            if (cmbServicio.SelectedItem == null)
            {
                MessageBox.Show("Seleccioná un servicio.");
                return;
            }

            Servicio servicio = (Servicio)cmbServicio.SelectedItem;

            if (serviciosSeleccionados.Any(s => s.Id == servicio.Id))
            {
                MessageBox.Show("Este servicio ya fue agregado.");
                return;
            }

            serviciosSeleccionados.Add(servicio);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            foreach (Form formulario in this.MdiParent.MdiChildren)
            {
                if (formulario is RegistrarCliente)
                {
                    formulario.BringToFront();
                    formulario.Activate();
                    return;
                }
            }

            RegistrarCliente formHijo = new RegistrarCliente();
            formHijo.MdiParent = this.MdiParent;
            formHijo.Show();
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            await CargarClientes();
        }

        private async void btnRegistrar_Click(object sender, EventArgs e)
        {
            List<DetTurno> detalles = new List<DetTurno>();

            foreach (Servicio servicio in serviciosSeleccionados)
            {
                DetTurno detalle = new DetTurno
                {
                    idServicio = servicio.Id
                };

                detalles.Add(detalle);
            }


            Turno nuevoTurno = new Turno()
            {
                idUsuario = _usuario.IdEmpleado,
                idCliente = ((Cliente)cmbCliente.SelectedItem).Id,
                Fecha = DateOnly.FromDateTime(dtpFecha.Value.Date),
                DetallesTurno = detalles
            };

            if (TimeOnly.TryParse(txtHora.Text, out TimeOnly hora))
            {
                nuevoTurno.Hora = hora;
            }
            else
            {
                MessageBox.Show("Ingresá una hora válida (HH:mm).");
                return;
            }

            HttpResponseMessage respuesta = await _httpClient.PostAsJsonAsync("api/turnos", nuevoTurno);

            if (respuesta.IsSuccessStatusCode)
            {
                MessageBox.Show("Turno registrado correctamente.");

                cmbCliente.SelectedIndex = 1;
                cmbServicio.SelectedIndex = 1;
                txtHora.Clear();
                dtpFecha.Value = DateTime.Now;
                serviciosSeleccionados.Clear();
                dgvServicios.DataSource = serviciosSeleccionados;
            }
            else
            {
                string error = await respuesta.Content.ReadAsStringAsync();
                MessageBox.Show(error);
            }
        }
    }
}
