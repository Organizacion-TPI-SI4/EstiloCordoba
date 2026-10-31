namespace EstiloCordobaPresentacion
{
    partial class RegistrarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarCliente));
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtNumeroDni = new TextBox();
            cmbTipoDni = new ComboBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            txtLocalidad = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            groupBox1 = new GroupBox();
            rbTwitter = new RadioButton();
            rbInstagram = new RadioButton();
            rbFacebook = new RadioButton();
            txtRedSocial = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.Location = new Point(12, 52);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ingrese nombre...";
            txtNombre.Size = new Size(386, 29);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 12F);
            txtApellido.Location = new Point(13, 121);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Ingrese apellido...";
            txtApellido.Size = new Size(385, 29);
            txtApellido.TabIndex = 1;
            // 
            // txtNumeroDni
            // 
            txtNumeroDni.Font = new Font("Segoe UI", 12F);
            txtNumeroDni.Location = new Point(12, 261);
            txtNumeroDni.Name = "txtNumeroDni";
            txtNumeroDni.PlaceholderText = "Ingrese DNI...";
            txtNumeroDni.Size = new Size(204, 29);
            txtNumeroDni.TabIndex = 2;
            // 
            // cmbTipoDni
            // 
            cmbTipoDni.Font = new Font("Segoe UI", 12F);
            cmbTipoDni.FormattingEnabled = true;
            cmbTipoDni.Location = new Point(13, 192);
            cmbTipoDni.Name = "cmbTipoDni";
            cmbTipoDni.Size = new Size(114, 29);
            cmbTipoDni.TabIndex = 3;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 12F);
            txtTelefono.Location = new Point(13, 326);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Ingrese numero de telefono...";
            txtTelefono.Size = new Size(203, 29);
            txtTelefono.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(13, 392);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Ingrese Email...";
            txtEmail.Size = new Size(385, 29);
            txtEmail.TabIndex = 5;
            // 
            // txtLocalidad
            // 
            txtLocalidad.Font = new Font("Segoe UI", 12F);
            txtLocalidad.Location = new Point(13, 460);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.PlaceholderText = "Ingrese localidad...";
            txtLocalidad.Size = new Size(385, 29);
            txtLocalidad.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 7;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(13, 97);
            label2.Name = "label2";
            label2.Size = new Size(67, 21);
            label2.TabIndex = 8;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(13, 168);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 9;
            label3.Text = "Tipo de DNI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(13, 237);
            label4.Name = "label4";
            label4.Size = new Size(120, 21);
            label4.TabIndex = 10;
            label4.Text = "Numero de DNI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(12, 302);
            label5.Name = "label5";
            label5.Size = new Size(68, 21);
            label5.TabIndex = 11;
            label5.Text = "Telefono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(13, 368);
            label6.Name = "label6";
            label6.Size = new Size(48, 21);
            label6.TabIndex = 12;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(12, 436);
            label7.Name = "label7";
            label7.Size = new Size(76, 21);
            label7.TabIndex = 13;
            label7.Text = "Localidad";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.LimeGreen;
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatStyle = FlatStyle.Popup;
            btnRegistrar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(174, 679);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(224, 57);
            btnRegistrar.TabIndex = 14;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 128, 128);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(12, 679);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 57);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbTwitter);
            groupBox1.Controls.Add(rbInstagram);
            groupBox1.Controls.Add(rbFacebook);
            groupBox1.Controls.Add(txtRedSocial);
            groupBox1.Location = new Point(16, 510);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(382, 153);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Red social (Opcional)";
            // 
            // rbTwitter
            // 
            rbTwitter.AutoSize = true;
            rbTwitter.Font = new Font("Segoe UI", 9.75F);
            rbTwitter.Location = new Point(13, 85);
            rbTwitter.Name = "rbTwitter";
            rbTwitter.Size = new Size(64, 21);
            rbTwitter.TabIndex = 3;
            rbTwitter.TabStop = true;
            rbTwitter.Text = "Twitter";
            rbTwitter.UseVisualStyleBackColor = true;
            // 
            // rbInstagram
            // 
            rbInstagram.AutoSize = true;
            rbInstagram.Font = new Font("Segoe UI", 9.75F);
            rbInstagram.Location = new Point(13, 58);
            rbInstagram.Name = "rbInstagram";
            rbInstagram.Size = new Size(84, 21);
            rbInstagram.TabIndex = 2;
            rbInstagram.TabStop = true;
            rbInstagram.Text = "Instagram";
            rbInstagram.UseVisualStyleBackColor = true;
            // 
            // rbFacebook
            // 
            rbFacebook.AutoSize = true;
            rbFacebook.Font = new Font("Segoe UI", 9.75F);
            rbFacebook.Location = new Point(13, 31);
            rbFacebook.Name = "rbFacebook";
            rbFacebook.Size = new Size(82, 21);
            rbFacebook.TabIndex = 1;
            rbFacebook.TabStop = true;
            rbFacebook.Text = "Facebook";
            rbFacebook.UseVisualStyleBackColor = true;
            // 
            // txtRedSocial
            // 
            txtRedSocial.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRedSocial.Location = new Point(11, 118);
            txtRedSocial.Name = "txtRedSocial";
            txtRedSocial.PlaceholderText = "Ingrese @...";
            txtRedSocial.Size = new Size(365, 29);
            txtRedSocial.TabIndex = 0;
            // 
            // RegistrarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 748);
            Controls.Add(groupBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrar);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLocalidad);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(cmbTipoDni);
            Controls.Add(txtNumeroDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "RegistrarCliente";
            Text = "Registrar cliente";
            Load += RegistrarCliente_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtNumeroDni;
        private ComboBox cmbTipoDni;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private TextBox txtLocalidad;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnRegistrar;
        private Button btnCancelar;
        private GroupBox groupBox1;
        private RadioButton rbTwitter;
        private RadioButton rbInstagram;
        private RadioButton rbFacebook;
        private TextBox txtRedSocial;
    }
}