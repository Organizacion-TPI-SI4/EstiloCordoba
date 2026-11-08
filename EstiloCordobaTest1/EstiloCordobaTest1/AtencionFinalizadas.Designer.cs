namespace EstiloCordobaPresentacion
{
    partial class AtencionFinalizadas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtencionFinalizadas));
            bsAtencionFinalizada = new BindingSource(components);
            dgvAtencionFinalizada = new DataGridView();
            label1 = new Label();
            gbDetAtencion = new GroupBox();
            gbServicios = new GroupBox();
            lblSubtotalServicio = new Label();
            label9 = new Label();
            dgvServicioRealizado = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            duracionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoriaIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bsServicioRealizado = new BindingSource(components);
            lblEstadoAtencion = new Label();
            lblHora = new Label();
            lblFecha = new Label();
            lblNombreBarbero = new Label();
            lblNombreCliente = new Label();
            lblIdAtencion = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            gbProductos = new GroupBox();
            label13 = new Label();
            numeroCantidad = new NumericUpDown();
            lblSubtotalAtencion = new Label();
            label10 = new Label();
            dgvProductos = new DataGridView();
            cmbProductos = new ComboBox();
            btnAgregar = new Button();
            btnCancelar = new Button();
            btnConfirmar = new Button();
            label11 = new Label();
            lblTotalAtencion = new Label();
            label12 = new Label();
            cmbAtencionFinalizada = new ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)bsAtencionFinalizada).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAtencionFinalizada).BeginInit();
            gbDetAtencion.SuspendLayout();
            gbServicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServicioRealizado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsServicioRealizado).BeginInit();
            gbProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numeroCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // bsAtencionFinalizada
            // 
            bsAtencionFinalizada.DataSource = typeof(EstiloCordobaEntidades.Atencion);
            // 
            // dgvAtencionFinalizada
            // 
            dgvAtencionFinalizada.AutoGenerateColumns = false;
            dgvAtencionFinalizada.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAtencionFinalizada.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, fechaDataGridViewTextBoxColumn, horaDataGridViewTextBoxColumn, totalCalculadoDataGridViewTextBoxColumn, totalServiciosDataGridViewTextBoxColumn, totalProductosDataGridViewTextBoxColumn, idBarberoDataGridViewTextBoxColumn, idClienteDataGridViewTextBoxColumn, idTurnoDataGridViewTextBoxColumn, idEstadoDataGridViewTextBoxColumn, idMedioPagoDataGridViewTextBoxColumn });
            dgvAtencionFinalizada.DataSource = bsAtencionFinalizada;
            dgvAtencionFinalizada.Location = new Point(12, 38);
            dgvAtencionFinalizada.Name = "dgvAtencionFinalizada";
            dgvAtencionFinalizada.Size = new Size(862, 169);
            dgvAtencionFinalizada.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 1;
            label1.Text = "Atenciones finalizadas";
            // 
            // gbDetAtencion
            // 
            gbDetAtencion.Controls.Add(gbServicios);
            gbDetAtencion.Controls.Add(lblEstadoAtencion);
            gbDetAtencion.Controls.Add(lblHora);
            gbDetAtencion.Controls.Add(lblFecha);
            gbDetAtencion.Controls.Add(lblNombreBarbero);
            gbDetAtencion.Controls.Add(lblNombreCliente);
            gbDetAtencion.Controls.Add(lblIdAtencion);
            gbDetAtencion.Controls.Add(label7);
            gbDetAtencion.Controls.Add(label6);
            gbDetAtencion.Controls.Add(label5);
            gbDetAtencion.Controls.Add(label4);
            gbDetAtencion.Controls.Add(label3);
            gbDetAtencion.Controls.Add(label2);
            gbDetAtencion.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbDetAtencion.Location = new Point(12, 274);
            gbDetAtencion.Name = "gbDetAtencion";
            gbDetAtencion.Size = new Size(862, 419);
            gbDetAtencion.TabIndex = 2;
            gbDetAtencion.TabStop = false;
            gbDetAtencion.Text = "Detalles de la atencion";
            // 
            // gbServicios
            // 
            gbServicios.BackColor = SystemColors.Control;
            gbServicios.Controls.Add(lblSubtotalServicio);
            gbServicios.Controls.Add(label9);
            gbServicios.Controls.Add(dgvServicioRealizado);
            gbServicios.Location = new Point(6, 142);
            gbServicios.Name = "gbServicios";
            gbServicios.Size = new Size(850, 284);
            gbServicios.TabIndex = 12;
            gbServicios.TabStop = false;
            gbServicios.Text = "Servicios realizados";
            // 
            // lblSubtotalServicio
            // 
            lblSubtotalServicio.AutoSize = true;
            lblSubtotalServicio.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtotalServicio.Location = new Point(732, 253);
            lblSubtotalServicio.Name = "lblSubtotalServicio";
            lblSubtotalServicio.Size = new Size(17, 20);
            lblSubtotalServicio.TabIndex = 5;
            lblSubtotalServicio.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(646, 253);
            label9.Name = "label9";
            label9.Size = new Size(80, 20);
            label9.TabIndex = 4;
            label9.Text = "Subtotal: $";
            label9.Click += label9_Click;
            // 
            // dgvServicioRealizado
            // 
            dgvServicioRealizado.AutoGenerateColumns = false;
            dgvServicioRealizado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicioRealizado.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, nombreDataGridViewTextBoxColumn, precioDataGridViewTextBoxColumn, duracionDataGridViewTextBoxColumn, categoriaIdDataGridViewTextBoxColumn });
            dgvServicioRealizado.DataSource = bsServicioRealizado;
            dgvServicioRealizado.Location = new Point(6, 26);
            dgvServicioRealizado.Name = "dgvServicioRealizado";
            dgvServicioRealizado.Size = new Size(838, 224);
            dgvServicioRealizado.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // duracionDataGridViewTextBoxColumn
            // 
            duracionDataGridViewTextBoxColumn.DataPropertyName = "Duracion";
            duracionDataGridViewTextBoxColumn.HeaderText = "Duracion";
            duracionDataGridViewTextBoxColumn.Name = "duracionDataGridViewTextBoxColumn";
            // 
            // categoriaIdDataGridViewTextBoxColumn
            // 
            categoriaIdDataGridViewTextBoxColumn.DataPropertyName = "CategoriaId";
            categoriaIdDataGridViewTextBoxColumn.HeaderText = "CategoriaId";
            categoriaIdDataGridViewTextBoxColumn.Name = "categoriaIdDataGridViewTextBoxColumn";
            // 
            // bsServicioRealizado
            // 
            bsServicioRealizado.DataSource = typeof(EstiloCordobaEntidades.Servicio);
            // 
            // lblEstadoAtencion
            // 
            lblEstadoAtencion.AutoSize = true;
            lblEstadoAtencion.Location = new Point(449, 107);
            lblEstadoAtencion.Name = "lblEstadoAtencion";
            lblEstadoAtencion.Size = new Size(0, 20);
            lblEstadoAtencion.TabIndex = 11;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Location = new Point(449, 75);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(0, 20);
            lblHora.TabIndex = 10;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(449, 42);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(0, 20);
            lblFecha.TabIndex = 9;
            // 
            // lblNombreBarbero
            // 
            lblNombreBarbero.AutoSize = true;
            lblNombreBarbero.Location = new Point(77, 107);
            lblNombreBarbero.Name = "lblNombreBarbero";
            lblNombreBarbero.Size = new Size(0, 20);
            lblNombreBarbero.TabIndex = 8;
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Location = new Point(70, 75);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(0, 20);
            lblNombreCliente.TabIndex = 7;
            // 
            // lblIdAtencion
            // 
            lblIdAtencion.AutoSize = true;
            lblIdAtencion.Location = new Point(102, 42);
            lblIdAtencion.Name = "lblIdAtencion";
            lblIdAtencion.Size = new Size(0, 20);
            lblIdAtencion.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(393, 75);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 5;
            label7.Text = "Hora:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(393, 42);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 4;
            label6.Text = "Fecha:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 107);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 3;
            label5.Text = "Barbero:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(393, 107);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 2;
            label4.Text = "Estado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 42);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 1;
            label3.Text = "ID Atencion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 75);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 0;
            label2.Text = "Cliente:";
            // 
            // gbProductos
            // 
            gbProductos.Controls.Add(label13);
            gbProductos.Controls.Add(numeroCantidad);
            gbProductos.Controls.Add(lblSubtotalAtencion);
            gbProductos.Controls.Add(label10);
            gbProductos.Controls.Add(dgvProductos);
            gbProductos.Controls.Add(cmbProductos);
            gbProductos.Controls.Add(btnAgregar);
            gbProductos.Enabled = false;
            gbProductos.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbProductos.Location = new Point(12, 699);
            gbProductos.Name = "gbProductos";
            gbProductos.Size = new Size(862, 269);
            gbProductos.TabIndex = 3;
            gbProductos.TabStop = false;
            gbProductos.Text = "Agregar productos (Opcional)";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(593, 28);
            label13.Name = "label13";
            label13.Size = new Size(72, 20);
            label13.TabIndex = 7;
            label13.Text = "Cantidad:";
            // 
            // numeroCantidad
            // 
            numeroCantidad.Location = new Point(668, 25);
            numeroCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numeroCantidad.Name = "numeroCantidad";
            numeroCantidad.Size = new Size(94, 27);
            numeroCantidad.TabIndex = 6;
            numeroCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblSubtotalAtencion
            // 
            lblSubtotalAtencion.AutoSize = true;
            lblSubtotalAtencion.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtotalAtencion.Location = new Point(738, 242);
            lblSubtotalAtencion.Name = "lblSubtotalAtencion";
            lblSubtotalAtencion.Size = new Size(17, 20);
            lblSubtotalAtencion.TabIndex = 5;
            lblSubtotalAtencion.Text = "0";
            lblSubtotalAtencion.Click += lblSubtotalAtencion_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(652, 242);
            label10.Name = "label10";
            label10.Size = new Size(80, 20);
            label10.TabIndex = 4;
            label10.Text = "Subtotal: $";
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(6, 58);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(850, 181);
            dgvProductos.TabIndex = 3;
            // 
            // cmbProductos
            // 
            cmbProductos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProductos.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbProductos.FormattingEnabled = true;
            cmbProductos.Location = new Point(6, 27);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(560, 25);
            cmbProductos.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.RoyalBlue;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = SystemColors.Control;
            btnAgregar.Location = new Point(768, 26);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(82, 27);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Firebrick;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ControlLight;
            btnCancelar.Location = new Point(12, 974);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(198, 71);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.MediumSpringGreen;
            btnConfirmar.FlatStyle = FlatStyle.Popup;
            btnConfirmar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmar.ForeColor = Color.Black;
            btnConfirmar.Location = new Point(231, 974);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(360, 71);
            btnConfirmar.TabIndex = 4;
            btnConfirmar.Text = "CONFIRMAR";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(612, 992);
            label11.Name = "label11";
            label11.Size = new Size(79, 30);
            label11.TabIndex = 6;
            label11.Text = "Total: $";
            // 
            // lblTotalAtencion
            // 
            lblTotalAtencion.AutoSize = true;
            lblTotalAtencion.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAtencion.Location = new Point(697, 997);
            lblTotalAtencion.Name = "lblTotalAtencion";
            lblTotalAtencion.Size = new Size(22, 25);
            lblTotalAtencion.TabIndex = 7;
            lblTotalAtencion.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(12, 235);
            label12.Name = "label12";
            label12.Size = new Size(149, 20);
            label12.TabIndex = 8;
            label12.Text = "Seleccionar atencion:";
            // 
            // cmbAtencionFinalizada
            // 
            cmbAtencionFinalizada.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAtencionFinalizada.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbAtencionFinalizada.FormattingEnabled = true;
            cmbAtencionFinalizada.Location = new Point(167, 232);
            cmbAtencionFinalizada.Name = "cmbAtencionFinalizada";
            cmbAtencionFinalizada.Size = new Size(707, 28);
            cmbAtencionFinalizada.TabIndex = 9;
            cmbAtencionFinalizada.SelectedIndexChanged += cmbAtencionFinalizada_SelectedIndexChanged;
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
            // AtencionFinalizadas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(901, 523);
            Controls.Add(cmbAtencionFinalizada);
            Controls.Add(label12);
            Controls.Add(lblTotalAtencion);
            Controls.Add(label11);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(gbProductos);
            Controls.Add(gbDetAtencion);
            Controls.Add(label1);
            Controls.Add(dgvAtencionFinalizada);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AtencionFinalizadas";
            Text = "Atenciones finalizadas";
            Load += AtencionFinalizadas_Load;
            ((System.ComponentModel.ISupportInitialize)bsAtencionFinalizada).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAtencionFinalizada).EndInit();
            gbDetAtencion.ResumeLayout(false);
            gbDetAtencion.PerformLayout();
            gbServicios.ResumeLayout(false);
            gbServicios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServicioRealizado).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsServicioRealizado).EndInit();
            gbProductos.ResumeLayout(false);
            gbProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numeroCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bsAtencionFinalizada;
        private DataGridView dgvAtencionFinalizada;
        private Label label1;
        private GroupBox gbDetAtencion;
        private Label label2;
        private Label lblEstadoAtencion;
        private Label lblHora;
        private Label lblFecha;
        private Label lblNombreBarbero;
        private Label lblNombreCliente;
        private Label lblIdAtencion;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private GroupBox gbServicios;
        private DataGridView dgvServicioRealizado;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn duracionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoriaIdDataGridViewTextBoxColumn;
        private BindingSource bsServicioRealizado;
        private GroupBox gbProductos;
        private Button btnAgregar;
        private Label label9;
        private DataGridView dgvProductos;
        private ComboBox cmbProductos;
        private Label lblSubtotalServicio;
        private Label lblSubtotalAtencion;
        private Label label10;
        private Button btnConfirmar;
        private Button btnCancelar;
        private Label label11;
        private Label lblTotalAtencion;
        private Label label12;
        private ComboBox cmbAtencionFinalizada;
        private NumericUpDown numeroCantidad;
        private Label label13;
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