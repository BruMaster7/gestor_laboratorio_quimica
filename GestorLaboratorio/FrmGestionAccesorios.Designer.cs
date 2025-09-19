namespace GestorLaboratorio
{
    partial class FrmGestionAccesorios
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
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbCategoriaGestionAcc = new ComboBox();
            txtDescripcionGestionAcc = new RichTextBox();
            nudStockGestionAcc = new NumericUpDown();
            txtUbicacionGestionAcc = new TextBox();
            txtNombreGestionAcc = new TextBox();
            dgvAccesorios = new DataGridView();
            btnActualizarGestionAcc = new Button();
            btnEliminarGestionAcc = new Button();
            label5 = new Label();
            label26 = new Label();
            txtFiltroNombre = new TextBox();
            label7 = new Label();
            label8 = new Label();
            btnBuscar = new Button();
            btnSinFiltro = new Button();
            ((System.ComponentModel.ISupportInitialize)nudStockGestionAcc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAccesorios).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(142, 334);
            label6.Name = "label6";
            label6.Size = new Size(112, 25);
            label6.TabIndex = 69;
            label6.Text = "Descripción";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(56, 256);
            label4.Name = "label4";
            label4.Size = new Size(64, 25);
            label4.TabIndex = 68;
            label4.Text = "Stock:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(20, 201);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 67;
            label3.Text = "Categoría:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(19, 144);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 66;
            label2.Text = "Ubicación:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(32, 94);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 65;
            label1.Text = "Nombre:\r\n";
            // 
            // cmbCategoriaGestionAcc
            // 
            cmbCategoriaGestionAcc.BackColor = Color.SandyBrown;
            cmbCategoriaGestionAcc.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategoriaGestionAcc.FormattingEnabled = true;
            cmbCategoriaGestionAcc.Items.AddRange(new object[] { "Vidriería", "Material metálico", "Plásticos y descartables", "Instrumentos de medición", "Accesorios de calentamiento", "Otros", "" });
            cmbCategoriaGestionAcc.Location = new Point(126, 205);
            cmbCategoriaGestionAcc.Name = "cmbCategoriaGestionAcc";
            cmbCategoriaGestionAcc.Size = new Size(246, 24);
            cmbCategoriaGestionAcc.TabIndex = 64;
            // 
            // txtDescripcionGestionAcc
            // 
            txtDescripcionGestionAcc.BackColor = Color.SandyBrown;
            txtDescripcionGestionAcc.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcionGestionAcc.Location = new Point(66, 362);
            txtDescripcionGestionAcc.Name = "txtDescripcionGestionAcc";
            txtDescripcionGestionAcc.Size = new Size(271, 87);
            txtDescripcionGestionAcc.TabIndex = 63;
            txtDescripcionGestionAcc.Text = "";
            // 
            // nudStockGestionAcc
            // 
            nudStockGestionAcc.BackColor = Color.SandyBrown;
            nudStockGestionAcc.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudStockGestionAcc.Location = new Point(126, 261);
            nudStockGestionAcc.Name = "nudStockGestionAcc";
            nudStockGestionAcc.Size = new Size(78, 22);
            nudStockGestionAcc.TabIndex = 62;
            // 
            // txtUbicacionGestionAcc
            // 
            txtUbicacionGestionAcc.BackColor = Color.SandyBrown;
            txtUbicacionGestionAcc.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUbicacionGestionAcc.Location = new Point(126, 149);
            txtUbicacionGestionAcc.Name = "txtUbicacionGestionAcc";
            txtUbicacionGestionAcc.Size = new Size(246, 22);
            txtUbicacionGestionAcc.TabIndex = 61;
            // 
            // txtNombreGestionAcc
            // 
            txtNombreGestionAcc.BackColor = Color.SandyBrown;
            txtNombreGestionAcc.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreGestionAcc.Location = new Point(126, 99);
            txtNombreGestionAcc.Name = "txtNombreGestionAcc";
            txtNombreGestionAcc.Size = new Size(246, 22);
            txtNombreGestionAcc.TabIndex = 60;
            // 
            // dgvAccesorios
            // 
            dgvAccesorios.BackgroundColor = Color.SaddleBrown;
            dgvAccesorios.BorderStyle = BorderStyle.Fixed3D;
            dgvAccesorios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccesorios.Location = new Point(378, 27);
            dgvAccesorios.Name = "dgvAccesorios";
            dgvAccesorios.RowHeadersVisible = false;
            dgvAccesorios.Size = new Size(577, 422);
            dgvAccesorios.TabIndex = 70;
            // 
            // btnActualizarGestionAcc
            // 
            btnActualizarGestionAcc.BackColor = Color.Olive;
            btnActualizarGestionAcc.FlatStyle = FlatStyle.Popup;
            btnActualizarGestionAcc.ForeColor = SystemColors.ButtonFace;
            btnActualizarGestionAcc.Location = new Point(66, 475);
            btnActualizarGestionAcc.Name = "btnActualizarGestionAcc";
            btnActualizarGestionAcc.Size = new Size(125, 32);
            btnActualizarGestionAcc.TabIndex = 71;
            btnActualizarGestionAcc.Text = "Actualizar";
            btnActualizarGestionAcc.UseVisualStyleBackColor = false;
            btnActualizarGestionAcc.Click += btnActualizarGestionAcc_Click;
            // 
            // btnEliminarGestionAcc
            // 
            btnEliminarGestionAcc.BackColor = Color.Maroon;
            btnEliminarGestionAcc.FlatStyle = FlatStyle.Popup;
            btnEliminarGestionAcc.ForeColor = SystemColors.Control;
            btnEliminarGestionAcc.Location = new Point(212, 475);
            btnEliminarGestionAcc.Name = "btnEliminarGestionAcc";
            btnEliminarGestionAcc.Size = new Size(125, 32);
            btnEliminarGestionAcc.TabIndex = 72;
            btnEliminarGestionAcc.Text = "Eliminar";
            btnEliminarGestionAcc.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(29, 27);
            label5.Name = "label5";
            label5.Size = new Size(343, 45);
            label5.TabIndex = 73;
            label5.Text = "Gestion de accesorios";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = Color.Transparent;
            label26.ForeColor = SystemColors.ButtonFace;
            label26.Location = new Point(587, 466);
            label26.Margin = new Padding(4, 0, 4, 0);
            label26.Name = "label26";
            label26.Size = new Size(58, 17);
            label26.TabIndex = 103;
            label26.Text = "Nombre";
            // 
            // txtFiltroNombre
            // 
            txtFiltroNombre.BackColor = Color.PeachPuff;
            txtFiltroNombre.BorderStyle = BorderStyle.None;
            txtFiltroNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFiltroNombre.Location = new Point(554, 488);
            txtFiltroNombre.Margin = new Padding(4, 3, 4, 3);
            txtFiltroNombre.Name = "txtFiltroNombre";
            txtFiltroNombre.Size = new Size(141, 22);
            txtFiltroNombre.TabIndex = 102;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(45, 17);
            label7.TabIndex = 107;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(434, 484);
            label8.Name = "label8";
            label8.Size = new Size(103, 25);
            label8.TabIndex = 108;
            label8.Text = "Filtrar por:";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.IndianRed;
            btnBuscar.FlatStyle = FlatStyle.Popup;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(717, 486);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(102, 26);
            btnBuscar.TabIndex = 109;
            btnBuscar.Text = "🔎 BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnSinFiltro
            // 
            btnSinFiltro.BackColor = Color.FromArgb(0, 0, 64);
            btnSinFiltro.FlatStyle = FlatStyle.Popup;
            btnSinFiltro.ForeColor = Color.White;
            btnSinFiltro.Location = new Point(834, 485);
            btnSinFiltro.Name = "btnSinFiltro";
            btnSinFiltro.Size = new Size(102, 26);
            btnSinFiltro.TabIndex = 110;
            btnSinFiltro.Text = "LIMPIAR FILTROS";
            btnSinFiltro.UseVisualStyleBackColor = false;
            btnSinFiltro.Click += btnSinFiltro_Click;
            // 
            // FrmGestionAccesorios
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackbrownDark;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(967, 533);
            Controls.Add(btnSinFiltro);
            Controls.Add(btnBuscar);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label26);
            Controls.Add(txtFiltroNombre);
            Controls.Add(label5);
            Controls.Add(btnEliminarGestionAcc);
            Controls.Add(btnActualizarGestionAcc);
            Controls.Add(dgvAccesorios);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbCategoriaGestionAcc);
            Controls.Add(txtDescripcionGestionAcc);
            Controls.Add(nudStockGestionAcc);
            Controls.Add(txtUbicacionGestionAcc);
            Controls.Add(txtNombreGestionAcc);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmGestionAccesorios";
            ShowIcon = false;
            Text = "Gestion de accesorios";
            WindowState = FormWindowState.Maximized;
            Load += FrmGestionAccesorios_Load;
            ((System.ComponentModel.ISupportInitialize)nudStockGestionAcc).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAccesorios).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCategoriaGestionAcc;
        private System.Windows.Forms.RichTextBox txtDescripcionGestionAcc;
        private System.Windows.Forms.NumericUpDown nudStockGestionAcc;
        private System.Windows.Forms.TextBox txtUbicacionGestionAcc;
        private System.Windows.Forms.TextBox txtNombreGestionAcc;
        private System.Windows.Forms.DataGridView dgvAccesorios;
        private System.Windows.Forms.Button btnActualizarGestionAcc;
        private System.Windows.Forms.Button btnEliminarGestionAcc;
        private System.Windows.Forms.Label label5;
        private Label label26;
        private TextBox txtFiltroNombre;
        private Label label7;
        private Label label8;
        private Button btnBuscar;
        private Button btnSinFiltro;
    }
}