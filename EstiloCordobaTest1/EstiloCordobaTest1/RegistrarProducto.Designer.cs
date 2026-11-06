namespace EstiloCordobaPresentacion
{
    partial class RegistrarProducto
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblMarca = new Label();
            txtMarca = new TextBox();
            lblPrecioVenta = new Label();
            nudPrecioVenta = new NumericUpDown();
            lblStock = new Label();
            nudStock = new NumericUpDown();
            btnRegistrar = new Button();
            btnCancelar = new Button();

            ((System.ComponentModel.ISupportInitialize)nudPrecioVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            SuspendLayout();

            // lblTitulo
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(30, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(219, 37);
            lblTitulo.Text = "Registrar producto";

            // lblNombre
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F);
            lblNombre.Location = new Point(35, 95);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(76, 23);
            lblNombre.Text = "Nombre:";

            // txtNombre
            txtNombre.Location = new Point(185, 92);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(285, 27);

            // lblMarca
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI", 10F);
            lblMarca.Location = new Point(35, 145);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(61, 23);
            lblMarca.Text = "Marca:";

            // txtMarca
            txtMarca.Location = new Point(185, 142);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(285, 27);

            // lblPrecioVenta
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.Font = new Font("Segoe UI", 10F);
            lblPrecioVenta.Location = new Point(35, 195);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(132, 23);
            lblPrecioVenta.Text = "Precio de venta:";

            // nudPrecioVenta
            nudPrecioVenta.DecimalPlaces = 2;
            nudPrecioVenta.Location = new Point(185, 192);
            nudPrecioVenta.Maximum = new decimal(
                new int[] { 100000000, 0, 0, 0 });
            nudPrecioVenta.Name = "nudPrecioVenta";
            nudPrecioVenta.Size = new Size(285, 27);
            nudPrecioVenta.ThousandsSeparator = true;

            // lblStock
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 10F);
            lblStock.Location = new Point(35, 245);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(106, 23);
            lblStock.Text = "Stock inicial:";

            // nudStock
            nudStock.Location = new Point(185, 242);
            nudStock.Maximum = new decimal(
                new int[] { 100000, 0, 0, 0 });
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(285, 27);

            // btnRegistrar
            btnRegistrar.Location = new Point(185, 305);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(130, 42);
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;

            // btnCancelar
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(340, 305);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 42);
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;

            // RegistrarProducto
            AcceptButton = btnRegistrar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(510, 380);
            Controls.Add(lblTitulo);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblMarca);
            Controls.Add(txtMarca);
            Controls.Add(lblPrecioVenta);
            Controls.Add(nudPrecioVenta);
            Controls.Add(lblStock);
            Controls.Add(nudStock);
            Controls.Add(btnRegistrar);
            Controls.Add(btnCancelar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegistrarProducto";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registrar producto";

            ((System.ComponentModel.ISupportInitialize)nudPrecioVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblMarca;
        private TextBox txtMarca;
        private Label lblPrecioVenta;
        private NumericUpDown nudPrecioVenta;
        private Label lblStock;
        private NumericUpDown nudStock;
        private Button btnRegistrar;
        private Button btnCancelar;
    }
}