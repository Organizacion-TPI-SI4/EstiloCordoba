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
    public partial class RegistrarAtencion : Form
    {

        private readonly HttpClient _httpClient = new HttpClient()
        {
            BaseAddress = new Uri("https://localhost:7071/")
        };

        Atencion nuevaAtencion = new Atencion();

        private bool turnoSeleccionado = false;

        private BindingList<Servicio> serviciosSeleccionados = new BindingList<Servicio>();

        public RegistrarAtencion()
        {
            InitializeComponent();
        }


        private async Task CargarTurnos()
        {

            var turnos = await _httpClient.GetFromJsonAsync<List<Turno>>("api/turnos/noasignados");

            if (turnos == null || turnos.Count == 0)
            {
                cmbTurno.DataSource = null;
                btnAceptar.Enabled = false;
                MessageBox.Show("No hay turnos disponibles.");
                return;
            }

            cmbTurno.DataSource = turnos.Select(t => new { t.id, Descripcion = $"Cliente: {t.ClienteNombre} - Id Turno: {t.id}" }).ToList();

            cmbTurno.DisplayMember = "Descripcion";
            cmbTurno.ValueMember = "Id";
        }

        private async Task CargarBarberos()
        {
            try
            {
                var barberos = await _httpClient.GetFromJsonAsync<List<Empleado>>("api/empleados/barberos");

                if (barberos == null || barberos.Count == 0)
                {
                    cmbBarbero.DataSource = null;
                    btnRegistrar.Enabled = false;
                    btnAceptar.Enabled = false;

                    MessageBox.Show("No hay barberos disponibles.");
                    return;
                }

                cmbBarbero.DataSource = barberos.Select(b => new
                {
                    b.Id,
                    Descripcion = $"Barbero: {b.Nombre} - Id Barbero: {b.Id}"
                }).ToList();

                cmbBarbero.DisplayMember = "Descripcion";
                cmbBarbero.ValueMember = "Id";
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("Error al cargar los barberos: " + ex.Message);
                btnRegistrar.Enabled = false;
            }
        }


        private void cmbTurno_SelectedIndexChanged(object sender, EventArgs e)
        {
            serviciosSeleccionados.Clear();
            txtIdCliente.Clear();
            txtNombreCliente.Clear();
            txtHorario.Clear();
            txtFechaPact.Clear();
            txtTotalServicio.Clear();

            turnoSeleccionado = false;
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            int id = (int)cmbTurno.SelectedValue;

            try
            {
                Turno turno = await _httpClient.GetFromJsonAsync<Turno>($"api/turnos/{id}");

                if (turno != null)
                {
                    txtIdCliente.Text = turno.idCliente.ToString();
                    txtNombreCliente.Text = turno.ClienteNombre;
                    txtHorario.Text = turno.Hora.ToString();
                    txtFechaPact.Text = turno.Fecha.ToString("dd/MM/yyyy");

                    var detallesTurno = await _httpClient.GetFromJsonAsync<List<DetTurno>>($"api/detturnos/{id}");
                    dgvServiciosTurno.DataSource = serviciosSeleccionados;

                    foreach (var detalle in detallesTurno)
                    {
                        var servicio = await _httpClient.GetFromJsonAsync<Servicio>($"api/servicios/{detalle.idServicio}");
                        if (servicio != null)
                        {
                            serviciosSeleccionados.Add(servicio);
                        }
                    }

                    //Calcula el precio total de los servicios seleccionados.
                    decimal totalServicio = 0;
                    foreach (var servicio in serviciosSeleccionados)
                    {
                        totalServicio = totalServicio + servicio.Precio;
                    }

                    txtTotalServicio.Text = totalServicio.ToString();

                    nuevaAtencion.idTurno = turno.id;
                    nuevaAtencion.idCliente = turno.idCliente;
                    nuevaAtencion.fecha = DateOnly.FromDateTime(DateTime.Now);
                    nuevaAtencion.hora = TimeOnly.FromDateTime(DateTime.Now);
                    nuevaAtencion.hora = nuevaAtencion.hora.Add(TimeSpan.FromSeconds(-nuevaAtencion.hora.Second));
                    nuevaAtencion.idEstado = 1;
                    nuevaAtencion.totalServicios = Convert.ToDecimal(txtTotalServicio.Text);

                    if(cmbBarbero.SelectedValue != null) {
                        nuevaAtencion.idBarbero = (int)cmbBarbero.SelectedValue;
                    }
                    else { 
                        MessageBox.Show("No hay barberos disponibles.", "Aviso");
                        serviciosSeleccionados.Clear();
                        dgvServiciosTurno.DataSource = serviciosSeleccionados;
                    }

                    turnoSeleccionado = true;
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("Error al obtener el turno: " + ex.Message);
            }
        }

        private async void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (cmbBarbero.SelectedValue == null)
            {
                MessageBox.Show("No hay ningún barbero disponible para asignar.");
                return;
            }


            if (!turnoSeleccionado)
            {
                MessageBox.Show("Debe seleccionar un turno.");
                return;
            }

            try
            {
                HttpResponseMessage respuesta = await _httpClient.PostAsJsonAsync("api/atenciones", nuevaAtencion);

                if (respuesta.IsSuccessStatusCode)
                {
                    MessageBox.Show("Atención registrada correctamente.");

                    turnoSeleccionado = false;
                    nuevaAtencion = new Atencion();
                    serviciosSeleccionados.Clear();
                }
                else
                {
                    string error = await respuesta.Content.ReadAsStringAsync();
                    MessageBox.Show("No se pudo registrar la atención: " + error);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RegistrarAtencion_Load(object sender, EventArgs e)
        {
            CargarTurnos();
            CargarBarberos();
        }
    }
}
