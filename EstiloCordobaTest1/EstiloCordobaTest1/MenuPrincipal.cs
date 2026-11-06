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
            if (_usuario.IdRol == 2)
            {
                // Recepcionista no puede acceder a la administración de personal
                personalToolStripMenuItem.Visible = false;
            }

            if (_usuario.IdRol == 3)
            {
                // Barbero no puede acceder a la administración de personal
                personalToolStripMenuItem.Visible = false;
                turnosToolStripMenuItem.Visible = false;
                serviciosToolStripMenuItem.Visible = false;
                clientesToolStripMenuItem.Visible = false;
            }

            if (_usuario.IdRol == 4)
            {
                // Compras no puede acceder a la administración de personal
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

        private void administracionToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            foreach (Form formulario in this.MdiChildren)
            {
                if (formulario is AdministracionPersonal)
                {
                    formulario.BringToFront();
                    formulario.Activate();
                    return;
                }
            }

            AdministracionPersonal formHijo = new AdministracionPersonal(_usuario);
            formHijo.MdiParent = this;
            formHijo.Show();
        }

        private void administracionToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            foreach (Form formulario in this.MdiChildren)
            {
                if (formulario is AdministracionClientes)
                {
                    formulario.BringToFront();
                    formulario.Activate();
                    return;
                }
            }

            AdministracionClientes formHijo = new AdministracionClientes(_usuario);
            formHijo.MdiParent = this;
            formHijo.Show();
        }

        private void administracionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form formulario in this.MdiChildren)
            {
                if (formulario is AdministracionAtenciones)
                {
                    formulario.BringToFront();
                    formulario.Activate();
                    return;
                }
            }

            AdministracionAtenciones formHijo = new AdministracionAtenciones(_usuario);
            formHijo.MdiParent = this;
            formHijo.Show();
        }

        private void administracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form formulario in this.MdiChildren)
            {
                if (formulario is AdministracionTurnos)
                {
                    formulario.BringToFront();
                    formulario.Activate();
                    return;
                }
            }

            AdministracionTurnos formHijo = new AdministracionTurnos(_usuario);
            formHijo.MdiParent = this;
            formHijo.Show();
        }
    }
}
