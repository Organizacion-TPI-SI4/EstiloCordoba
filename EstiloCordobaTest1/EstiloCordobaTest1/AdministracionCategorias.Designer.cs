namespace EstiloCordobaPresentacion
{
    partial class AdministracionCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministracionCategorias));
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            btnRegistrar = new Button();
            btnModificar = new Button();
            txtBuscar = new TextBox();
            dgvCategorias = new DataGridView();
            bsCategorias = new BindingSource(components);
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsCategorias).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(btnRegistrar);
            flowLayoutPanel1.Controls.Add(btnModificar);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(184, 450);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(13, 13);
            button1.Name = "button1";
            button1.Size = new Size(153, 52);
            button1.TabIndex = 0;
            button1.Text = "Consultar categorias";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(13, 71);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(153, 52);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(13, 129);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(153, 51);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(200, 12);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar...";
            txtBuscar.Size = new Size(344, 23);
            txtBuscar.TabIndex = 1;
            // 
            // dgvCategorias
            // 
            dgvCategorias.AllowUserToAddRows = false;
            dgvCategorias.AllowUserToDeleteRows = false;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(200, 50);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.Size = new Size(344, 388);
            dgvCategorias.TabIndex = 2;
            dgvCategorias.CellContentClick += dgvCategorias_CellContentClick;
            // 
            // bsCategorias
            // 
            bsCategorias.DataSource = typeof(EstiloCordobaEntidades.Categoria);
            // 
            // AdministracionCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 450);
            Controls.Add(dgvCategorias);
            Controls.Add(txtBuscar);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AdministracionCategorias";
            Text = "Administracion de categorias";
            Load += AdministracionCategorias_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox txtBuscar;
        private DataGridView dgvCategorias;
        private Button button1;
        private Button btnRegistrar;
        private Button btnModificar;
        private BindingSource bsCategorias;
    }
}