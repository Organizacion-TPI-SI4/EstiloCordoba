using EstiloCordobaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EstiloCordobaPresentacion
{
    public partial class MenuPrincipal : Form
    {

        private readonly Session _usuario;

        public MenuPrincipal(Session session)
        {
            InitializeComponent();
            _usuario = session;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

            if (_usuario.IdRol == null)
            {
                MessageBox.Show("Usuario no válido. Cerrando la aplicación.");
                this.Close();
                return;
            }

            if (_usuario.IdRol == 2)
            {
                // Recepcionista
                personalToolStripMenuItem.Visible = false;
            }
        }

        private void administracionToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            foreach (Form formulario in this.MdiChildren)
            {
                if (formulario is AdministracionServicios)
                {
                    formulario.BringToFront();
                    formulario.Activate();
                    return;
                }
            }

            AdministracionServicios formHijo = new AdministracionServicios(_usuario);
            formHijo.MdiParent = this;
            formHijo.Show();
        }
        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form formulario in this.MdiChildren)
            {
                if (formulario is AdministracionCategorias)
                {
                    formulario.BringToFront();
                    formulario.Activate();
                    return;
                }
            }

            AdministracionCategorias formHijo = new AdministracionCategorias(_usuario);
            formHijo.MdiParent = this;
            formHijo.Show();
        }
    }
}
