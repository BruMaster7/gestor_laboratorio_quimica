namespace GestorLaboratorio
{
    partial class FrmSustancias
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSustancias = new System.Windows.Forms.DataGridView();
            this.cmbFiltroStock = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbFitroCategoriaSus = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtFiltroNombreSus = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnEliminarSus = new System.Windows.Forms.Button();
            this.btnModificarSus = new System.Windows.Forms.Button();
            this.btnAgregarSus = new System.Windows.Forms.Button();
            this.txtIncompSus = new System.Windows.Forms.RichTextBox();
            this.txtManipulacionSus = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbUnidadSus = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEnvaseSus = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbPeligrosidadSus = new System.Windows.Forms.ComboBox();
            this.dtpVencimientoSus = new System.Windows.Forms.DateTimePicker();
            this.dtpIngresoSus = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUbicacionSus = new System.Windows.Forms.TextBox();
            this.nudStockMínSus = new System.Windows.Forms.NumericUpDown();
            this.numStockActualSus = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCategoriaSus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreSus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSustancias)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockMínSus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStockActualSus)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgvSustancias);
            this.groupBox2.Controls.Add(this.cmbFiltroStock);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.cmbFitroCategoriaSus);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtFiltroNombreSus);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(1, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(780, 271);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado de Sustancias";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dgvSustancias
            // 
            this.dgvSustancias.AllowUserToAddRows = false;
            this.dgvSustancias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSustancias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvSustancias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSustancias.Location = new System.Drawing.Point(0, 40);
            this.dgvSustancias.Name = "dgvSustancias";
            this.dgvSustancias.ReadOnly = true;
            this.dgvSustancias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSustancias.Size = new System.Drawing.Size(779, 225);
            this.dgvSustancias.TabIndex = 31;
            // 
            // cmbFiltroStock
            // 
            this.cmbFiltroStock.FormattingEnabled = true;
            this.cmbFiltroStock.Items.AddRange(new object[] {
            "Normal",
            "Bajo",
            "Vencido"});
            this.cmbFiltroStock.Location = new System.Drawing.Point(621, 12);
            this.cmbFiltroStock.Name = "cmbFiltroStock";
            this.cmbFiltroStock.Size = new System.Drawing.Size(113, 25);
            this.cmbFiltroStock.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(499, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 20);
            this.label15.TabIndex = 29;
            this.label15.Text = "Estado de stock:";
            // 
            // cmbFitroCategoriaSus
            // 
            this.cmbFitroCategoriaSus.FormattingEnabled = true;
            this.cmbFitroCategoriaSus.Items.AddRange(new object[] {
            "Orgánico",
            "Ácido",
            "Base",
            "Sal",
            "Vidrio"});
            this.cmbFitroCategoriaSus.Location = new System.Drawing.Point(380, 14);
            this.cmbFitroCategoriaSus.Name = "cmbFitroCategoriaSus";
            this.cmbFitroCategoriaSus.Size = new System.Drawing.Size(113, 25);
            this.cmbFitroCategoriaSus.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(297, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 20);
            this.label14.TabIndex = 28;
            this.label14.Text = "Categoría:";
            // 
            // txtFiltroNombreSus
            // 
            this.txtFiltroNombreSus.Location = new System.Drawing.Point(178, 14);
            this.txtFiltroNombreSus.Name = "txtFiltroNombreSus";
            this.txtFiltroNombreSus.Size = new System.Drawing.Size(113, 25);
            this.txtFiltroNombreSus.TabIndex = 3;
            this.txtFiltroNombreSus.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(110, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "Nombre:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btnEliminarSus);
            this.groupBox1.Controls.Add(this.btnModificarSus);
            this.groupBox1.Controls.Add(this.btnAgregarSus);
            this.groupBox1.Controls.Add(this.txtIncompSus);
            this.groupBox1.Controls.Add(this.txtManipulacionSus);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmbUnidadSus);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtEnvaseSus);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbPeligrosidadSus);
            this.groupBox1.Controls.Add(this.dtpVencimientoSus);
            this.groupBox1.Controls.Add(this.dtpIngresoSus);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtUbicacionSus);
            this.groupBox1.Controls.Add(this.nudStockMínSus);
            this.groupBox1.Controls.Add(this.numStockActualSus);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbCategoriaSus);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombreSus);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Sustancia";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(627, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 15);
            this.label12.TabIndex = 27;
            this.label12.Text = "Incompatibilidad";
            // 
            // btnEliminarSus
            // 
            this.btnEliminarSus.BackColor = System.Drawing.Color.Maroon;
            this.btnEliminarSus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarSus.Location = new System.Drawing.Point(430, 147);
            this.btnEliminarSus.Name = "btnEliminarSus";
            this.btnEliminarSus.Size = new System.Drawing.Size(109, 33);
            this.btnEliminarSus.TabIndex = 26;
            this.btnEliminarSus.Text = "Eliminar";
            this.btnEliminarSus.UseVisualStyleBackColor = false;
            // 
            // btnModificarSus
            // 
            this.btnModificarSus.BackColor = System.Drawing.Color.OliveDrab;
            this.btnModificarSus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificarSus.Location = new System.Drawing.Point(315, 147);
            this.btnModificarSus.Name = "btnModificarSus";
            this.btnModificarSus.Size = new System.Drawing.Size(109, 33);
            this.btnModificarSus.TabIndex = 25;
            this.btnModificarSus.Text = "Modificar";
            this.btnModificarSus.UseVisualStyleBackColor = false;
            // 
            // btnAgregarSus
            // 
            this.btnAgregarSus.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAgregarSus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarSus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarSus.Location = new System.Drawing.Point(196, 146);
            this.btnAgregarSus.Name = "btnAgregarSus";
            this.btnAgregarSus.Size = new System.Drawing.Size(109, 35);
            this.btnAgregarSus.TabIndex = 24;
            this.btnAgregarSus.Text = "Agregar";
            this.btnAgregarSus.UseVisualStyleBackColor = false;
            // 
            // txtIncompSus
            // 
            this.txtIncompSus.Location = new System.Drawing.Point(574, 108);
            this.txtIncompSus.Name = "txtIncompSus";
            this.txtIncompSus.Size = new System.Drawing.Size(200, 41);
            this.txtIncompSus.TabIndex = 23;
            this.txtIncompSus.Text = "";
            // 
            // txtManipulacionSus
            // 
            this.txtManipulacionSus.Location = new System.Drawing.Point(574, 32);
            this.txtManipulacionSus.Name = "txtManipulacionSus";
            this.txtManipulacionSus.Size = new System.Drawing.Size(200, 52);
            this.txtManipulacionSus.TabIndex = 23;
            this.txtManipulacionSus.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(593, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "Manipulación recomendada";
            // 
            // cmbUnidadSus
            // 
            this.cmbUnidadSus.FormattingEnabled = true;
            this.cmbUnidadSus.Items.AddRange(new object[] {
            "Gr",
            "Ml"});
            this.cmbUnidadSus.Location = new System.Drawing.Point(87, 157);
            this.cmbUnidadSus.Name = "cmbUnidadSus";
            this.cmbUnidadSus.Size = new System.Drawing.Size(40, 25);
            this.cmbUnidadSus.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(37, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Unidad:";
            // 
            // txtEnvaseSus
            // 
            this.txtEnvaseSus.Location = new System.Drawing.Point(348, 107);
            this.txtEnvaseSus.Name = "txtEnvaseSus";
            this.txtEnvaseSus.Size = new System.Drawing.Size(125, 25);
            this.txtEnvaseSus.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(296, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Envase:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(267, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Peligrosidad:";
            // 
            // cmbPeligrosidadSus
            // 
            this.cmbPeligrosidadSus.FormattingEnabled = true;
            this.cmbPeligrosidadSus.Items.AddRange(new object[] {
            "Inflamable",
            "Tóxica",
            "Corrosiva",
            "Explosiva"});
            this.cmbPeligrosidadSus.Location = new System.Drawing.Point(348, 76);
            this.cmbPeligrosidadSus.Name = "cmbPeligrosidadSus";
            this.cmbPeligrosidadSus.Size = new System.Drawing.Size(125, 25);
            this.cmbPeligrosidadSus.TabIndex = 16;
            // 
            // dtpVencimientoSus
            // 
            this.dtpVencimientoSus.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimientoSus.Location = new System.Drawing.Point(348, 45);
            this.dtpVencimientoSus.Name = "dtpVencimientoSus";
            this.dtpVencimientoSus.Size = new System.Drawing.Size(113, 25);
            this.dtpVencimientoSus.TabIndex = 15;
            // 
            // dtpIngresoSus
            // 
            this.dtpIngresoSus.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIngresoSus.Location = new System.Drawing.Point(348, 14);
            this.dtpIngresoSus.Name = "dtpIngresoSus";
            this.dtpIngresoSus.Size = new System.Drawing.Size(113, 25);
            this.dtpIngresoSus.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(216, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fecha de vencimiento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(243, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fecha de ingreso:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(0, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ubicación:";
            // 
            // txtUbicacionSus
            // 
            this.txtUbicacionSus.Location = new System.Drawing.Point(64, 82);
            this.txtUbicacionSus.Name = "txtUbicacionSus";
            this.txtUbicacionSus.Size = new System.Drawing.Size(113, 25);
            this.txtUbicacionSus.TabIndex = 10;
            // 
            // nudStockMínSus
            // 
            this.nudStockMínSus.Location = new System.Drawing.Point(87, 110);
            this.nudStockMínSus.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudStockMínSus.Name = "nudStockMínSus";
            this.nudStockMínSus.Size = new System.Drawing.Size(70, 25);
            this.nudStockMínSus.TabIndex = 9;
            // 
            // numStockActualSus
            // 
            this.numStockActualSus.Location = new System.Drawing.Point(87, 134);
            this.numStockActualSus.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numStockActualSus.Name = "numStockActualSus";
            this.numStockActualSus.Size = new System.Drawing.Size(70, 25);
            this.numStockActualSus.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(11, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stock actual:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(6, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stock mínimo:";
            // 
            // cmbCategoriaSus
            // 
            this.cmbCategoriaSus.FormattingEnabled = true;
            this.cmbCategoriaSus.Items.AddRange(new object[] {
            "Orgánico",
            "Ácido",
            "Base",
            "Sal",
            "Vidrio"});
            this.cmbCategoriaSus.Location = new System.Drawing.Point(64, 53);
            this.cmbCategoriaSus.Name = "cmbCategoriaSus";
            this.cmbCategoriaSus.Size = new System.Drawing.Size(113, 25);
            this.cmbCategoriaSus.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(2, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categoría:";
            // 
            // txtNombreSus
            // 
            this.txtNombreSus.Location = new System.Drawing.Point(64, 22);
            this.txtNombreSus.Name = "txtNombreSus";
            this.txtNombreSus.Size = new System.Drawing.Size(113, 25);
            this.txtNombreSus.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // FrmSustancias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.BackgroundImage = global::GestorLaboratorio.Properties.Resources.BackgreenDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.Name = "FrmSustancias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Sustancias";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSustancias)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockMínSus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStockActualSus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreSus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCategoriaSus;
        private System.Windows.Forms.NumericUpDown nudStockMínSus;
        private System.Windows.Forms.NumericUpDown numStockActualSus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUbicacionSus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpVencimientoSus;
        private System.Windows.Forms.DateTimePicker dtpIngresoSus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbPeligrosidadSus;
        private System.Windows.Forms.TextBox txtEnvaseSus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbUnidadSus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox txtManipulacionSus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnEliminarSus;
        private System.Windows.Forms.Button btnModificarSus;
        private System.Windows.Forms.Button btnAgregarSus;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox txtIncompSus;
        private System.Windows.Forms.TextBox txtFiltroNombreSus;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbFitroCategoriaSus;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbFiltroStock;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgvSustancias;
    }
}