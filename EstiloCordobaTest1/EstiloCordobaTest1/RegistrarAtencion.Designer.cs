namespace EstiloCordobaPresentacion
{
    partial class RegistrarAtencion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarAtencion));
            cmbTurno = new ComboBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtTotalServicio = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txtHorario = new TextBox();
            txtFechaPact = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtNombreCliente = new TextBox();
            txtIdCliente = new TextBox();
            dgvServiciosTurno = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            duracionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoriaIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bsServiciosTurno = new BindingSource(components);
            btnAceptar = new Button();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            label9 = new Label();
            cmbBarbero = new ComboBox();
            label10 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServiciosTurno).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsServiciosTurno).BeginInit();
            SuspendLayout();
            // 
            // cmbTurno
            // 
            cmbTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTurno.FormattingEnabled = true;
            cmbTurno.Location = new Point(160, 30);
            cmbTurno.Name = "cmbTurno";
            cmbTurno.Size = new Size(455, 23);
            cmbTurno.TabIndex = 0;
            cmbTurno.SelectedIndexChanged += cmbTurno_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 1;
            label1.Text = "Seleccione un turno:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(txtTotalServicio);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtHorario);
            groupBox1.Controls.Add(txtFechaPact);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNombreCliente);
            groupBox1.Controls.Add(txtIdCliente);
            groupBox1.Controls.Add(dgvServiciosTurno);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(684, 374);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del turno";
            // 
            // txtTotalServicio
            // 
            txtTotalServicio.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotalServicio.Location = new Point(135, 336);
            txtTotalServicio.Name = "txtTotalServicio";
            txtTotalServicio.ReadOnly = true;
            txtTotalServicio.Size = new Size(420, 27);
            txtTotalServicio.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 339);
            label8.Name = "label8";
            label8.Size = new Size(117, 20);
            label8.TabIndex = 11;
            label8.Text = "Total servicios $:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 151);
            label7.Name = "label7";
            label7.Size = new Size(167, 20);
            label7.TabIndex = 10;
            label7.Text = "Servicios seleccionados:";
            // 
            // txtHorario
            // 
            txtHorario.Location = new Point(449, 93);
            txtHorario.Name = "txtHorario";
            txtHorario.ReadOnly = true;
            txtHorario.Size = new Size(154, 27);
            txtHorario.TabIndex = 9;
            // 
            // txtFechaPact
            // 
            txtFechaPact.Location = new Point(449, 33);
            txtFechaPact.Name = "txtFechaPact";
            txtFechaPact.ReadOnly = true;
            txtFechaPact.Size = new Size(154, 27);
            txtFechaPact.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(380, 96);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 7;
            label6.Text = "Horario:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(335, 36);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 6;
            label5.Text = "Fecha pactada:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 96);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 5;
            label4.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 79);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 36);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 3;
            label2.Text = "Id Cliente:";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(93, 93);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.ReadOnly = true;
            txtNombreCliente.Size = new Size(194, 27);
            txtNombreCliente.TabIndex = 2;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(93, 33);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.ReadOnly = true;
            txtIdCliente.Size = new Size(194, 27);
            txtIdCliente.TabIndex = 1;
            // 
            // dgvServiciosTurno
            // 
            dgvServiciosTurno.AutoGenerateColumns = false;
            dgvServiciosTurno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServiciosTurno.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, precioDataGridViewTextBoxColumn, duracionDataGridViewTextBoxColumn, categoriaIdDataGridViewTextBoxColumn });
            dgvServiciosTurno.DataSource = bsServiciosTurno;
            dgvServiciosTurno.Location = new Point(12, 174);
            dgvServiciosTurno.Name = "dgvServiciosTurno";
            dgvServiciosTurno.ReadOnly = true;
            dgvServiciosTurno.Size = new Size(543, 150);
            dgvServiciosTurno.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
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
            // bsServiciosTurno
            // 
            bsServiciosTurno.DataSource = typeof(EstiloCordobaEntidades.Servicio);
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(128, 255, 255);
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.FlatStyle = FlatStyle.Popup;
            btnAceptar.Location = new Point(621, 30);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(128, 255, 128);
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatStyle = FlatStyle.Popup;
            btnRegistrar.Location = new Point(230, 568);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(469, 81);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 128, 128);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Location = new Point(12, 568);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(184, 81);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(22, 473);
            label9.Name = "label9";
            label9.Size = new Size(119, 20);
            label9.TabIndex = 6;
            label9.Text = "Asignar barbero:";
            // 
            // cmbBarbero
            // 
            cmbBarbero.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBarbero.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbBarbero.FormattingEnabled = true;
            cmbBarbero.Location = new Point(147, 470);
            cmbBarbero.Name = "cmbBarbero";
            cmbBarbero.Size = new Size(468, 28);
            cmbBarbero.TabIndex = 7;
            cmbBarbero.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(22, 536);
            label10.Name = "label10";
            label10.Size = new Size(372, 15);
            label10.TabIndex = 8;
            label10.Text = "* Los productos adicionales se agregan una vez finalizada la atencion.";
            // 
            // RegistrarAtencion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 661);
            Controls.Add(label10);
            Controls.Add(cmbBarbero);
            Controls.Add(label9);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrar);
            Controls.Add(btnAceptar);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(cmbTurno);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "RegistrarAtencion";
            Text = "Registrar atencion";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServiciosTurno).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsServiciosTurno).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbTurno;
        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dgvServiciosTurno;
        private Button btnAceptar;
        private TextBox txtNombreCliente;
        private TextBox txtIdCliente;
        private BindingSource bsServiciosTurno;
        private Label label3;
        private Label label2;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn duracionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoriaIdDataGridViewTextBoxColumn;
        private Label label7;
        private TextBox txtHorario;
        private TextBox txtFechaPact;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtTotalServicio;
        private Label label8;
        private Button btnRegistrar;
        private Button btnCancelar;
        private Label label9;
        private ComboBox cmbBarbero;
        private Label label10;
    }
}