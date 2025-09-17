namespace GestorLaboratorio
{
    partial class FrmAltaSustancias
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
            label13 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label10 = new Label();
            label12 = new Label();
            txtIncompSus = new RichTextBox();
            btnAgregarSus = new Button();
            txtNombreSus = new TextBox();
            label2 = new Label();
            txtManipulacionSus = new RichTextBox();
            cmbCategoriaSus = new ComboBox();
            label11 = new Label();
            label3 = new Label();
            cmbUnidadSus = new ComboBox();
            label4 = new Label();
            numStockActualSus = new NumericUpDown();
            txtEnvaseSus = new TextBox();
            nudStockMínSus = new NumericUpDown();
            label9 = new Label();
            txtUbicacionSus = new TextBox();
            label8 = new Label();
            label5 = new Label();
            cmbPeligrosidadSus = new ComboBox();
            label6 = new Label();
            dtpVencimientoSus = new DateTimePicker();
            label7 = new Label();
            dtpIngresoSus = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStockActualSus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStockMínSus).BeginInit();
            SuspendLayout();
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ButtonFace;
            label13.Location = new Point(82, 42);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(640, 45);
            label13.TabIndex = 57;
            label13.Text = "Ingrese los datos de la sustancia a añadir";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.ProbetaLogo;
            pictureBox1.Location = new Point(548, 377);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 56;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 128);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 55;
            label1.Text = "Nombre:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonFace;
            label10.Location = new Point(128, 342);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(70, 21);
            label10.TabIndex = 48;
            label10.Text = "Unidad:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(723, 252);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(142, 21);
            label12.TabIndex = 54;
            label12.Text = "Incompatibilidad";
            // 
            // txtIncompSus
            // 
            txtIncompSus.BackColor = Color.LightCoral;
            txtIncompSus.Location = new Point(689, 283);
            txtIncompSus.Margin = new Padding(4, 3, 4, 3);
            txtIncompSus.Name = "txtIncompSus";
            txtIncompSus.Size = new Size(233, 64);
            txtIncompSus.TabIndex = 52;
            txtIncompSus.Text = "";
            // 
            // btnAgregarSus
            // 
            btnAgregarSus.BackColor = Color.LimeGreen;
            btnAgregarSus.BackgroundImageLayout = ImageLayout.Stretch;
            btnAgregarSus.FlatStyle = FlatStyle.Popup;
            btnAgregarSus.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarSus.Location = new Point(359, 408);
            btnAgregarSus.Margin = new Padding(4, 3, 4, 3);
            btnAgregarSus.Name = "btnAgregarSus";
            btnAgregarSus.Size = new Size(182, 58);
            btnAgregarSus.TabIndex = 53;
            btnAgregarSus.Text = "Agregar";
            btnAgregarSus.UseVisualStyleBackColor = false;
            // 
            // txtNombreSus
            // 
            txtNombreSus.BackColor = Color.LightGreen;
            txtNombreSus.BorderStyle = BorderStyle.None;
            txtNombreSus.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreSus.Location = new Point(108, 130);
            txtNombreSus.Margin = new Padding(4, 3, 4, 3);
            txtNombreSus.Name = "txtNombreSus";
            txtNombreSus.Size = new Size(196, 15);
            txtNombreSus.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HighlightText;
            label2.Location = new Point(5, 173);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 32;
            label2.Text = "Categoría:";
            // 
            // txtManipulacionSus
            // 
            txtManipulacionSus.BackColor = Color.LightGreen;
            txtManipulacionSus.Location = new Point(689, 158);
            txtManipulacionSus.Margin = new Padding(4, 3, 4, 3);
            txtManipulacionSus.Name = "txtManipulacionSus";
            txtManipulacionSus.Size = new Size(233, 82);
            txtManipulacionSus.TabIndex = 51;
            txtManipulacionSus.Text = "";
            // 
            // cmbCategoriaSus
            // 
            cmbCategoriaSus.BackColor = Color.LightGreen;
            cmbCategoriaSus.FormattingEnabled = true;
            cmbCategoriaSus.Items.AddRange(new object[] { "Orgánico", "Ácido", "Base", "Sal", "Vidrio" });
            cmbCategoriaSus.Location = new Point(108, 173);
            cmbCategoriaSus.Margin = new Padding(4, 3, 4, 3);
            cmbCategoriaSus.Name = "cmbCategoriaSus";
            cmbCategoriaSus.Size = new Size(195, 23);
            cmbCategoriaSus.TabIndex = 33;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(697, 134);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(225, 21);
            label11.TabIndex = 50;
            label11.Text = "Manipulación recomendada";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HighlightText;
            label3.Location = new Point(70, 256);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(120, 21);
            label3.TabIndex = 34;
            label3.Text = "Stock mínimo:";
            // 
            // cmbUnidadSus
            // 
            cmbUnidadSus.BackColor = Color.LightGreen;
            cmbUnidadSus.FormattingEnabled = true;
            cmbUnidadSus.Items.AddRange(new object[] { "Gr", "Ml" });
            cmbUnidadSus.Location = new Point(223, 342);
            cmbUnidadSus.Margin = new Padding(4, 3, 4, 3);
            cmbUnidadSus.Name = "cmbUnidadSus";
            cmbUnidadSus.Size = new Size(81, 23);
            cmbUnidadSus.TabIndex = 49;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(85, 300);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(107, 21);
            label4.TabIndex = 35;
            label4.Text = "Stock actual:";
            // 
            // numStockActualSus
            // 
            numStockActualSus.BackColor = Color.LightGreen;
            numStockActualSus.Location = new Point(223, 300);
            numStockActualSus.Margin = new Padding(4, 3, 4, 3);
            numStockActualSus.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numStockActualSus.Name = "numStockActualSus";
            numStockActualSus.Size = new Size(82, 23);
            numStockActualSus.TabIndex = 36;
            // 
            // txtEnvaseSus
            // 
            txtEnvaseSus.BackColor = Color.LightGreen;
            txtEnvaseSus.Location = new Point(465, 279);
            txtEnvaseSus.Margin = new Padding(4, 3, 4, 3);
            txtEnvaseSus.Name = "txtEnvaseSus";
            txtEnvaseSus.Size = new Size(145, 23);
            txtEnvaseSus.TabIndex = 47;
            // 
            // nudStockMínSus
            // 
            nudStockMínSus.BackColor = Color.LightCoral;
            nudStockMínSus.Location = new Point(223, 256);
            nudStockMínSus.Margin = new Padding(4, 3, 4, 3);
            nudStockMínSus.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudStockMínSus.Name = "nudStockMínSus";
            nudStockMínSus.Size = new Size(82, 23);
            nudStockMínSus.TabIndex = 37;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(380, 283);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(67, 21);
            label9.TabIndex = 46;
            label9.Text = "Envase:";
            // 
            // txtUbicacionSus
            // 
            txtUbicacionSus.BackColor = Color.LightGreen;
            txtUbicacionSus.Location = new Point(108, 217);
            txtUbicacionSus.Margin = new Padding(4, 3, 4, 3);
            txtUbicacionSus.Name = "txtUbicacionSus";
            txtUbicacionSus.Size = new Size(195, 23);
            txtUbicacionSus.TabIndex = 38;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(330, 232);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(110, 21);
            label8.TabIndex = 45;
            label8.Text = "Peligrosidad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.HighlightText;
            label5.Location = new Point(1, 217);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(91, 21);
            label5.TabIndex = 39;
            label5.Text = "Ubicación:";
            // 
            // cmbPeligrosidadSus
            // 
            cmbPeligrosidadSus.BackColor = Color.LightCoral;
            cmbPeligrosidadSus.FormattingEnabled = true;
            cmbPeligrosidadSus.Items.AddRange(new object[] { "Inflamable", "Tóxica", "Corrosiva", "Explosiva" });
            cmbPeligrosidadSus.Location = new Point(465, 228);
            cmbPeligrosidadSus.Margin = new Padding(4, 3, 4, 3);
            cmbPeligrosidadSus.Name = "cmbPeligrosidadSus";
            cmbPeligrosidadSus.Size = new Size(145, 23);
            cmbPeligrosidadSus.TabIndex = 44;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(357, 133);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(87, 21);
            label6.TabIndex = 40;
            label6.Text = "Fecha ing:";
            // 
            // dtpVencimientoSus
            // 
            dtpVencimientoSus.CalendarMonthBackground = Color.LightCoral;
            dtpVencimientoSus.Format = DateTimePickerFormat.Short;
            dtpVencimientoSus.Location = new Point(465, 179);
            dtpVencimientoSus.Margin = new Padding(4, 3, 4, 3);
            dtpVencimientoSus.Name = "dtpVencimientoSus";
            dtpVencimientoSus.Size = new Size(131, 23);
            dtpVencimientoSus.TabIndex = 43;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(344, 178);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(98, 21);
            label7.TabIndex = 41;
            label7.Text = "Fecha venc:";
            // 
            // dtpIngresoSus
            // 
            dtpIngresoSus.CalendarMonthBackground = Color.LightGreen;
            dtpIngresoSus.Format = DateTimePickerFormat.Short;
            dtpIngresoSus.Location = new Point(465, 133);
            dtpIngresoSus.Margin = new Padding(4, 3, 4, 3);
            dtpIngresoSus.Name = "dtpIngresoSus";
            dtpIngresoSus.Size = new Size(131, 23);
            dtpIngresoSus.TabIndex = 42;
            // 
            // FrmAltaSustancias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            BackgroundImage = Properties.Resources.BackgreenDark;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(981, 566);
            Controls.Add(label13);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(label10);
            Controls.Add(label12);
            Controls.Add(txtIncompSus);
            Controls.Add(btnAgregarSus);
            Controls.Add(txtNombreSus);
            Controls.Add(label2);
            Controls.Add(txtManipulacionSus);
            Controls.Add(cmbCategoriaSus);
            Controls.Add(label11);
            Controls.Add(label3);
            Controls.Add(cmbUnidadSus);
            Controls.Add(label4);
            Controls.Add(numStockActualSus);
            Controls.Add(txtEnvaseSus);
            Controls.Add(nudStockMínSus);
            Controls.Add(label9);
            Controls.Add(txtUbicacionSus);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(cmbPeligrosidadSus);
            Controls.Add(label6);
            Controls.Add(dtpVencimientoSus);
            Controls.Add(label7);
            Controls.Add(dtpIngresoSus);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAltaSustancias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alta de sustancia";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStockActualSus).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStockMínSus).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox txtIncompSus;
        private System.Windows.Forms.Button btnAgregarSus;
        private System.Windows.Forms.TextBox txtNombreSus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtManipulacionSus;
        private System.Windows.Forms.ComboBox cmbCategoriaSus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbUnidadSus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numStockActualSus;
        private System.Windows.Forms.TextBox txtEnvaseSus;
        private System.Windows.Forms.NumericUpDown nudStockMínSus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUbicacionSus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPeligrosidadSus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpVencimientoSus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpIngresoSus;
    }
}