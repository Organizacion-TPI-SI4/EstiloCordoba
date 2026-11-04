namespace EstiloCordobaPresentacion
{
    partial class RegistrarTurno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarTurno));
            label1 = new Label();
            cmbCliente = new ComboBox();
            dtpFecha = new DateTimePicker();
            label2 = new Label();
            btnAgregarCliente = new Button();
            label3 = new Label();
            label4 = new Label();
            cmbServicio = new ComboBox();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            dgvServicios = new DataGridView();
            bsServicios = new BindingSource(components);
            btnAgregarServicio = new Button();
            label5 = new Label();
            txtHora = new TextBox();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvServicios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsServicios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Cliente:";
            // 
            // cmbCliente
            // 
            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(76, 19);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(319, 23);
            cmbCliente.TabIndex = 1;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(132, 70);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(263, 23);
            dtpFecha.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 72);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 3;
            label2.Text = "Fecha del turno:";
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.BackColor = Color.FromArgb(255, 224, 192);
            btnAgregarCliente.Cursor = Cursors.Hand;
            btnAgregarCliente.FlatStyle = FlatStyle.Popup;
            btnAgregarCliente.Location = new Point(586, 13);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(98, 35);
            btnAgregarCliente.TabIndex = 4;
            btnAgregarCliente.Text = "Agregar cliente";
            btnAgregarCliente.UseVisualStyleBackColor = false;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(467, 24);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 5;
            label3.Text = "Cliente sin registrar?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 171);
            label4.Name = "label4";
            label4.Size = new Size(128, 17);
            label4.TabIndex = 6;
            label4.Text = "Servicios solicitados:";
            // 
            // cmbServicio
            // 
            cmbServicio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbServicio.FormattingEnabled = true;
            cmbServicio.Location = new Point(146, 170);
            cmbServicio.Name = "cmbServicio";
            cmbServicio.Size = new Size(249, 23);
            cmbServicio.TabIndex = 7;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(128, 255, 128);
            btnRegistrar.FlatStyle = FlatStyle.Popup;
            btnRegistrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(282, 448);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(402, 64);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "REGISTRAR TURNO";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 128, 128);
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(12, 448);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(194, 64);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dgvServicios
            // 
            dgvServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicios.Location = new Point(47, 212);
            dgvServicios.Name = "dgvServicios";
            dgvServicios.Size = new Size(599, 215);
            dgvServicios.TabIndex = 10;
            // 
            // bsServicios
            // 
            bsServicios.DataSource = typeof(EstiloCordobaEntidades.Servicio);
            // 
            // btnAgregarServicio
            // 
            btnAgregarServicio.BackColor = Color.FromArgb(128, 190, 255);
            btnAgregarServicio.FlatStyle = FlatStyle.Popup;
            btnAgregarServicio.Location = new Point(416, 170);
            btnAgregarServicio.Name = "btnAgregarServicio";
            btnAgregarServicio.Size = new Size(113, 23);
            btnAgregarServicio.TabIndex = 11;
            btnAgregarServicio.Text = "Agregar servicio";
            btnAgregarServicio.UseVisualStyleBackColor = false;
            btnAgregarServicio.Click += btnAgregarServicio_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 123);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 12;
            label5.Text = "Horario:";
            // 
            // txtHora
            // 
            txtHora.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHora.Location = new Point(81, 120);
            txtHora.Name = "txtHora";
            txtHora.PlaceholderText = "HH:mm";
            txtHora.Size = new Size(59, 27);
            txtHora.TabIndex = 13;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.Highlight;
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.FlatStyle = FlatStyle.Popup;
            btnActualizar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = SystemColors.ControlLightLight;
            btnActualizar.Location = new Point(401, 17);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(29, 30);
            btnActualizar.TabIndex = 14;
            btnActualizar.Text = "⟳";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // RegistrarTurno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 524);
            Controls.Add(btnActualizar);
            Controls.Add(txtHora);
            Controls.Add(label5);
            Controls.Add(btnAgregarServicio);
            Controls.Add(dgvServicios);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrar);
            Controls.Add(cmbServicio);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnAgregarCliente);
            Controls.Add(label2);
            Controls.Add(dtpFecha);
            Controls.Add(cmbCliente);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "RegistrarTurno";
            Text = "Registrar turno";
            Load += RegistrarTurno_Load;
            ((System.ComponentModel.ISupportInitialize)dgvServicios).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsServicios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbCliente;
        private DateTimePicker dtpFecha;
        private Label label2;
        private Button btnAgregarCliente;
        private Label label3;
        private Label label4;
        private ComboBox cmbServicio;
        private Button btnRegistrar;
        private Button btnCancelar;
        private DataGridView dgvServicios;
        private BindingSource bsServicios;
        private Button btnAgregarServicio;
        private Label label5;
        private TextBox txtHora;
        private Button btnActualizar;
    }
}