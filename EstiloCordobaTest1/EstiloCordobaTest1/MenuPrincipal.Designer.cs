namespace EstiloCordobaPresentacion
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            cuentaToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            minimizarToolStripMenuItem = new ToolStripMenuItem();
            cerrarToolStripMenuItem = new ToolStripMenuItem();
            turnosToolStripMenuItem = new ToolStripMenuItem();
            administracionToolStripMenuItem = new ToolStripMenuItem();
            atencionesToolStripMenuItem = new ToolStripMenuItem();
            administracionToolStripMenuItem1 = new ToolStripMenuItem();
            serviciosToolStripMenuItem = new ToolStripMenuItem();
            administracionToolStripMenuItem2 = new ToolStripMenuItem();
            categoriasToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            administracionToolStripMenuItem3 = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            administracionToolStripMenuItem4 = new ToolStripMenuItem();
            personalToolStripMenuItem = new ToolStripMenuItem();
            administracionToolStripMenuItem5 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.MenuBar;
            menuStrip1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, turnosToolStripMenuItem, atencionesToolStripMenuItem, serviciosToolStripMenuItem, productosToolStripMenuItem, clientesToolStripMenuItem, personalToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1228, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cuentaToolStripMenuItem, cerrarSesionToolStripMenuItem, minimizarToolStripMenuItem, cerrarToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(64, 25);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // cuentaToolStripMenuItem
            // 
            cuentaToolStripMenuItem.Name = "cuentaToolStripMenuItem";
            cuentaToolStripMenuItem.Size = new Size(218, 26);
            cuentaToolStripMenuItem.Text = "Administrar cuenta";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            cerrarSesionToolStripMenuItem.Size = new Size(218, 26);
            cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            cerrarSesionToolStripMenuItem.Click += cerrarSesionToolStripMenuItem_Click;
            // 
            // minimizarToolStripMenuItem
            // 
            minimizarToolStripMenuItem.Name = "minimizarToolStripMenuItem";
            minimizarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.M;
            minimizarToolStripMenuItem.Size = new Size(218, 26);
            minimizarToolStripMenuItem.Text = "Minimizar";
            // 
            // cerrarToolStripMenuItem
            // 
            cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            cerrarToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            cerrarToolStripMenuItem.Size = new Size(218, 26);
            cerrarToolStripMenuItem.Text = "Cerrar";
            // 
            // turnosToolStripMenuItem
            // 
            turnosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { administracionToolStripMenuItem });
            turnosToolStripMenuItem.Name = "turnosToolStripMenuItem";
            turnosToolStripMenuItem.Size = new Size(71, 25);
            turnosToolStripMenuItem.Text = "Turnos";
            // 
            // administracionToolStripMenuItem
            // 
            administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            administracionToolStripMenuItem.Size = new Size(190, 26);
            administracionToolStripMenuItem.Text = "Administracion";
            administracionToolStripMenuItem.Click += administracionToolStripMenuItem_Click;
            // 
            // atencionesToolStripMenuItem
            // 
            atencionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { administracionToolStripMenuItem1 });
            atencionesToolStripMenuItem.Name = "atencionesToolStripMenuItem";
            atencionesToolStripMenuItem.Size = new Size(104, 25);
            atencionesToolStripMenuItem.Text = "Atenciones";
            // 
            // administracionToolStripMenuItem1
            // 
            administracionToolStripMenuItem1.Name = "administracionToolStripMenuItem1";
            administracionToolStripMenuItem1.Size = new Size(190, 26);
            administracionToolStripMenuItem1.Text = "Administracion";
            administracionToolStripMenuItem1.Click += administracionToolStripMenuItem1_Click;
            // 
            // serviciosToolStripMenuItem
            // 
            serviciosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { administracionToolStripMenuItem2, categoriasToolStripMenuItem });
            serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            serviciosToolStripMenuItem.Size = new Size(88, 25);
            serviciosToolStripMenuItem.Text = "Servicios";
            // 
            // administracionToolStripMenuItem2
            // 
            administracionToolStripMenuItem2.Name = "administracionToolStripMenuItem2";
            administracionToolStripMenuItem2.Size = new Size(190, 26);
            administracionToolStripMenuItem2.Text = "Administracion";
            administracionToolStripMenuItem2.Click += administracionToolStripMenuItem2_Click;
            // 
            // categoriasToolStripMenuItem
            // 
            categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            categoriasToolStripMenuItem.Size = new Size(190, 26);
            categoriasToolStripMenuItem.Text = "Categorias";
            categoriasToolStripMenuItem.Click += categoriasToolStripMenuItem_Click;
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { administracionToolStripMenuItem3 });
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(97, 25);
            productosToolStripMenuItem.Text = "Productos";
            // 
            // administracionToolStripMenuItem3
            // 
            administracionToolStripMenuItem3.Name = "administracionToolStripMenuItem3";
            administracionToolStripMenuItem3.Size = new Size(190, 26);
            administracionToolStripMenuItem3.Text = "Administracion";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { administracionToolStripMenuItem4 });
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(80, 25);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // administracionToolStripMenuItem4
            // 
            administracionToolStripMenuItem4.Name = "administracionToolStripMenuItem4";
            administracionToolStripMenuItem4.Size = new Size(190, 26);
            administracionToolStripMenuItem4.Text = "Administracion";
            administracionToolStripMenuItem4.Click += administracionToolStripMenuItem4_Click;
            // 
            // personalToolStripMenuItem
            // 
            personalToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { administracionToolStripMenuItem5 });
            personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            personalToolStripMenuItem.Size = new Size(83, 25);
            personalToolStripMenuItem.Text = "Personal";
            // 
            // administracionToolStripMenuItem5
            // 
            administracionToolStripMenuItem5.Name = "administracionToolStripMenuItem5";
            administracionToolStripMenuItem5.Size = new Size(190, 26);
            administracionToolStripMenuItem5.Text = "Administracion";
            administracionToolStripMenuItem5.Click += administracionToolStripMenuItem5_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1228, 559);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu principal";
            Load += MenuPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private ToolStripMenuItem minimizarToolStripMenuItem;
        private ToolStripMenuItem cerrarToolStripMenuItem;
        private ToolStripMenuItem turnosToolStripMenuItem;
        private ToolStripMenuItem atencionesToolStripMenuItem;
        private ToolStripMenuItem serviciosToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem personalToolStripMenuItem;
        private ToolStripMenuItem cuentaToolStripMenuItem;
        private ToolStripMenuItem administracionToolStripMenuItem;
        private ToolStripMenuItem administracionToolStripMenuItem1;
        private ToolStripMenuItem administracionToolStripMenuItem2;
        private ToolStripMenuItem administracionToolStripMenuItem3;
        private ToolStripMenuItem administracionToolStripMenuItem4;
        private ToolStripMenuItem administracionToolStripMenuItem5;
        private ToolStripMenuItem categoriasToolStripMenuItem;
    }
}