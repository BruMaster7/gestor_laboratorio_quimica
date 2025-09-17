namespace GestorLaboratorio
{
    partial class FrmAgenda
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
            label1 = new Label();
            dgvPracticasProg = new DataGridView();
            Fecha = new DataGridViewTextBoxColumn();
            Hora = new DataGridViewTextBoxColumn();
            Docente = new DataGridViewTextBoxColumn();
            Práctica = new DataGridViewTextBoxColumn();
            Grupo = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label3 = new Label();
            txtDocenteAgenda = new TextBox();
            label4 = new Label();
            txtGrupoAgenda = new TextBox();
            aaa = new Label();
            dtpFechaAgenda = new DateTimePicker();
            dtpHoraAgenda = new DateTimePicker();
            label6 = new Label();
            txtDetallesAgenda = new TextBox();
            txtPracticaAgenda = new TextBox();
            label7 = new Label();
            btnAgregarAgenda = new Button();
            btnModificarAgenda = new Button();
            btnEliminarAgenda = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPracticasProg).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(279, 276);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(234, 30);
            label1.TabIndex = 1;
            label1.Text = "Prácticas programadas";
            // 
            // dgvPracticasProg
            // 
            dgvPracticasProg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPracticasProg.BackgroundColor = Color.FromArgb(5, 23, 0);
            dgvPracticasProg.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dgvPracticasProg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPracticasProg.Columns.AddRange(new DataGridViewColumn[] { Fecha, Hora, Docente, Práctica, Grupo });
            dgvPracticasProg.Location = new Point(-1, 309);
            dgvPracticasProg.Name = "dgvPracticasProg";
            dgvPracticasProg.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPracticasProg.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPracticasProg.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dgvPracticasProg.Size = new Size(785, 154);
            dgvPracticasProg.TabIndex = 2;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            // 
            // Hora
            // 
            Hora.HeaderText = "Hora";
            Hora.Name = "Hora";
            // 
            // Docente
            // 
            Docente.HeaderText = "Docente";
            Docente.Name = "Docente";
            // 
            // Práctica
            // 
            Práctica.HeaderText = "Práctica";
            Práctica.Name = "Práctica";
            // 
            // Grupo
            // 
            Grupo.HeaderText = "Grupo";
            Grupo.Name = "Grupo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(28, 32);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 3;
            label2.Text = "Fecha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(34, 76);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 5;
            label3.Text = "Hora:";
            // 
            // txtDocenteAgenda
            // 
            txtDocenteAgenda.Location = new Point(87, 117);
            txtDocenteAgenda.Name = "txtDocenteAgenda";
            txtDocenteAgenda.Size = new Size(129, 27);
            txtDocenteAgenda.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(10, 117);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 7;
            label4.Text = "Docente:";
            // 
            // txtGrupoAgenda
            // 
            txtGrupoAgenda.Location = new Point(87, 158);
            txtGrupoAgenda.Name = "txtGrupoAgenda";
            txtGrupoAgenda.Size = new Size(129, 27);
            txtGrupoAgenda.TabIndex = 10;
            // 
            // aaa
            // 
            aaa.AutoSize = true;
            aaa.BackColor = Color.Transparent;
            aaa.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            aaa.ForeColor = SystemColors.ButtonFace;
            aaa.Location = new Point(24, 158);
            aaa.Name = "aaa";
            aaa.Size = new Size(57, 20);
            aaa.TabIndex = 9;
            aaa.Text = "Grupo:";
            // 
            // dtpFechaAgenda
            // 
            dtpFechaAgenda.Format = DateTimePickerFormat.Short;
            dtpFechaAgenda.Location = new Point(87, 32);
            dtpFechaAgenda.Name = "dtpFechaAgenda";
            dtpFechaAgenda.Size = new Size(118, 27);
            dtpFechaAgenda.TabIndex = 11;
            // 
            // dtpHoraAgenda
            // 
            dtpHoraAgenda.Format = DateTimePickerFormat.Time;
            dtpHoraAgenda.Location = new Point(87, 76);
            dtpHoraAgenda.Name = "dtpHoraAgenda";
            dtpHoraAgenda.Size = new Size(118, 27);
            dtpHoraAgenda.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(444, 32);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 13;
            label6.Text = "Detalles:";
            // 
            // txtDetallesAgenda
            // 
            txtDetallesAgenda.Location = new Point(519, 34);
            txtDetallesAgenda.Multiline = true;
            txtDetallesAgenda.Name = "txtDetallesAgenda";
            txtDetallesAgenda.Size = new Size(231, 121);
            txtDetallesAgenda.TabIndex = 14;
            // 
            // txtPracticaAgenda
            // 
            txtPracticaAgenda.Location = new Point(87, 200);
            txtPracticaAgenda.Name = "txtPracticaAgenda";
            txtPracticaAgenda.Size = new Size(129, 27);
            txtPracticaAgenda.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(13, 200);
            label7.Name = "label7";
            label7.Size = new Size(68, 20);
            label7.TabIndex = 15;
            label7.Text = "Práctica:";
            // 
            // btnAgregarAgenda
            // 
            btnAgregarAgenda.BackColor = Color.DarkGreen;
            btnAgregarAgenda.FlatStyle = FlatStyle.Popup;
            btnAgregarAgenda.ForeColor = SystemColors.Control;
            btnAgregarAgenda.Location = new Point(284, 216);
            btnAgregarAgenda.Name = "btnAgregarAgenda";
            btnAgregarAgenda.Size = new Size(106, 32);
            btnAgregarAgenda.TabIndex = 17;
            btnAgregarAgenda.Text = "Agregar";
            btnAgregarAgenda.UseVisualStyleBackColor = false;
            // 
            // btnModificarAgenda
            // 
            btnModificarAgenda.BackColor = Color.Olive;
            btnModificarAgenda.FlatStyle = FlatStyle.Popup;
            btnModificarAgenda.ForeColor = SystemColors.Control;
            btnModificarAgenda.Location = new Point(407, 216);
            btnModificarAgenda.Name = "btnModificarAgenda";
            btnModificarAgenda.Size = new Size(106, 32);
            btnModificarAgenda.TabIndex = 18;
            btnModificarAgenda.Text = "Modificar";
            btnModificarAgenda.UseVisualStyleBackColor = false;
            // 
            // btnEliminarAgenda
            // 
            btnEliminarAgenda.BackColor = Color.Maroon;
            btnEliminarAgenda.FlatStyle = FlatStyle.Popup;
            btnEliminarAgenda.ForeColor = SystemColors.Control;
            btnEliminarAgenda.Location = new Point(530, 216);
            btnEliminarAgenda.Name = "btnEliminarAgenda";
            btnEliminarAgenda.Size = new Size(106, 32);
            btnEliminarAgenda.TabIndex = 19;
            btnEliminarAgenda.Text = "Eliminar";
            btnEliminarAgenda.UseVisualStyleBackColor = false;
            // 
            // FrmAgenda
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackgreenDark;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 461);
            Controls.Add(btnEliminarAgenda);
            Controls.Add(btnModificarAgenda);
            Controls.Add(btnAgregarAgenda);
            Controls.Add(txtPracticaAgenda);
            Controls.Add(label7);
            Controls.Add(txtDetallesAgenda);
            Controls.Add(label6);
            Controls.Add(dtpHoraAgenda);
            Controls.Add(dtpFechaAgenda);
            Controls.Add(txtGrupoAgenda);
            Controls.Add(aaa);
            Controls.Add(txtDocenteAgenda);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvPracticasProg);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAgenda";
            Text = "Agenda";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvPracticasProg).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPracticasProg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Docente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Práctica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDocenteAgenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGrupoAgenda;
        private System.Windows.Forms.Label aaa;
        private System.Windows.Forms.DateTimePicker dtpFechaAgenda;
        private System.Windows.Forms.DateTimePicker dtpHoraAgenda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDetallesAgenda;
        private System.Windows.Forms.TextBox txtPracticaAgenda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAgregarAgenda;
        private System.Windows.Forms.Button btnModificarAgenda;
        private System.Windows.Forms.Button btnEliminarAgenda;
    }
}