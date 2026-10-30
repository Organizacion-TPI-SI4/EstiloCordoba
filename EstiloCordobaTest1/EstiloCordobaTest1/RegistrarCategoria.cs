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
    public partial class RegistrarCategoria : Form
    {

        private readonly HttpClient _httpClient = new HttpClient()
        {
            BaseAddress = new Uri("https://localhost:7071/")
        };

        public RegistrarCategoria()
        {
            InitializeComponent();
        }

        private void RegistrarCategoria_Load(object sender, EventArgs e)
        {

        }

        private async void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                var categoria = new Categoria
                {
                    descripcion = txtNombre.Text
                };

                HttpResponseMessage respuesta = await _httpClient.PostAsJsonAsync("api/categorias", categoria);

                if (respuesta.IsSuccessStatusCode)
                {
                    MessageBox.Show("Categoría registrada correctamente.");
                    txtNombre.Clear();
                }
                else
                {
                    string error = await respuesta.Content.ReadAsStringAsync();

                    MessageBox.Show("No se pudo registrar: " +error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
