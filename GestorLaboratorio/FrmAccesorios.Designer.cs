namespace GestorLaboratorio
{
    partial class FrmAccesorios
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCategoriaAcc = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLimpiarAcc = new System.Windows.Forms.Button();
            this.btnEliminarAcc = new System.Windows.Forms.Button();
            this.btnAgregarAcc = new System.Windows.Forms.Button();
            this.btnModificarAcc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescAcc = new System.Windows.Forms.RichTextBox();
            this.nudStockAcc = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUbiAcc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreAcc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvAccesorios = new System.Windows.Forms.DataGridView();
            this.cmbFiltroCategoriaAcc = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbFiltroStockAcc = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFiltroNombreAcc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockAcc)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccesorios)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmbCategoriaAcc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnLimpiarAcc);
            this.groupBox1.Controls.Add(this.btnEliminarAcc);
            this.groupBox1.Controls.Add(this.btnAgregarAcc);
            this.groupBox1.Controls.Add(this.btnModificarAcc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDescAcc);
            this.groupBox1.Controls.Add(this.nudStockAcc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtUbiAcc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombreAcc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(0, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de accesorio";
            // 
            // cmbCategoriaAcc
            // 
            this.cmbCategoriaAcc.FormattingEnabled = true;
            this.cmbCategoriaAcc.Items.AddRange(new object[] {
            "Vidriería",
            "Material metálico",
            "Plásticos y descartables",
            "Instrumentos de medición",
            "Accesorios de calentamiento",
            "Otros",
            ""});
            this.cmbCategoriaAcc.Location = new System.Drawing.Point(300, 41);
            this.cmbCategoriaAcc.Name = "cmbCategoriaAcc";
            this.cmbCategoriaAcc.Size = new System.Drawing.Size(159, 25);
            this.cmbCategoriaAcc.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(233, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Categoría:";
            // 
            // btnLimpiarAcc
            // 
            this.btnLimpiarAcc.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLimpiarAcc.Location = new System.Drawing.Point(660, 149);
            this.btnLimpiarAcc.Name = "btnLimpiarAcc";
            this.btnLimpiarAcc.Size = new System.Drawing.Size(107, 27);
            this.btnLimpiarAcc.TabIndex = 11;
            this.btnLimpiarAcc.Text = "Limpiar";
            this.btnLimpiarAcc.UseVisualStyleBackColor = false;
            // 
            // btnEliminarAcc
            // 
            this.btnEliminarAcc.BackColor = System.Drawing.Color.DarkRed;
            this.btnEliminarAcc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarAcc.Location = new System.Drawing.Point(547, 150);
            this.btnEliminarAcc.Name = "btnEliminarAcc";
            this.btnEliminarAcc.Size = new System.Drawing.Size(107, 27);
            this.btnEliminarAcc.TabIndex = 10;
            this.btnEliminarAcc.Text = "Eliminar";
            this.btnEliminarAcc.UseVisualStyleBackColor = false;
            // 
            // btnAgregarAcc
            // 
            this.btnAgregarAcc.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAgregarAcc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarAcc.Location = new System.Drawing.Point(326, 149);
            this.btnAgregarAcc.Name = "btnAgregarAcc";
            this.btnAgregarAcc.Size = new System.Drawing.Size(104, 27);
            this.btnAgregarAcc.TabIndex = 9;
            this.btnAgregarAcc.Text = "Agregar";
            this.btnAgregarAcc.UseVisualStyleBackColor = false;
            // 
            // btnModificarAcc
            // 
            this.btnModificarAcc.BackColor = System.Drawing.Color.OliveDrab;
            this.btnModificarAcc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificarAcc.Location = new System.Drawing.Point(436, 150);
            this.btnModificarAcc.Name = "btnModificarAcc";
            this.btnModificarAcc.Size = new System.Drawing.Size(105, 26);
            this.btnModificarAcc.TabIndex = 8;
            this.btnModificarAcc.Text = "Modificar";
            this.btnModificarAcc.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Descripción:";
            // 
            // txtDescAcc
            // 
            this.txtDescAcc.Location = new System.Drawing.Point(100, 104);
            this.txtDescAcc.Name = "txtDescAcc";
            this.txtDescAcc.Size = new System.Drawing.Size(172, 87);
            this.txtDescAcc.TabIndex = 6;
            this.txtDescAcc.Text = "";
            // 
            // nudStockAcc
            // 
            this.nudStockAcc.Location = new System.Drawing.Point(516, 41);
            this.nudStockAcc.Name = "nudStockAcc";
            this.nudStockAcc.Size = new System.Drawing.Size(47, 25);
            this.nudStockAcc.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Stock:";
            // 
            // txtUbiAcc
            // 
            this.txtUbiAcc.Location = new System.Drawing.Point(644, 41);
            this.txtUbiAcc.Name = "txtUbiAcc";
            this.txtUbiAcc.Size = new System.Drawing.Size(128, 25);
            this.txtUbiAcc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(569, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ubicación:";
            // 
            // txtNombreAcc
            // 
            this.txtNombreAcc.Location = new System.Drawing.Point(100, 41);
            this.txtNombreAcc.Name = "txtNombreAcc";
            this.txtNombreAcc.Size = new System.Drawing.Size(127, 25);
            this.txtNombreAcc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgvAccesorios);
            this.groupBox2.Controls.Add(this.cmbFiltroCategoriaAcc);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cmbFiltroStockAcc);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtFiltroNombreAcc);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(0, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(785, 254);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado de accesorios";
            // 
            // dgvAccesorios
            // 
            this.dgvAccesorios.AllowUserToAddRows = false;
            this.dgvAccesorios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccesorios.BackgroundColor = System.Drawing.Color.SaddleBrown;
            this.dgvAccesorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccesorios.Location = new System.Drawing.Point(17, 46);
            this.dgvAccesorios.Name = "dgvAccesorios";
            this.dgvAccesorios.ReadOnly = true;
            this.dgvAccesorios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccesorios.Size = new System.Drawing.Size(753, 202);
            this.dgvAccesorios.TabIndex = 17;
            // 
            // cmbFiltroCategoriaAcc
            // 
            this.cmbFiltroCategoriaAcc.FormattingEnabled = true;
            this.cmbFiltroCategoriaAcc.Items.AddRange(new object[] {
            "Vidriería",
            "Material metálico",
            "Plásticos y descartables",
            "Instrumentos de medición",
            "Accesorios de calentamiento",
            "Otros",
            ""});
            this.cmbFiltroCategoriaAcc.Location = new System.Drawing.Point(588, 18);
            this.cmbFiltroCategoriaAcc.Name = "cmbFiltroCategoriaAcc";
            this.cmbFiltroCategoriaAcc.Size = new System.Drawing.Size(159, 25);
            this.cmbFiltroCategoriaAcc.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(513, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Categoría:";
            // 
            // cmbFiltroStockAcc
            // 
            this.cmbFiltroStockAcc.FormattingEnabled = true;
            this.cmbFiltroStockAcc.Items.AddRange(new object[] {
            "Normal",
            "Bajo",
            "Agotado"});
            this.cmbFiltroStockAcc.Location = new System.Drawing.Point(374, 18);
            this.cmbFiltroStockAcc.Name = "cmbFiltroStockAcc";
            this.cmbFiltroStockAcc.Size = new System.Drawing.Size(107, 25);
            this.cmbFiltroStockAcc.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(260, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Estado de stock:";
            // 
            // txtFiltroNombreAcc
            // 
            this.txtFiltroNombreAcc.Location = new System.Drawing.Point(100, 21);
            this.txtFiltroNombreAcc.Name = "txtFiltroNombreAcc";
            this.txtFiltroNombreAcc.Size = new System.Drawing.Size(138, 25);
            this.txtFiltroNombreAcc.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nombre:";
            // 
            // FrmAccesorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestorLaboratorio.Properties.Resources.BackbrownDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmAccesorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Accesorios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockAcc)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccesorios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNombreAcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtDescAcc;
        private System.Windows.Forms.NumericUpDown nudStockAcc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUbiAcc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminarAcc;
        private System.Windows.Forms.Button btnAgregarAcc;
        private System.Windows.Forms.Button btnModificarAcc;
        private System.Windows.Forms.Button btnLimpiarAcc;
        private System.Windows.Forms.TextBox txtFiltroNombreAcc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbFiltroStockAcc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCategoriaAcc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvAccesorios;
        private System.Windows.Forms.ComboBox cmbFiltroCategoriaAcc;
        private System.Windows.Forms.Label label8;
    }
}