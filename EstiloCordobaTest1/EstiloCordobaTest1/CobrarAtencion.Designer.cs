namespace EstiloCordobaPresentacion
{
    partial class CobrarAtencion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CobrarAtencion));
            dgvAtencionCobrar = new DataGridView();
            bsAtencionCobrar = new BindingSource(components);
            label1 = new Label();
            cmbAtencionCobrar = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnCobrar = new Button();
            btnCancelar = new Button();
            cmbMedioPago = new ComboBox();
            label6 = new Label();
            lblIdAtencion = new Label();
            lblNombreCliente = new Label();
            lblTotalCobrar = new Label();
            label7 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)dgvAtencionCobrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsAtencionCobrar).BeginInit();
            SuspendLayout();
            // 
            // dgvAtencionCobrar
            // 
            dgvAtencionCobrar.AutoGenerateColumns = false;
            dgvAtencionCobrar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAtencionCobrar.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, fechaDataGridViewTextBoxColumn, horaDataGridViewTextBoxColumn, totalCalculadoDataGridViewTextBoxColumn, totalServiciosDataGridViewTextBoxColumn, totalProductosDataGridViewTextBoxColumn, idBarberoDataGridViewTextBoxColumn, idClienteDataGridViewTextBoxColumn, idTurnoDataGridViewTextBoxColumn, idEstadoDataGridViewTextBoxColumn, idMedioPagoDataGridViewTextBoxColumn });
            dgvAtencionCobrar.DataSource = bsAtencionCobrar;
            dgvAtencionCobrar.Location = new Point(12, 33);
            dgvAtencionCobrar.Name = "dgvAtencionCobrar";
            dgvAtencionCobrar.Size = new Size(650, 150);
            dgvAtencionCobrar.TabIndex = 0;
            // 
            // bsAtencionCobrar
            // 
            bsAtencionCobrar.DataSource = typeof(EstiloCordobaEntidades.Atencion);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(231, 21);
            label1.TabIndex = 1;
            label1.Text = "Atenciones pendientes de cobro";
            // 
            // cmbAtencionCobrar
            // 
            cmbAtencionCobrar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAtencionCobrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbAtencionCobrar.FormattingEnabled = true;
            cmbAtencionCobrar.Location = new Point(12, 226);
            cmbAtencionCobrar.Name = "cmbAtencionCobrar";
            cmbAtencionCobrar.Size = new Size(650, 29);
            cmbAtencionCobrar.TabIndex = 2;
            cmbAtencionCobrar.SelectedIndexChanged += cmbAtencionCobrar_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 202);
            label2.Name = "label2";
            label2.Size = new Size(152, 21);
            label2.TabIndex = 3;
            label2.Text = "Seleccionar atencion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 276);
            label3.Name = "label3";
            label3.Size = new Size(93, 21);
            label3.TabIndex = 4;
            label3.Text = "ID Atencion:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 312);
            label4.Name = "label4";
            label4.Size = new Size(120, 21);
            label4.TabIndex = 5;
            label4.Text = "Nombre cliente:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 431);
            label5.Name = "label5";
            label5.Size = new Size(142, 21);
            label5.TabIndex = 6;
            label5.Text = "TOTAL A COBRAR:";
            // 
            // btnCobrar
            // 
            btnCobrar.BackColor = Color.LightGreen;
            btnCobrar.Cursor = Cursors.Hand;
            btnCobrar.FlatStyle = FlatStyle.Popup;
            btnCobrar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCobrar.Location = new Point(399, 487);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(263, 64);
            btnCobrar.TabIndex = 7;
            btnCobrar.Text = "COBRAR";
            btnCobrar.UseVisualStyleBackColor = false;
            btnCobrar.Click += btnCobrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Firebrick;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(12, 487);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(169, 64);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cmbMedioPago
            // 
            cmbMedioPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMedioPago.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbMedioPago.FormattingEnabled = true;
            cmbMedioPago.Location = new Point(135, 352);
            cmbMedioPago.Name = "cmbMedioPago";
            cmbMedioPago.Size = new Size(235, 29);
            cmbMedioPago.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 355);
            label6.Name = "label6";
            label6.Size = new Size(117, 21);
            label6.TabIndex = 10;
            label6.Text = "Medio de pago:";
            // 
            // lblIdAtencion
            // 
            lblIdAtencion.AutoSize = true;
            lblIdAtencion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIdAtencion.Location = new Point(111, 276);
            lblIdAtencion.Name = "lblIdAtencion";
            lblIdAtencion.Size = new Size(52, 21);
            lblIdAtencion.TabIndex = 11;
            lblIdAtencion.Text = "label7";
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreCliente.Location = new Point(138, 312);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(52, 21);
            lblNombreCliente.TabIndex = 12;
            lblNombreCliente.Text = "label8";
            // 
            // lblTotalCobrar
            // 
            lblTotalCobrar.AutoSize = true;
            lblTotalCobrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalCobrar.Location = new Point(185, 431);
            lblTotalCobrar.Name = "lblTotalCobrar";
            lblTotalCobrar.Size = new Size(52, 21);
            lblTotalCobrar.TabIndex = 13;
            lblTotalCobrar.Text = "label7";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(160, 431);
            label7.Name = "label7";
            label7.Size = new Size(19, 21);
            label7.TabIndex = 14;
            label7.Text = "$";
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
            // CobrarAtencion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 563);
            Controls.Add(label7);
            Controls.Add(lblTotalCobrar);
            Controls.Add(lblNombreCliente);
            Controls.Add(lblIdAtencion);
            Controls.Add(label6);
            Controls.Add(cmbMedioPago);
            Controls.Add(btnCancelar);
            Controls.Add(btnCobrar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbAtencionCobrar);
            Controls.Add(label1);
            Controls.Add(dgvAtencionCobrar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CobrarAtencion";
            Text = "Cobrar atencion";
            Load += CobrarAtencion_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAtencionCobrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsAtencionCobrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAtencionCobrar;
        private BindingSource bsAtencionCobrar;
        private Label label1;
        private ComboBox cmbAtencionCobrar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnCobrar;
        private Button btnCancelar;
        private ComboBox cmbMedioPago;
        private Label label6;
        private Label lblIdAtencion;
        private Label lblNombreCliente;
        private Label lblTotalCobrar;
        private Label label7;
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
    }
}