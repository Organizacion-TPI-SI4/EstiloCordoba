namespace EstiloCordobaPresentacion
{
    partial class AdministracionClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministracionClientes));
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnConsultar = new Button();
            btnRegistrar = new Button();
            btnModificar = new Button();
            dgvClientes = new DataGridView();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoDniDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numeroDniDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            localidadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            redsocialDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bsClientes = new BindingSource(components);
            txtBuscar = new TextBox();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsClientes).BeginInit();
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
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(200, 450);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(13, 13);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(172, 52);
            btnConsultar.TabIndex = 0;
            btnConsultar.Text = "Consultar clientes";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(13, 71);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(172, 52);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(13, 129);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(172, 55);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { nombreDataGridViewTextBoxColumn, apellidoDataGridViewTextBoxColumn, tipoDniDataGridViewTextBoxColumn, numeroDniDataGridViewTextBoxColumn, telefonoDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, localidadDataGridViewTextBoxColumn, redsocialDataGridViewTextBoxColumn });
            dgvClientes.DataSource = bsClientes;
            dgvClientes.Location = new Point(217, 47);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.Size = new Size(945, 391);
            dgvClientes.TabIndex = 1;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDniDataGridViewTextBoxColumn
            // 
            tipoDniDataGridViewTextBoxColumn.DataPropertyName = "tipoDni";
            tipoDniDataGridViewTextBoxColumn.HeaderText = "tipoDni";
            tipoDniDataGridViewTextBoxColumn.Name = "tipoDniDataGridViewTextBoxColumn";
            tipoDniDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroDniDataGridViewTextBoxColumn
            // 
            numeroDniDataGridViewTextBoxColumn.DataPropertyName = "numeroDni";
            numeroDniDataGridViewTextBoxColumn.HeaderText = "numeroDni";
            numeroDniDataGridViewTextBoxColumn.Name = "numeroDniDataGridViewTextBoxColumn";
            numeroDniDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // localidadDataGridViewTextBoxColumn
            // 
            localidadDataGridViewTextBoxColumn.DataPropertyName = "localidad";
            localidadDataGridViewTextBoxColumn.HeaderText = "localidad";
            localidadDataGridViewTextBoxColumn.Name = "localidadDataGridViewTextBoxColumn";
            localidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // redsocialDataGridViewTextBoxColumn
            // 
            redsocialDataGridViewTextBoxColumn.DataPropertyName = "Red_social";
            redsocialDataGridViewTextBoxColumn.HeaderText = "Red_social";
            redsocialDataGridViewTextBoxColumn.Name = "redsocialDataGridViewTextBoxColumn";
            redsocialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsClientes
            // 
            bsClientes.DataSource = typeof(EstiloCordobaEntidades.Cliente);
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(217, 13);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar...";
            txtBuscar.Size = new Size(943, 23);
            txtBuscar.TabIndex = 2;
            // 
            // AdministracionClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 450);
            Controls.Add(txtBuscar);
            Controls.Add(dgvClientes);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AdministracionClientes";
            Text = "Administracion de clientes";
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnConsultar;
        private Button btnRegistrar;
        private Button btnModificar;
        private DataGridView dgvClientes;
        private TextBox txtBuscar;
        private BindingSource bsClientes;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numeroDniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn localidadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn redsocialDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idBeneficioDataGridViewTextBoxColumn;
    }
}