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
    public partial class RegistrarCliente : Form
    {

        private readonly HttpClient _httpClient = new HttpClient()
        {
            BaseAddress = new Uri("https://localhost:7071/")
        };

        public enum TipoDni { A, B, C };

        public RegistrarCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegistrarCliente_Load(object sender, EventArgs e)
        {
            cmbTipoDni.DataSource = Enum.GetValues(typeof(TipoDni));
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingresá un nombre.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Ingresá un apellido.");
                return;
            }

            if (!int.TryParse(txtNumeroDni.Text, out int dni))
            {
                MessageBox.Show("DNI inválido.");
                return;
            }

            string tipoDni = cmbTipoDni.SelectedItem.ToString();

            var cliente = new Cliente
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                tipoDni = tipoDni,
                numeroDni = dni,
                Telefono = txtTelefono.Text,
                Email = txtEmail.Text,
                localidad = txtLocalidad.Text
            };

            if (!string.IsNullOrWhiteSpace(txtRedSocial.Text))
            {
                if (rbFacebook.Checked)
                    cliente.Red_social = "Facebook: @" + txtRedSocial.Text;

                else if (rbInstagram.Checked)
                    cliente.Red_social = "Instagram: @" + txtRedSocial.Text;

                else if (rbTwitter.Checked)
                    cliente.Red_social = "Twitter: @" + txtRedSocial.Text;
            } 

            HttpResponseMessage respuesta =
                await _httpClient.PostAsJsonAsync("api/clientes", cliente);

            if (respuesta.IsSuccessStatusCode)
            {
                MessageBox.Show("Cliente registrado correctamente.");

                txtNombre.Clear();
                txtApellido.Clear();
                txtNumeroDni.Clear();
                txtTelefono.Clear();
                txtEmail.Clear();
                txtLocalidad.Clear();
                txtRedSocial.Clear();

                rbFacebook.Checked = false;
                rbInstagram.Checked = false;
                rbTwitter.Checked = false;
            }
            else
            {
                string error = await respuesta.Content.ReadAsStringAsync();
                MessageBox.Show("No se pudo registrar: " + error);
            }
        }
    }
}
    
    

