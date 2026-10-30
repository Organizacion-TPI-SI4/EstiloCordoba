namespace EstiloCordobaPresentacion
{
    partial class RegistrarServicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarServicio));
            label1 = new Label();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            txtNombre = new TextBox();
            label2 = new Label();
            txtPrecio = new TextBox();
            label3 = new Label();
            cmbCategoria = new ComboBox();
            label4 = new Label();
            numericUD1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUD1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(71, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            label1.Click += label1_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(128, 255, 128);
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatStyle = FlatStyle.Popup;
            btnRegistrar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(154, 328);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(202, 49);
            btnRegistrar.TabIndex = 1;
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
            btnCancelar.Location = new Point(12, 328);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(113, 49);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(12, 55);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(344, 27);
            txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 93);
            label2.Name = "label2";
            label2.Size = new Size(165, 21);
            label2.TabIndex = 4;
            label2.Text = "Duracion (en minutos)";
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecio.Location = new Point(12, 184);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(165, 27);
            txtPrecio.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 160);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 7;
            label3.Text = "Precio:";
            // 
            // cmbCategoria
            // 
            cmbCategoria.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(12, 252);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(165, 28);
            cmbCategoria.TabIndex = 8;
            cmbCategoria.SelectedIndexChanged += cmbCategoria_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 228);
            label4.Name = "label4";
            label4.Size = new Size(80, 21);
            label4.TabIndex = 9;
            label4.Text = "Categoria:";
            // 
            // numericUD1
            // 
            numericUD1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUD1.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            numericUD1.Location = new Point(12, 117);
            numericUD1.Name = "numericUD1";
            numericUD1.Size = new Size(165, 27);
            numericUD1.TabIndex = 10;
            numericUD1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // RegistrarServicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 388);
            Controls.Add(numericUD1);
            Controls.Add(label4);
            Controls.Add(cmbCategoria);
            Controls.Add(label3);
            Controls.Add(txtPrecio);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "RegistrarServicio";
            Text = "Registrar servicio";
            Load += RegistrarServicio_Load;
            ((System.ComponentModel.ISupportInitialize)numericUD1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnRegistrar;
        private Button btnCancelar;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtPrecio;
        private Label label3;
        private ComboBox cmbCategoria;
        private Label label4;
        private NumericUpDown numericUD1;
    }
}