namespace GestorLaboratorio
{
    partial class FrmGestorSustancias
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            cmbCategoriaFiltro = new ComboBox();
            label29 = new Label();
            label28 = new Label();
            label27 = new Label();
            label26 = new Label();
            txtFiltroNombre = new TextBox();
            cmbStockFiltro = new ComboBox();
            dgvSus = new DataGridView();
            btnEliminarGestionSus = new Button();
            pictureBox2 = new PictureBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            txtIncompGestionSus = new RichTextBox();
            btnCambiarSus = new Button();
            txtNombreGestorSus = new TextBox();
            label17 = new Label();
            txtManRecGestionSus = new RichTextBox();
            cmbCategoriaGestorSus = new ComboBox();
            label18 = new Label();
            label19 = new Label();
            cmbUnidad = new ComboBox();
            label20 = new Label();
            nudStockAGestorSus = new NumericUpDown();
            txtEnvase = new TextBox();
            nudStockMGestorSus = new NumericUpDown();
            label21 = new Label();
            txtUbicacionGestorSus = new TextBox();
            label22 = new Label();
            label23 = new Label();
            cmbPeligrosidadGestionSus = new ComboBox();
            label24 = new Label();
            dtpFechaVencGestionSus = new DateTimePicker();
            label25 = new Label();
            dtpFechaIngGestionSus = new DateTimePicker();
            label1 = new Label();
            btnFiltrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStockAGestorSus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStockMGestorSus).BeginInit();
            SuspendLayout();
            // 
            // cmbCategoriaFiltro
            // 
            cmbCategoriaFiltro.BackColor = Color.LightGreen;
            cmbCategoriaFiltro.FormattingEnabled = true;
            cmbCategoriaFiltro.Items.AddRange(new object[] { "Orgánico", "Ácido", "Base", "Sal", "Vidrio" });
            cmbCategoriaFiltro.Location = new Point(455, 428);
            cmbCategoriaFiltro.Margin = new Padding(4, 3, 4, 3);
            cmbCategoriaFiltro.Name = "cmbCategoriaFiltro";
            cmbCategoriaFiltro.Size = new Size(107, 21);
            cmbCategoriaFiltro.TabIndex = 100;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.BackColor = Color.Transparent;
            label29.ForeColor = SystemColors.ButtonFace;
            label29.Location = new Point(259, 434);
            label29.Margin = new Padding(4, 0, 4, 0);
            label29.Name = "label29";
            label29.Size = new Size(61, 13);
            label29.TabIndex = 99;
            label29.Text = "Filtrar por:";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.BackColor = Color.Transparent;
            label28.ForeColor = SystemColors.ButtonFace;
            label28.Location = new Point(583, 413);
            label28.Margin = new Padding(4, 0, 4, 0);
            label28.Name = "label28";
            label28.Size = new Size(73, 13);
            label28.TabIndex = 98;
            label28.Text = "Estado Stock";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.BackColor = Color.Transparent;
            label27.ForeColor = SystemColors.ButtonFace;
            label27.Location = new Point(477, 412);
            label27.Margin = new Padding(4, 0, 4, 0);
            label27.Name = "label27";
            label27.Size = new Size(57, 13);
            label27.TabIndex = 97;
            label27.Text = "Categoría";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = Color.Transparent;
            label26.ForeColor = SystemColors.ButtonFace;
            label26.Location = new Point(359, 412);
            label26.Margin = new Padding(4, 0, 4, 0);
            label26.Name = "label26";
            label26.Size = new Size(50, 13);
            label26.TabIndex = 96;
            label26.Text = "Nombre";
            // 
            // txtFiltroNombre
            // 
            txtFiltroNombre.BackColor = Color.LightGreen;
            txtFiltroNombre.BorderStyle = BorderStyle.None;
            txtFiltroNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFiltroNombre.Location = new Point(328, 429);
            txtFiltroNombre.Margin = new Padding(4, 3, 4, 3);
            txtFiltroNombre.Name = "txtFiltroNombre";
            txtFiltroNombre.Size = new Size(119, 20);
            txtFiltroNombre.TabIndex = 95;
            // 
            // cmbStockFiltro
            // 
            cmbStockFiltro.BackColor = Color.LightGreen;
            cmbStockFiltro.FormattingEnabled = true;
            cmbStockFiltro.Items.AddRange(new object[] { "Inflamable", "Tóxica", "Corrosiva", "Explosiva" });
            cmbStockFiltro.Location = new Point(570, 428);
            cmbStockFiltro.Margin = new Padding(4, 3, 4, 3);
            cmbStockFiltro.Name = "cmbStockFiltro";
            cmbStockFiltro.Size = new Size(103, 21);
            cmbStockFiltro.TabIndex = 94;
            // 
            // dgvSus
            // 
            dataGridViewCellStyle1.BackColor = Color.PaleGreen;
            dgvSus.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvSus.BackgroundColor = Color.FromArgb(0, 64, 0);
            dgvSus.BorderStyle = BorderStyle.Fixed3D;
            dgvSus.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LimeGreen;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvSus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvSus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSus.Location = new Point(511, 12);
            dgvSus.Margin = new Padding(4, 3, 4, 3);
            dgvSus.Name = "dgvSus";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.LimeGreen;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvSus.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvSus.RowHeadersVisible = false;
            dgvSus.Size = new Size(630, 391);
            dgvSus.TabIndex = 93;
            // 
            // btnEliminarGestionSus
            // 
            btnEliminarGestionSus.BackColor = Color.IndianRed;
            btnEliminarGestionSus.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminarGestionSus.FlatStyle = FlatStyle.Popup;
            btnEliminarGestionSus.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnEliminarGestionSus.Location = new Point(396, 349);
            btnEliminarGestionSus.Margin = new Padding(4, 3, 4, 3);
            btnEliminarGestionSus.Name = "btnEliminarGestionSus";
            btnEliminarGestionSus.Size = new Size(107, 34);
            btnEliminarGestionSus.TabIndex = 92;
            btnEliminarGestionSus.Text = "Eliminar";
            btnEliminarGestionSus.UseVisualStyleBackColor = false;
            btnEliminarGestionSus.Click += btnEliminarGestionSus_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.ProbetaLogo;
            pictureBox2.Location = new Point(389, 12);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(81, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 91;
            pictureBox2.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.Control;
            label14.Location = new Point(23, 98);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(77, 21);
            label14.TabIndex = 90;
            label14.Text = "Nombre:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = SystemColors.ButtonFace;
            label15.Location = new Point(75, 269);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(70, 21);
            label15.TabIndex = 83;
            label15.Text = "Unidad:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = SystemColors.ButtonHighlight;
            label16.Location = new Point(318, 242);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(142, 21);
            label16.TabIndex = 89;
            label16.Text = "Incompatibilidad";
            // 
            // txtIncompGestionSus
            // 
            txtIncompGestionSus.BackColor = Color.LightCoral;
            txtIncompGestionSus.Location = new Point(270, 266);
            txtIncompGestionSus.Margin = new Padding(4, 3, 4, 3);
            txtIncompGestionSus.Name = "txtIncompGestionSus";
            txtIncompGestionSus.Size = new Size(233, 56);
            txtIncompGestionSus.TabIndex = 87;
            txtIncompGestionSus.Text = "";
            // 
            // btnCambiarSus
            // 
            btnCambiarSus.BackColor = Color.Goldenrod;
            btnCambiarSus.BackgroundImageLayout = ImageLayout.Stretch;
            btnCambiarSus.FlatStyle = FlatStyle.Popup;
            btnCambiarSus.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCambiarSus.Location = new Point(270, 349);
            btnCambiarSus.Margin = new Padding(4, 3, 4, 3);
            btnCambiarSus.Name = "btnCambiarSus";
            btnCambiarSus.Size = new Size(110, 34);
            btnCambiarSus.TabIndex = 88;
            btnCambiarSus.Text = "Cambiar";
            btnCambiarSus.UseVisualStyleBackColor = false;
            btnCambiarSus.Click += btnCambiarSus_Click;
            // 
            // txtNombreGestorSus
            // 
            txtNombreGestorSus.BackColor = Color.LightGreen;
            txtNombreGestorSus.BorderStyle = BorderStyle.None;
            txtNombreGestorSus.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreGestorSus.Location = new Point(108, 98);
            txtNombreGestorSus.Margin = new Padding(4, 3, 4, 3);
            txtNombreGestorSus.Name = "txtNombreGestorSus";
            txtNombreGestorSus.Size = new Size(132, 18);
            txtNombreGestorSus.TabIndex = 66;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = SystemColors.HighlightText;
            label17.Location = new Point(10, 134);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(88, 21);
            label17.TabIndex = 67;
            label17.Text = "Categoría:";
            // 
            // txtManRecGestionSus
            // 
            txtManRecGestionSus.BackColor = Color.LightGreen;
            txtManRecGestionSus.ForeColor = SystemColors.WindowText;
            txtManRecGestionSus.Location = new Point(270, 152);
            txtManRecGestionSus.Margin = new Padding(4, 3, 4, 3);
            txtManRecGestionSus.Name = "txtManRecGestionSus";
            txtManRecGestionSus.Size = new Size(233, 72);
            txtManRecGestionSus.TabIndex = 86;
            txtManRecGestionSus.Text = "";
            // 
            // cmbCategoriaGestorSus
            // 
            cmbCategoriaGestorSus.BackColor = Color.LightGreen;
            cmbCategoriaGestorSus.FormattingEnabled = true;
            cmbCategoriaGestorSus.Items.AddRange(new object[] { "Orgánico", "Ácido", "Base", "Sal", "Vidrio" });
            cmbCategoriaGestorSus.Location = new Point(106, 134);
            cmbCategoriaGestorSus.Margin = new Padding(4, 3, 4, 3);
            cmbCategoriaGestorSus.Name = "cmbCategoriaGestorSus";
            cmbCategoriaGestorSus.Size = new Size(131, 21);
            cmbCategoriaGestorSus.TabIndex = 68;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = SystemColors.ButtonHighlight;
            label18.Location = new Point(272, 129);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(225, 21);
            label18.TabIndex = 85;
            label18.Text = "Manipulación recomendada";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = SystemColors.HighlightText;
            label19.Location = new Point(25, 214);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(120, 21);
            label19.TabIndex = 69;
            label19.Text = "Stock mínimo:";
            // 
            // cmbUnidad
            // 
            cmbUnidad.BackColor = Color.LightGreen;
            cmbUnidad.FormattingEnabled = true;
            cmbUnidad.Items.AddRange(new object[] { "Gr", "Ml" });
            cmbUnidad.Location = new Point(156, 269);
            cmbUnidad.Margin = new Padding(4, 3, 4, 3);
            cmbUnidad.Name = "cmbUnidad";
            cmbUnidad.Size = new Size(81, 21);
            cmbUnidad.TabIndex = 84;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.Transparent;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = SystemColors.ButtonHighlight;
            label20.Location = new Point(38, 242);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(107, 21);
            label20.TabIndex = 70;
            label20.Text = "Stock actual:";
            // 
            // nudStockAGestorSus
            // 
            nudStockAGestorSus.BackColor = Color.LightGreen;
            nudStockAGestorSus.Location = new Point(155, 241);
            nudStockAGestorSus.Margin = new Padding(4, 3, 4, 3);
            nudStockAGestorSus.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudStockAGestorSus.Name = "nudStockAGestorSus";
            nudStockAGestorSus.Size = new Size(82, 22);
            nudStockAGestorSus.TabIndex = 71;
            // 
            // txtEnvase
            // 
            txtEnvase.BackColor = Color.LightGreen;
            txtEnvase.Location = new Point(106, 409);
            txtEnvase.Margin = new Padding(4, 3, 4, 3);
            txtEnvase.Name = "txtEnvase";
            txtEnvase.Size = new Size(131, 22);
            txtEnvase.TabIndex = 82;
            // 
            // nudStockMGestorSus
            // 
            nudStockMGestorSus.BackColor = Color.LightCoral;
            nudStockMGestorSus.Location = new Point(155, 213);
            nudStockMGestorSus.Margin = new Padding(4, 3, 4, 3);
            nudStockMGestorSus.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudStockMGestorSus.Name = "nudStockMGestorSus";
            nudStockMGestorSus.Size = new Size(82, 22);
            nudStockMGestorSus.TabIndex = 72;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.Transparent;
            label21.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.ForeColor = SystemColors.ButtonHighlight;
            label21.Location = new Point(33, 410);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(67, 21);
            label21.TabIndex = 81;
            label21.Text = "Envase:";
            // 
            // txtUbicacionGestorSus
            // 
            txtUbicacionGestorSus.BackColor = Color.LightGreen;
            txtUbicacionGestorSus.Location = new Point(106, 173);
            txtUbicacionGestorSus.Margin = new Padding(4, 3, 4, 3);
            txtUbicacionGestorSus.Name = "txtUbicacionGestorSus";
            txtUbicacionGestorSus.Size = new Size(131, 22);
            txtUbicacionGestorSus.TabIndex = 73;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.Transparent;
            label22.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.ForeColor = SystemColors.ButtonHighlight;
            label22.Location = new Point(1, 372);
            label22.Margin = new Padding(4, 0, 4, 0);
            label22.Name = "label22";
            label22.Size = new Size(99, 20);
            label22.TabIndex = 80;
            label22.Text = "Peligrosidad:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.Transparent;
            label23.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.ForeColor = SystemColors.HighlightText;
            label23.Location = new Point(15, 173);
            label23.Margin = new Padding(4, 0, 4, 0);
            label23.Name = "label23";
            label23.Size = new Size(91, 21);
            label23.TabIndex = 74;
            label23.Text = "Ubicación:";
            // 
            // cmbPeligrosidadGestionSus
            // 
            cmbPeligrosidadGestionSus.BackColor = Color.LightCoral;
            cmbPeligrosidadGestionSus.FormattingEnabled = true;
            cmbPeligrosidadGestionSus.Items.AddRange(new object[] { "Inflamable", "Tóxica", "Corrosiva", "Explosiva" });
            cmbPeligrosidadGestionSus.Location = new Point(106, 371);
            cmbPeligrosidadGestionSus.Margin = new Padding(4, 3, 4, 3);
            cmbPeligrosidadGestionSus.Name = "cmbPeligrosidadGestionSus";
            cmbPeligrosidadGestionSus.Size = new Size(131, 21);
            cmbPeligrosidadGestionSus.TabIndex = 79;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = Color.Transparent;
            label24.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.ForeColor = SystemColors.ButtonHighlight;
            label24.Location = new Point(19, 302);
            label24.Margin = new Padding(4, 0, 4, 0);
            label24.Name = "label24";
            label24.Size = new Size(87, 21);
            label24.TabIndex = 75;
            label24.Text = "Fecha ing:";
            // 
            // dtpFechaVencGestionSus
            // 
            dtpFechaVencGestionSus.CalendarMonthBackground = Color.LightCoral;
            dtpFechaVencGestionSus.Format = DateTimePickerFormat.Short;
            dtpFechaVencGestionSus.Location = new Point(114, 338);
            dtpFechaVencGestionSus.Margin = new Padding(4, 3, 4, 3);
            dtpFechaVencGestionSus.Name = "dtpFechaVencGestionSus";
            dtpFechaVencGestionSus.Size = new Size(123, 22);
            dtpFechaVencGestionSus.TabIndex = 78;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.BackColor = Color.Transparent;
            label25.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label25.ForeColor = SystemColors.ButtonHighlight;
            label25.Location = new Point(8, 338);
            label25.Margin = new Padding(4, 0, 4, 0);
            label25.Name = "label25";
            label25.Size = new Size(98, 21);
            label25.TabIndex = 76;
            label25.Text = "Fecha venc:";
            // 
            // dtpFechaIngGestionSus
            // 
            dtpFechaIngGestionSus.CalendarMonthBackground = Color.LightGreen;
            dtpFechaIngGestionSus.Format = DateTimePickerFormat.Short;
            dtpFechaIngGestionSus.Location = new Point(114, 302);
            dtpFechaIngGestionSus.Margin = new Padding(4, 3, 4, 3);
            dtpFechaIngGestionSus.Name = "dtpFechaIngGestionSus";
            dtpFechaIngGestionSus.Size = new Size(123, 22);
            dtpFechaIngGestionSus.TabIndex = 77;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(115, 26);
            label1.Name = "label1";
            label1.Size = new Size(288, 37);
            label1.TabIndex = 101;
            label1.Text = "Gestor de sustancias";
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = Color.Teal;
            btnFiltrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnFiltrar.FlatStyle = FlatStyle.Popup;
            btnFiltrar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnFiltrar.ForeColor = SystemColors.ButtonHighlight;
            btnFiltrar.Location = new Point(695, 420);
            btnFiltrar.Margin = new Padding(4, 3, 4, 3);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(110, 34);
            btnFiltrar.TabIndex = 102;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = false;
            // 
            // FrmGestorSustancias
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackgreenDark;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1140, 622);
            Controls.Add(btnFiltrar);
            Controls.Add(label1);
            Controls.Add(cmbCategoriaFiltro);
            Controls.Add(label29);
            Controls.Add(label28);
            Controls.Add(label27);
            Controls.Add(label26);
            Controls.Add(txtFiltroNombre);
            Controls.Add(cmbStockFiltro);
            Controls.Add(dgvSus);
            Controls.Add(btnEliminarGestionSus);
            Controls.Add(pictureBox2);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(txtIncompGestionSus);
            Controls.Add(btnCambiarSus);
            Controls.Add(txtNombreGestorSus);
            Controls.Add(label17);
            Controls.Add(txtManRecGestionSus);
            Controls.Add(cmbCategoriaGestorSus);
            Controls.Add(label18);
            Controls.Add(label19);
            Controls.Add(cmbUnidad);
            Controls.Add(label20);
            Controls.Add(nudStockAGestorSus);
            Controls.Add(txtEnvase);
            Controls.Add(nudStockMGestorSus);
            Controls.Add(label21);
            Controls.Add(txtUbicacionGestorSus);
            Controls.Add(label22);
            Controls.Add(label23);
            Controls.Add(cmbPeligrosidadGestionSus);
            Controls.Add(label24);
            Controls.Add(dtpFechaVencGestionSus);
            Controls.Add(label25);
            Controls.Add(dtpFechaIngGestionSus);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmGestorSustancias";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmGestorSustancias";
            WindowState = FormWindowState.Maximized;
            Load += FrmGestorSustancias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSus).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStockAGestorSus).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStockMGestorSus).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCategoriaFiltro;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtFiltroNombre;
        private System.Windows.Forms.ComboBox cmbStockFiltro;
        private System.Windows.Forms.DataGridView dgvSus;
        private System.Windows.Forms.Button btnEliminarGestionSus;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RichTextBox txtIncompGestionSus;
        private System.Windows.Forms.Button btnCambiarSus;
        private System.Windows.Forms.TextBox txtNombreGestorSus;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RichTextBox txtManRecGestionSus;
        private System.Windows.Forms.ComboBox cmbCategoriaGestorSus;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmbUnidad;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown nudStockAGestorSus;
        private System.Windows.Forms.TextBox txtEnvase;
        private System.Windows.Forms.NumericUpDown nudStockMGestorSus;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtUbicacionGestorSus;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cmbPeligrosidadGestionSus;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DateTimePicker dtpFechaVencGestionSus;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.DateTimePicker dtpFechaIngGestionSus;
        private System.Windows.Forms.Label label1;
        private Button btnFiltrar;
    }
}