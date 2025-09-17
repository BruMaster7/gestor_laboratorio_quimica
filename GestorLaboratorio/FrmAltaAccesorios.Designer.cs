namespace GestorLaboratorio
{
    partial class FrmAltaAccesorios
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbCategoriaAltaAcc = new ComboBox();
            btnAgregarAcc = new Button();
            txtDescripcionAltaAcc = new RichTextBox();
            nudStockAltaAcc = new NumericUpDown();
            txtUbicacionAltaAcc = new TextBox();
            txtNombreAltaAcc = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudStockAltaAcc).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(414, 278);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(112, 25);
            label6.TabIndex = 59;
            label6.Text = "Descripción";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(183, 36);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(536, 37);
            label5.TabIndex = 58;
            label5.Text = "Ingrese los datos del accesorio a añadir";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(567, 215);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 25);
            label4.TabIndex = 57;
            label4.Text = "Stock:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(525, 141);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 56;
            label3.Text = "Categoría:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(80, 218);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 55;
            label2.Text = "Ubicación:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(96, 138);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 54;
            label1.Text = "Nombre:\r\n";
            // 
            // cmbCategoriaAltaAcc
            // 
            cmbCategoriaAltaAcc.BackColor = Color.SandyBrown;
            cmbCategoriaAltaAcc.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategoriaAltaAcc.FormattingEnabled = true;
            cmbCategoriaAltaAcc.Items.AddRange(new object[] { "Vidriería", "Material metálico", "Plásticos y descartables", "Instrumentos de medición", "Accesorios de calentamiento", "Otros", "" });
            cmbCategoriaAltaAcc.Location = new Point(649, 145);
            cmbCategoriaAltaAcc.Margin = new Padding(4, 3, 4, 3);
            cmbCategoriaAltaAcc.Name = "cmbCategoriaAltaAcc";
            cmbCategoriaAltaAcc.Size = new Size(185, 24);
            cmbCategoriaAltaAcc.TabIndex = 53;
            // 
            // btnAgregarAcc
            // 
            btnAgregarAcc.BackColor = Color.DarkGreen;
            btnAgregarAcc.FlatStyle = FlatStyle.Popup;
            btnAgregarAcc.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarAcc.ForeColor = SystemColors.ButtonFace;
            btnAgregarAcc.Location = new Point(408, 429);
            btnAgregarAcc.Margin = new Padding(4, 3, 4, 3);
            btnAgregarAcc.Name = "btnAgregarAcc";
            btnAgregarAcc.Size = new Size(158, 66);
            btnAgregarAcc.TabIndex = 52;
            btnAgregarAcc.Text = "Agregar";
            btnAgregarAcc.UseVisualStyleBackColor = false;
            // 
            // txtDescripcionAltaAcc
            // 
            txtDescripcionAltaAcc.BackColor = Color.SandyBrown;
            txtDescripcionAltaAcc.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcionAltaAcc.Location = new Point(326, 310);
            txtDescripcionAltaAcc.Margin = new Padding(4, 3, 4, 3);
            txtDescripcionAltaAcc.Name = "txtDescripcionAltaAcc";
            txtDescripcionAltaAcc.Size = new Size(316, 100);
            txtDescripcionAltaAcc.TabIndex = 51;
            txtDescripcionAltaAcc.Text = "";
            // 
            // nudStockAltaAcc
            // 
            nudStockAltaAcc.BackColor = Color.SandyBrown;
            nudStockAltaAcc.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudStockAltaAcc.Location = new Point(649, 223);
            nudStockAltaAcc.Margin = new Padding(4, 3, 4, 3);
            nudStockAltaAcc.Name = "nudStockAltaAcc";
            nudStockAltaAcc.Size = new Size(68, 22);
            nudStockAltaAcc.TabIndex = 50;
            // 
            // txtUbicacionAltaAcc
            // 
            txtUbicacionAltaAcc.BackColor = Color.SandyBrown;
            txtUbicacionAltaAcc.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUbicacionAltaAcc.Location = new Point(205, 224);
            txtUbicacionAltaAcc.Margin = new Padding(4, 3, 4, 3);
            txtUbicacionAltaAcc.Name = "txtUbicacionAltaAcc";
            txtUbicacionAltaAcc.Size = new Size(227, 22);
            txtUbicacionAltaAcc.TabIndex = 49;
            // 
            // txtNombreAltaAcc
            // 
            txtNombreAltaAcc.BackColor = Color.SandyBrown;
            txtNombreAltaAcc.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreAltaAcc.Location = new Point(205, 144);
            txtNombreAltaAcc.Margin = new Padding(4, 3, 4, 3);
            txtNombreAltaAcc.Name = "txtNombreAltaAcc";
            txtNombreAltaAcc.Size = new Size(227, 22);
            txtNombreAltaAcc.TabIndex = 48;
            // 
            // FrmAltaAccesorios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.BackbrownDark;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(915, 532);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbCategoriaAltaAcc);
            Controls.Add(btnAgregarAcc);
            Controls.Add(txtDescripcionAltaAcc);
            Controls.Add(nudStockAltaAcc);
            Controls.Add(txtUbicacionAltaAcc);
            Controls.Add(txtNombreAltaAcc);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAltaAccesorios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alta de accesorio";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)nudStockAltaAcc).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCategoriaAltaAcc;
        private System.Windows.Forms.Button btnAgregarAcc;
        private System.Windows.Forms.RichTextBox txtDescripcionAltaAcc;
        private System.Windows.Forms.NumericUpDown nudStockAltaAcc;
        private System.Windows.Forms.TextBox txtUbicacionAltaAcc;
        private System.Windows.Forms.TextBox txtNombreAltaAcc;
    }
}