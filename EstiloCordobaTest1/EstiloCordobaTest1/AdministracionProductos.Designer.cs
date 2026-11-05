namespace EstiloCordobaPresentacion
{
    partial class AdministracionProductos
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
            DataGridViewCellStyle estiloPrecio =
                new DataGridViewCellStyle();

            lblTitulo = new Label();
            dgvProductos = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colMarca = new DataGridViewTextBoxColumn();
            colPrecioVenta = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            btnConsultar = new Button();
            btnRegistrar = new Button();
            btnModificar = new Button();

            ((System.ComponentModel.ISupportInitialize)dgvProductos)
                .BeginInit();

            SuspendLayout();

            // lblTitulo
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font(
                "Segoe UI",
                16F,
                FontStyle.Bold);

            lblTitulo.Location = new Point(30, 22);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(294, 37);
            lblTitulo.Text = "Administrar productos";

            // dgvProductos
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AutoGenerateColumns = false;
            dgvProductos.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dgvProductos.Columns.AddRange(
                colId,
                colNombre,
                colMarca,
                colPrecioVenta,
                colStock);

            dgvProductos.Location = new Point(30, 80);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvProductos.Size = new Size(800, 335);

            // colId
            colId.DataPropertyName = "Id";
            colId.HeaderText = "ID";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 60;

            // colNombre
            colNombre.AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;

            colNombre.DataPropertyName = "Nombre";
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;

            // colMarca
            colMarca.DataPropertyName = "Marca";
            colMarca.HeaderText = "Marca";
            colMarca.MinimumWidth = 6;
            colMarca.Name = "colMarca";
            colMarca.ReadOnly = true;
            colMarca.Width = 180;

            // colPrecioVenta
            colPrecioVenta.DataPropertyName = "PrecioVenta";
            estiloPrecio.Format = "C2";
            estiloPrecio.FormatProvider =
    new System.Globalization.CultureInfo("es-AR");
            estiloPrecio.NullValue = null;
            colPrecioVenta.DefaultCellStyle = estiloPrecio;
            colPrecioVenta.HeaderText = "Precio de venta";
            colPrecioVenta.MinimumWidth = 6;
            colPrecioVenta.Name = "colPrecioVenta";
            colPrecioVenta.ReadOnly = true;
            colPrecioVenta.Width = 160;

            // colStock
            colStock.DataPropertyName = "Stock";
            colStock.HeaderText = "Stock";
            colStock.MinimumWidth = 6;
            colStock.Name = "colStock";
            colStock.ReadOnly = true;
            colStock.Width = 100;

            // btnConsultar
            btnConsultar.Location = new Point(30, 440);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(130, 42);
            btnConsultar.Text = "Actualizar";
            btnConsultar.UseVisualStyleBackColor = true;

            // btnRegistrar
            btnRegistrar.Location = new Point(550, 440);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(130, 42);
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;

            // btnModificar
            btnModificar.Enabled = false;
            btnModificar.Location = new Point(700, 440);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(130, 42);
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;

            // AdministracionProductos
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 510);
            Controls.Add(lblTitulo);
            Controls.Add(dgvProductos);
            Controls.Add(btnConsultar);
            Controls.Add(btnRegistrar);
            Controls.Add(btnModificar);
            MinimumSize = new Size(878, 557);
            Name = "AdministracionProductos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Administración de productos";

            ((System.ComponentModel.ISupportInitialize)dgvProductos)
                .EndInit();

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private DataGridView dgvProductos;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colMarca;
        private DataGridViewTextBoxColumn colPrecioVenta;
        private DataGridViewTextBoxColumn colStock;
        private Button btnConsultar;
        private Button btnRegistrar;
        private Button btnModificar;
    }
}