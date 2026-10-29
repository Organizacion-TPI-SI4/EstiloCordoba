namespace EstiloCordobaPresentacion
{
    partial class AdministracionServicios
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
            components = new System.ComponentModel.Container();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnConsultar = new Button();
            btnRegistrar = new Button();
            btnModificar = new Button();
            dgvServicios = new DataGridView();
            bsServicios = new BindingSource(components);
            txtBuscar = new TextBox();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServicios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsServicios).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            flowLayoutPanel1.Controls.Add(btnConsultar);
            flowLayoutPanel1.Controls.Add(btnRegistrar);
            flowLayoutPanel1.Controls.Add(btnModificar);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10, 10, 50, 10);
            flowLayoutPanel1.Size = new Size(184, 450);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnConsultar
            // 
            btnConsultar.FlatStyle = FlatStyle.System;
            btnConsultar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConsultar.Location = new Point(13, 13);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(156, 52);
            btnConsultar.TabIndex = 0;
            btnConsultar.Text = "Consultar servicios";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.FlatStyle = FlatStyle.System;
            btnRegistrar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(13, 71);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(156, 53);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnModificar
            // 
            btnModificar.FlatStyle = FlatStyle.System;
            btnModificar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModificar.Location = new Point(13, 130);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(156, 53);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // dgvServicios
            // 
            dgvServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicios.Location = new Point(200, 33);
            dgvServicios.Name = "dgvServicios";
            dgvServicios.Size = new Size(588, 405);
            dgvServicios.TabIndex = 1;
            dgvServicios.CellContentClick += dgvServicios_CellContentClick;
            // 
            // bsServicios
            // 
            bsServicios.DataSource = typeof(EstiloCordobaEntidades.Servicio);
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(200, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar...";
            txtBuscar.Size = new Size(588, 23);
            txtBuscar.TabIndex = 2;
            // 
            // AdministracionServicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBuscar);
            Controls.Add(dgvServicios);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AdministracionServicios";
            Text = "Administracion de servicios";
            Load += AdministracionServicios_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvServicios).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsServicios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnConsultar;
        private Button btnRegistrar;
        private Button btnModificar;
        private DataGridView dgvServicios;
        private BindingSource bsServicios;
        private TextBox txtBuscar;
    }
}