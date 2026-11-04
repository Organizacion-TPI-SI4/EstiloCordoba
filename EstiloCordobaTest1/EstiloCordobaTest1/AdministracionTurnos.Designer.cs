namespace EstiloCordobaPresentacion
{
    partial class AdministracionTurnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministracionTurnos));
            dgvTurnos = new DataGridView();
            bsTurnos = new BindingSource(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnConsultar = new Button();
            btnRegistrar = new Button();
            btnModificar = new Button();
            textBox1 = new TextBox();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idUsuarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            UsuarioNombre = new DataGridViewTextBoxColumn();
            idClienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ClienteNombre = new DataGridViewTextBoxColumn();
            fechaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            horaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ServiciosTexto = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsTurnos).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvTurnos
            // 
            dgvTurnos.AutoGenerateColumns = false;
            dgvTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTurnos.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, idUsuarioDataGridViewTextBoxColumn, UsuarioNombre, idClienteDataGridViewTextBoxColumn, ClienteNombre, fechaDataGridViewTextBoxColumn, horaDataGridViewTextBoxColumn, ServiciosTexto });
            dgvTurnos.DataSource = bsTurnos;
            dgvTurnos.Location = new Point(219, 41);
            dgvTurnos.Name = "dgvTurnos";
            dgvTurnos.Size = new Size(944, 495);
            dgvTurnos.TabIndex = 0;
            // 
            // bsTurnos
            // 
            bsTurnos.DataSource = typeof(EstiloCordobaEntidades.Turno);
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
            flowLayoutPanel1.Size = new Size(200, 548);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(13, 13);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(173, 52);
            btnConsultar.TabIndex = 0;
            btnConsultar.Text = "Consultar turnos";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(13, 71);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(173, 52);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(13, 129);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(173, 52);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(219, 12);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Buscar...";
            textBox1.Size = new Size(944, 23);
            textBox1.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "idUsuario";
            idUsuarioDataGridViewTextBoxColumn.HeaderText = "idEmpleado";
            idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            // 
            // UsuarioNombre
            // 
            UsuarioNombre.DataPropertyName = "UsuarioNombre";
            UsuarioNombre.HeaderText = "EmpleadoNombre";
            UsuarioNombre.Name = "UsuarioNombre";
            UsuarioNombre.ReadOnly = true;
            UsuarioNombre.Width = 110;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            idClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente";
            idClienteDataGridViewTextBoxColumn.HeaderText = "idCliente";
            idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            // 
            // ClienteNombre
            // 
            ClienteNombre.DataPropertyName = "ClienteNombre";
            ClienteNombre.HeaderText = "ClienteNombre";
            ClienteNombre.Name = "ClienteNombre";
            ClienteNombre.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // horaDataGridViewTextBoxColumn
            // 
            horaDataGridViewTextBoxColumn.DataPropertyName = "Hora";
            horaDataGridViewTextBoxColumn.HeaderText = "Hora";
            horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            // 
            // ServiciosTexto
            // 
            ServiciosTexto.DataPropertyName = "ServiciosTexto";
            ServiciosTexto.HeaderText = "ServiciosTexto";
            ServiciosTexto.Name = "ServiciosTexto";
            ServiciosTexto.ReadOnly = true;
            ServiciosTexto.Width = 300;
            // 
            // AdministracionTurnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 548);
            Controls.Add(textBox1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(dgvTurnos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AdministracionTurnos";
            Text = "Administracion de turnos";
            Load += AdministracionTurnos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsTurnos).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTurnos;
        private BindingSource bsTurnos;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox textBox1;
        private Button btnConsultar;
        private Button btnRegistrar;
        private Button btnModificar;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn UsuarioNombre;
        private DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ClienteNombre;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ServiciosTexto;
    }
}