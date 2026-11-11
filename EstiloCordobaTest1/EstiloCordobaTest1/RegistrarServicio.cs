using System.Net.Http.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using EstiloCordobaEntidades;

namespace EstiloCordobaPresentacion
{
    public partial class RegistrarServicio : Form
    {

        private readonly HttpClient _httpClient = new HttpClient()
        {
            BaseAddress = new Uri("https://localhost:7071/")
        };


        public RegistrarServicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void RegistrarServicio_Load(object sender, EventArgs e)
        {
            await CargarCategorias();
        }

        private async Task CargarCategorias()
        {
            var categorias = await _httpClient.GetFromJsonAsync<List<Categoria>>("api/categorias");

            cmbCategoria.DataSource = categorias;
            cmbCategoria.DisplayMember = "Descripcion";
            cmbCategoria.ValueMember = "Id";
        }

        private async void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                if (numericUD1.Value > 0)
                {
                    if (decimal.TryParse(txtPrecio.Text, out decimal precio))
                    {
                        if(precio<0)
                        {
                            MessageBox.Show("El precio no puede ser negativo.");
                            return;
                        }
                        if (cmbCategoria.SelectedValue == null)
                        {
                            MessageBox.Show("Seleccioná una categoría.");
                            return;
                        }
                        else
                        {
                            int idCategoria = (int)cmbCategoria.SelectedValue;
                            var servicio = new Servicio
                            {
                                Nombre = txtNombre.Text,
                                Duracion = numericUD1.Value.ToString() + " minutos",
                                Precio = precio,
                                CategoriaId = idCategoria
                            };

                            HttpResponseMessage respuesta = await _httpClient.PostAsJsonAsync("api/servicios", servicio);

                            if (respuesta.IsSuccessStatusCode)
                            {
                                MessageBox.Show("Servicio registrado correctamente.");
                                txtNombre.Clear();
                                numericUD1.Value = 0;
                                txtPrecio.Clear();
                            }
                            else
                            {
                                string error = await respuesta.Content.ReadAsStringAsync();
                                MessageBox.Show("No se pudo registrar: " +error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingresá un precio válido.");
                    }
                }
                else
                {
                    MessageBox.Show("Ingresá una duración válida.");
                }
            }
            else
            {
                MessageBox.Show("Ingresá un nombre válido.");
            }
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
