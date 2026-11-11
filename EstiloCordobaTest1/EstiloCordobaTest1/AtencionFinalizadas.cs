using EstiloCordobaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http.Json;
using System.Text;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EstiloCordobaPresentacion
{
    public partial class AtencionFinalizadas : Form
    {
        private readonly HttpClient _httpClient = new HttpClient()
        {
            BaseAddress = new Uri("https://localhost:7071/")
        };

        private BindingList<Servicio> serviciosRealizados = new BindingList<Servicio>();

        private BindingList<Producto> ProductosSeleccionados = new BindingList<Producto>();

        public AtencionFinalizadas()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private async void AtencionFinalizadas_Load(object sender, EventArgs e)
        {
            CargarAtencionesFinalizadas();

            var productos = await _httpClient.GetFromJsonAsync<List<Producto>>($"api/productos");

            cmbProductos.DisplayMember = "Descripcion";
            cmbProductos.ValueMember = "Id";
            cmbProductos.DataSource = productos.Select(a => new { a.Id, Descripcion = a.Nombre + " " + a.Marca + " " + a.PrecioVenta }).ToList();
        }

        private async void CargarAtencionesFinalizadas()
        {
            try
            {
                var atencionesFinalizadas = await _httpClient.GetFromJsonAsync<List<Atencion>>("api/atenciones/atencionesPorEstado/3");
                bsAtencionFinalizada.DataSource = atencionesFinalizadas ?? new List<Atencion>();
                dgvAtencionFinalizada.DataSource = bsAtencionFinalizada;

                cmbAtencionFinalizada.DisplayMember = "Descripcion";
                cmbAtencionFinalizada.ValueMember = "id";
                cmbAtencionFinalizada.DataSource = atencionesFinalizadas.Select(a => new { a.id, Descripcion = "ID Atencion: " + a.id + " - Cliente: " + a.Cliente?.Nombre + " " + a.Cliente?.Apellido }).ToList();
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"No se pudieron cargar las atenciones finalizadas: {ex.Message}");
            }
        }

        private async void cmbAtencionFinalizada_SelectedIndexChanged(object sender, EventArgs e)
        {
            serviciosRealizados.Clear();
            ProductosSeleccionados.Clear();
            lblTotalAtencion.Text = "$ 0";

            var atencionPorId = await _httpClient.GetFromJsonAsync<Atencion>($"api/atenciones/{cmbAtencionFinalizada.SelectedValue}");

            lblEstadoAtencion.Text = atencionPorId.Estado.nombreEstado;
            lblIdAtencion.Text = atencionPorId.id.ToString();
            lblNombreCliente.Text = atencionPorId.Cliente.Nombre + " " + atencionPorId.Cliente.Apellido;
            lblNombreBarbero.Text = atencionPorId.Empleado.Nombre;
            lblFecha.Text = atencionPorId.fecha.ToString();
            lblHora.Text = atencionPorId.hora.ToString();

            int id = atencionPorId.idTurno;
            var detallesTurno = await _httpClient.GetFromJsonAsync<List<DetTurno>>($"api/detturnos/{id}");
            dgvServicioRealizado.DataSource = serviciosRealizados;

            foreach (var detalle in detallesTurno)
            {
                var servicio = await _httpClient.GetFromJsonAsync<Servicio>($"api/servicios/{detalle.idServicio}");
                if (servicio != null)
                {
                    serviciosRealizados.Add(servicio);
                }
            }

            lblSubtotalServicio.Text = atencionPorId.totalServicios.ToString();



            gbProductos.Enabled = true;
            lblTotalAtencion.Text = atencionPorId.totalServicios.ToString();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            var productoPorId = await _httpClient.GetFromJsonAsync<Producto>($"api/productos/productoPorId/{cmbProductos.SelectedValue}");
            dgvProductos.DataSource = ProductosSeleccionados;

            if (ProductosSeleccionados.Any(p => p.Id == productoPorId.Id))
            {
                MessageBox.Show("Este producto ya fue agregado.");
                return;
            }
            productoPorId.Cantidad = (int)numeroCantidad.Value;
            productoPorId.Subtotal = (int)numeroCantidad.Value * productoPorId.PrecioVenta;
            ProductosSeleccionados.Add(productoPorId);

            lblSubtotalAtencion.Text = ProductosSeleccionados.Sum(p => p.Subtotal).ToString();

            decimal totalAtencion = decimal.Parse(lblTotalAtencion.Text) + productoPorId.Subtotal;


            lblTotalAtencion.Text = totalAtencion.ToString();
        }

        private void lblSubtotalAtencion_Click(object sender, EventArgs e)
        {

        }

        private async void btnConfirmar_Click(object sender, EventArgs e)
        {
            decimal totalAtencion = decimal.Parse(lblTotalAtencion.Text);
            decimal totalProductos = decimal.Parse(lblSubtotalAtencion.Text);
            int idAtencion = (int)cmbAtencionFinalizada.SelectedValue;

            List<DetAtencion> detalles = new List<DetAtencion>();

            foreach (Producto producto in ProductosSeleccionados)
            {
                DetAtencion detalle = new DetAtencion
                {
                    idProducto = producto.Id,
                    idAtencion = idAtencion,
                    cantidad = producto.Cantidad
                }; 

                detalles.Add(detalle);
            }



            Atencion modificada = new Atencion
            {
                id = idAtencion,
                totalCalculado = totalAtencion,
                totalProductos = totalProductos,
                idEstado = 4,

                DetallesAtencion = detalles
            };



            HttpResponseMessage respuesta = await _httpClient.PutAsJsonAsync("api/atenciones",modificada);

            if (respuesta.IsSuccessStatusCode)
            {
                MessageBox.Show("Atención actualizada correctamente.");
            }
            else
            {
                string error = await respuesta.Content.ReadAsStringAsync();
                MessageBox.Show(error);
            }
        }   
    }
}
