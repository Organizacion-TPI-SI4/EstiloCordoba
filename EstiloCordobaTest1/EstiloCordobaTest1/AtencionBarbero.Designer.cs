namespace EstiloCordobaPresentacion
{
    partial class AtencionBarbero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtencionBarbero));
            bsAtencionAsignada = new BindingSource(components);
            dgvAtencionAsignada = new DataGridView();
            label1 = new Label();
            cmbAtencionAsignada = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            lblEstadoAtencion = new Label();
            btnIniciar = new Button();
            btnFinalizar = new Button();
            groupBox1 = new GroupBox();
            lblIdAtencion = new Label();
            label6 = new Label();
            label5 = new Label();
            lblNombreCliente = new Label();
            dgvServicioSolicitado = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            duracionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoriaIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bsServiciosSolicitados = new BindingSource(components);
            label4 = new Label();
            btnConsultar = new Button();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            horaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalCalculadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalServiciosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalProductosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idEstadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)bsAtencionAsignada).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAtencionAsignada).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServicioSolicitado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsServiciosSolicitados).BeginInit();
            SuspendLayout();
            // 
            // bsAtencionAsignada
            // 
            bsAtencionAsignada.DataSource = typeof(EstiloCordobaEntidades.Atencion);
            // 
            // dgvAtencionAsignada
            // 
            dgvAtencionAsignada.AutoGenerateColumns = false;
            dgvAtencionAsignada.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAtencionAsignada.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, fechaDataGridViewTextBoxColumn, horaDataGridViewTextBoxColumn, totalCalculadoDataGridViewTextBoxColumn, totalServiciosDataGridViewTextBoxColumn, totalProductosDataGridViewTextBoxColumn, idEstadoDataGridViewTextBoxColumn });
            dgvAtencionAsignada.DataSource = bsAtencionAsignada;
            dgvAtencionAsignada.Location = new Point(28, 73);
            dgvAtencionAsignada.Name = "dgvAtencionAsignada";
            dgvAtencionAsignada.ReadOnly = true;
            dgvAtencionAsignada.Size = new Size(744, 149);
            dgvAtencionAsignada.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Vivaldi", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(199, 29);
            label1.TabIndex = 1;
            label1.Text = "Tus atenciones asignadas";
            // 
            // cmbAtencionAsignada
            // 
            cmbAtencionAsignada.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAtencionAsignada.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbAtencionAsignada.FormattingEnabled = true;
            cmbAtencionAsignada.Location = new Point(179, 253);
            cmbAtencionAsignada.Name = "cmbAtencionAsignada";
            cmbAtencionAsignada.Size = new Size(609, 28);
            cmbAtencionAsignada.TabIndex = 2;
            cmbAtencionAsignada.SelectedIndexChanged += cmbAtencionAsignada_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 256);
            label2.Name = "label2";
            label2.Size = new Size(161, 20);
            label2.TabIndex = 3;
            label2.Text = "Atencion seleccionada:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 101);
            label3.Name = "label3";
            label3.Size = new Size(155, 20);
            label3.TabIndex = 4;
            label3.Text = "Estado de la atencion:";
            // 
            // lblEstadoAtencion
            // 
            lblEstadoAtencion.AutoSize = true;
            lblEstadoAtencion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstadoAtencion.Location = new Point(167, 100);
            lblEstadoAtencion.Name = "lblEstadoAtencion";
            lblEstadoAtencion.Size = new Size(176, 21);
            lblEstadoAtencion.TabIndex = 5;
            lblEstadoAtencion.Text = "((Estado de la atencion))";
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.FromArgb(128, 255, 128);
            btnIniciar.Cursor = Cursors.Hand;
            btnIniciar.FlatStyle = FlatStyle.Popup;
            btnIniciar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciar.Location = new Point(12, 639);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(292, 85);
            btnIniciar.TabIndex = 6;
            btnIniciar.Text = "INICIAR ATENCION";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnFinalizar
            // 
            btnFinalizar.BackColor = Color.LightSalmon;
            btnFinalizar.Cursor = Cursors.Hand;
            btnFinalizar.FlatStyle = FlatStyle.Popup;
            btnFinalizar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFinalizar.Location = new Point(496, 639);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(292, 85);
            btnFinalizar.TabIndex = 7;
            btnFinalizar.Text = "FINALIZAR ATENCION";
            btnFinalizar.UseVisualStyleBackColor = false;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblIdAtencion);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblNombreCliente);
            groupBox1.Controls.Add(dgvServicioSolicitado);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblEstadoAtencion);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 287);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 346);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalles de la atencion";
            // 
            // lblIdAtencion
            // 
            lblIdAtencion.AutoSize = true;
            lblIdAtencion.Location = new Point(96, 36);
            lblIdAtencion.Name = "lblIdAtencion";
            lblIdAtencion.Size = new Size(52, 21);
            lblIdAtencion.TabIndex = 12;
            lblIdAtencion.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 36);
            label6.Name = "label6";
            label6.Size = new Size(93, 21);
            label6.TabIndex = 11;
            label6.Text = "ID Atencion:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(299, 145);
            label5.Name = "label5";
            label5.Size = new Size(185, 30);
            label5.TabIndex = 10;
            label5.Text = "Servicios solicitados";
            label5.Click += label5_Click;
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Location = new Point(70, 67);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(52, 21);
            lblNombreCliente.TabIndex = 8;
            lblNombreCliente.Text = "label5";
            // 
            // dgvServicioSolicitado
            // 
            dgvServicioSolicitado.AutoGenerateColumns = false;
            dgvServicioSolicitado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicioSolicitado.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, nombreDataGridViewTextBoxColumn, precioDataGridViewTextBoxColumn, duracionDataGridViewTextBoxColumn, categoriaIdDataGridViewTextBoxColumn });
            dgvServicioSolicitado.DataSource = bsServiciosSolicitados;
            dgvServicioSolicitado.Location = new Point(6, 178);
            dgvServicioSolicitado.Name = "dgvServicioSolicitado";
            dgvServicioSolicitado.ReadOnly = true;
            dgvServicioSolicitado.Size = new Size(764, 162);
            dgvServicioSolicitado.TabIndex = 7;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // duracionDataGridViewTextBoxColumn
            // 
            duracionDataGridViewTextBoxColumn.DataPropertyName = "Duracion";
            duracionDataGridViewTextBoxColumn.HeaderText = "Duracion";
            duracionDataGridViewTextBoxColumn.Name = "duracionDataGridViewTextBoxColumn";
            duracionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoriaIdDataGridViewTextBoxColumn
            // 
            categoriaIdDataGridViewTextBoxColumn.DataPropertyName = "CategoriaId";
            categoriaIdDataGridViewTextBoxColumn.HeaderText = "CategoriaId";
            categoriaIdDataGridViewTextBoxColumn.Name = "categoriaIdDataGridViewTextBoxColumn";
            categoriaIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsServiciosSolicitados
            // 
            bsServiciosSolicitados.DataSource = typeof(EstiloCordobaEntidades.Servicio);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 68);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 6;
            label4.Text = "Cliente:";
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = SystemColors.Highlight;
            btnConsultar.Cursor = Cursors.Hand;
            btnConsultar.FlatStyle = FlatStyle.Popup;
            btnConsultar.Font = new Font("Corbel", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultar.ForeColor = SystemColors.ControlLightLight;
            btnConsultar.Location = new Point(229, 15);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 9;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaDataGridViewTextBoxColumn
            // 
            horaDataGridViewTextBoxColumn.DataPropertyName = "hora";
            horaDataGridViewTextBoxColumn.HeaderText = "hora";
            horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            horaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalCalculadoDataGridViewTextBoxColumn
            // 
            totalCalculadoDataGridViewTextBoxColumn.DataPropertyName = "totalCalculado";
            totalCalculadoDataGridViewTextBoxColumn.HeaderText = "totalCalculado";
            totalCalculadoDataGridViewTextBoxColumn.Name = "totalCalculadoDataGridViewTextBoxColumn";
            totalCalculadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalServiciosDataGridViewTextBoxColumn
            // 
            totalServiciosDataGridViewTextBoxColumn.DataPropertyName = "totalServicios";
            totalServiciosDataGridViewTextBoxColumn.HeaderText = "totalServicios";
            totalServiciosDataGridViewTextBoxColumn.Name = "totalServiciosDataGridViewTextBoxColumn";
            totalServiciosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalProductosDataGridViewTextBoxColumn
            // 
            totalProductosDataGridViewTextBoxColumn.DataPropertyName = "totalProductos";
            totalProductosDataGridViewTextBoxColumn.HeaderText = "totalProductos";
            totalProductosDataGridViewTextBoxColumn.Name = "totalProductosDataGridViewTextBoxColumn";
            totalProductosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idEstadoDataGridViewTextBoxColumn
            // 
            idEstadoDataGridViewTextBoxColumn.DataPropertyName = "idEstado";
            idEstadoDataGridViewTextBoxColumn.HeaderText = "idEstado";
            idEstadoDataGridViewTextBoxColumn.Name = "idEstadoDataGridViewTextBoxColumn";
            idEstadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AtencionBarbero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 736);
            Controls.Add(btnConsultar);
            Controls.Add(groupBox1);
            Controls.Add(btnFinalizar);
            Controls.Add(btnIniciar);
            Controls.Add(label2);
            Controls.Add(cmbAtencionAsignada);
            Controls.Add(label1);
            Controls.Add(dgvAtencionAsignada);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AtencionBarbero";
            Text = "Atenciones asignadas a barberos";
            ((System.ComponentModel.ISupportInitialize)bsAtencionAsignada).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAtencionAsignada).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServicioSolicitado).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsServiciosSolicitados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bsAtencionAsignada;
        private DataGridView dgvAtencionAsignada;
        private Label label1;
        private ComboBox cmbAtencionAsignada;
        private Label label2;
        private Label label3;
        private Label lblEstadoAtencion;
        private Button btnIniciar;
        private Button btnFinalizar;
        private GroupBox groupBox1;
        private Label label4;
        private Label lblIdAtencion;
        private Label label6;
        private Label label5;
        private Label lblNombreCliente;
        private DataGridView dgvServicioSolicitado;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn duracionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoriaIdDataGridViewTextBoxColumn;
        private BindingSource bsServiciosSolicitados;
        private Button btnConsultar;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalCalculadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalServiciosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalProductosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idEstadoDataGridViewTextBoxColumn;
    }
}