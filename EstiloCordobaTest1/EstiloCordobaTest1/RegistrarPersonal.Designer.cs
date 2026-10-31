namespace EstiloCordobaPresentacion
{
    partial class RegistrarPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarPersonal));
            btnRegistrar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtDomicilio = new TextBox();
            txtTelefono = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtClave = new TextBox();
            label5 = new Label();
            txtConfirmarClave = new TextBox();
            cmbRol = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            txtEmail = new TextBox();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(128, 255, 128);
            btnRegistrar.FlatStyle = FlatStyle.Popup;
            btnRegistrar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(189, 569);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(195, 49);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 128, 128);
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(12, 569);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(132, 49);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(12, 42);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(369, 29);
            txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 93);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 4;
            label2.Text = "Domicilio";
            // 
            // txtDomicilio
            // 
            txtDomicilio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDomicilio.Location = new Point(12, 117);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(369, 29);
            txtDomicilio.TabIndex = 5;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(12, 196);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(180, 29);
            txtTelefono.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 172);
            label3.Name = "label3";
            label3.Size = new Size(68, 21);
            label3.TabIndex = 7;
            label3.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 408);
            label4.Name = "label4";
            label4.Size = new Size(48, 21);
            label4.TabIndex = 8;
            label4.Text = "Clave";
            // 
            // txtClave
            // 
            txtClave.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClave.Location = new Point(12, 432);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '●';
            txtClave.Size = new Size(219, 25);
            txtClave.TabIndex = 9;
            txtClave.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 474);
            label5.Name = "label5";
            label5.Size = new Size(120, 21);
            label5.TabIndex = 10;
            label5.Text = "Confirmar clave";
            // 
            // txtConfirmarClave
            // 
            txtConfirmarClave.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmarClave.Location = new Point(12, 498);
            txtConfirmarClave.Name = "txtConfirmarClave";
            txtConfirmarClave.PasswordChar = '●';
            txtConfirmarClave.Size = new Size(219, 25);
            txtConfirmarClave.TabIndex = 11;
            txtConfirmarClave.UseSystemPasswordChar = true;
            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(12, 349);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(219, 29);
            cmbRol.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 325);
            label6.Name = "label6";
            label6.Size = new Size(100, 21);
            label6.TabIndex = 13;
            label6.Text = "Rol asignado";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 249);
            label7.Name = "label7";
            label7.Size = new Size(48, 21);
            label7.TabIndex = 14;
            label7.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(12, 273);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(369, 29);
            txtEmail.TabIndex = 15;
            // 
            // RegistrarPersonal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 630);
            Controls.Add(txtEmail);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(cmbRol);
            Controls.Add(txtConfirmarClave);
            Controls.Add(label5);
            Controls.Add(txtClave);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtTelefono);
            Controls.Add(txtDomicilio);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegistrarPersonal";
            Text = "Registrar personal";
            Load += RegistrarPersonal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrar;
        private Button btnCancelar;
        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtDomicilio;
        private TextBox txtTelefono;
        private Label label3;
        private Label label4;
        private TextBox txtClave;
        private Label label5;
        private TextBox txtConfirmarClave;
        private ComboBox cmbRol;
        private Label label6;
        private Label label7;
        private TextBox txtEmail;
    }
}