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
    public partial class RegistrarPersonal : Form
    {

        private readonly HttpClient _httpClient = new HttpClient()
        {
            BaseAddress = new Uri("https://localhost:7071/")
        };


        public RegistrarPersonal()
        {
            InitializeComponent();
        }

        private async void RegistrarPersonal_Load(object sender, EventArgs e)
        {
            await CargarRoles();
        }

        private async Task CargarRoles()
        {
            var roles = await _httpClient.GetFromJsonAsync<List<Rol>>("api/roles");

            cmbRol.DataSource = roles;
            cmbRol.DisplayMember = "Descripcion";
            cmbRol.ValueMember = "Id";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                if (!string.IsNullOrWhiteSpace(txtDomicilio.Text))
                {
                    if (!string.IsNullOrWhiteSpace(txtTelefono.Text))
                    {
                        if (!string.IsNullOrWhiteSpace(txtEmail.Text))
                        {
                            if (string.IsNullOrWhiteSpace(txtClave.Text))
                            {
                                MessageBox.Show("Ingresá una contraseña.");
                                return;
                            }
                            else
                            {
                                if (txtClave.Text == txtConfirmarClave.Text)
                                {
                                    int idRol = (int)cmbRol.SelectedValue;
                                    var empleado = new Empleado
                                    {
                                        Nombre = txtNombre.Text,
                                        Domicilio = txtDomicilio.Text,
                                        Telefono = txtTelefono.Text,
                                        Email = txtEmail.Text,
                                        Clave = txtClave.Text,
                                        IdRol = idRol
                                    };

                                    HttpResponseMessage respuesta = await _httpClient.PostAsJsonAsync("api/empleados", empleado);

                                    if (respuesta.IsSuccessStatusCode)
                                    {
                                        MessageBox.Show("Empleado registrado correctamente.");
                                        txtNombre.Clear();
                                        txtDomicilio.Clear();
                                        txtTelefono.Clear();
                                        txtClave.Clear();
                                        txtConfirmarClave.Clear();

                                        
                                    }
                                    else
                                    {
                                        string error = await respuesta.Content.ReadAsStringAsync();
                                        MessageBox.Show("No se pudo registrar: " +error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Las contraseñas no coinciden.");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingresá un email.");
                        }       
                    }
                    else
                    {
                        MessageBox.Show("Ingresá un numero de telefono.");
                    }
                }
                else
                {
                    MessageBox.Show("Ingresá un domicilio.");
                }
            }
            else
            {
                MessageBox.Show("Ingresá un nombre.");
            }
        }
    }
}
