namespace EstiloCordobaPresentacion
{
    partial class AdministracionAtenciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministracionAtenciones));
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnConsultar = new Button();
            btnRegistrar = new Button();
            btnModificar = new Button();
            textBox1 = new TextBox();
            dgvAtencion = new DataGridView();
            bsAtencion = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            horaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalCalculadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalServiciosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalProductosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idBarberoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idClienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idTurnoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idEstadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idMedioPagoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAtencion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsAtencion).BeginInit();
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
            flowLayoutPanel1.Size = new Size(200, 545);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(13, 13);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(172, 52);
            btnConsultar.TabIndex = 0;
            btnConsultar.Text = "Consultar atenciones";
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
            // textBox1
            // 
            textBox1.Location = new Point(218, 13);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Buscar...";
            textBox1.Size = new Size(972, 23);
            textBox1.TabIndex = 2;
            // 
            // dgvAtencion
            // 
            dgvAtencion.AutoGenerateColumns = false;
            dgvAtencion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAtencion.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, fechaDataGridViewTextBoxColumn, horaDataGridViewTextBoxColumn, totalCalculadoDataGridViewTextBoxColumn, totalServiciosDataGridViewTextBoxColumn, totalProductosDataGridViewTextBoxColumn, idBarberoDataGridViewTextBoxColumn, idClienteDataGridViewTextBoxColumn, idTurnoDataGridViewTextBoxColumn, idEstadoDataGridViewTextBoxColumn, idMedioPagoDataGridViewTextBoxColumn });
            dgvAtencion.DataSource = bsAtencion;
            dgvAtencion.Location = new Point(218, 65);
            dgvAtencion.Name = "dgvAtencion";
            dgvAtencion.Size = new Size(972, 480);
            dgvAtencion.TabIndex = 3;
            // 
            // bsAtencion
            // 
            bsAtencion.DataSource = typeof(EstiloCordobaEntidades.Atencion);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // horaDataGridViewTextBoxColumn
            // 
            horaDataGridViewTextBoxColumn.DataPropertyName = "hora";
            horaDataGridViewTextBoxColumn.HeaderText = "hora";
            horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            // 
            // totalCalculadoDataGridViewTextBoxColumn
            // 
            totalCalculadoDataGridViewTextBoxColumn.DataPropertyName = "totalCalculado";
            totalCalculadoDataGridViewTextBoxColumn.HeaderText = "totalCalculado";
            totalCalculadoDataGridViewTextBoxColumn.Name = "totalCalculadoDataGridViewTextBoxColumn";
            // 
            // totalServiciosDataGridViewTextBoxColumn
            // 
            totalServiciosDataGridViewTextBoxColumn.DataPropertyName = "totalServicios";
            totalServiciosDataGridViewTextBoxColumn.HeaderText = "totalServicios";
            totalServiciosDataGridViewTextBoxColumn.Name = "totalServiciosDataGridViewTextBoxColumn";
            // 
            // totalProductosDataGridViewTextBoxColumn
            // 
            totalProductosDataGridViewTextBoxColumn.DataPropertyName = "totalProductos";
            totalProductosDataGridViewTextBoxColumn.HeaderText = "totalProductos";
            totalProductosDataGridViewTextBoxColumn.Name = "totalProductosDataGridViewTextBoxColumn";
            // 
            // idBarberoDataGridViewTextBoxColumn
            // 
            idBarberoDataGridViewTextBoxColumn.DataPropertyName = "idBarbero";
            idBarberoDataGridViewTextBoxColumn.HeaderText = "idBarbero";
            idBarberoDataGridViewTextBoxColumn.Name = "idBarberoDataGridViewTextBoxColumn";
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            idClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente";
            idClienteDataGridViewTextBoxColumn.HeaderText = "idCliente";
            idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            // 
            // idTurnoDataGridViewTextBoxColumn
            // 
            idTurnoDataGridViewTextBoxColumn.DataPropertyName = "idTurno";
            idTurnoDataGridViewTextBoxColumn.HeaderText = "idTurno";
            idTurnoDataGridViewTextBoxColumn.Name = "idTurnoDataGridViewTextBoxColumn";
            // 
            // idEstadoDataGridViewTextBoxColumn
            // 
            idEstadoDataGridViewTextBoxColumn.DataPropertyName = "idEstado";
            idEstadoDataGridViewTextBoxColumn.HeaderText = "idEstado";
            idEstadoDataGridViewTextBoxColumn.Name = "idEstadoDataGridViewTextBoxColumn";
            // 
            // idMedioPagoDataGridViewTextBoxColumn
            // 
            idMedioPagoDataGridViewTextBoxColumn.DataPropertyName = "idMedioPago";
            idMedioPagoDataGridViewTextBoxColumn.HeaderText = "idMedioPago";
            idMedioPagoDataGridViewTextBoxColumn.Name = "idMedioPagoDataGridViewTextBoxColumn";
            // 
            // AdministracionAtenciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 545);
            Controls.Add(dgvAtencion);
            Controls.Add(textBox1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AdministracionAtenciones";
            Text = "Administracion de atenciones";
            Load += AdministracionAtenciones_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAtencion).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsAtencion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnConsultar;
        private Button btnRegistrar;
        private Button btnModificar;
        private TextBox textBox1;
        private DataGridView dgvAtencion;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalCalculadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalServiciosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalProductosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idBarberoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idTurnoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idEstadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idMedioPagoDataGridViewTextBoxColumn;
        private BindingSource bsAtencion;
    }
}