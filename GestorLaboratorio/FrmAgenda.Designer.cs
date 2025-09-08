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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPracticasProg = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Docente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Práctica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDocenteAgenda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGrupoAgenda = new System.Windows.Forms.TextBox();
            this.aaa = new System.Windows.Forms.Label();
            this.dtpFechaAgenda = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraAgenda = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDetallesAgenda = new System.Windows.Forms.TextBox();
            this.txtPracticaAgenda = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAgregarAgenda = new System.Windows.Forms.Button();
            this.btnModificarAgenda = new System.Windows.Forms.Button();
            this.btnEliminarAgenda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPracticasProg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(279, 276);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prácticas programadas";
            // 
            // dgvPracticasProg
            // 
            this.dgvPracticasProg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPracticasProg.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(0)))));
            this.dgvPracticasProg.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvPracticasProg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPracticasProg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Hora,
            this.Docente,
            this.Práctica,
            this.Grupo});
            this.dgvPracticasProg.Location = new System.Drawing.Point(-1, 309);
            this.dgvPracticasProg.Name = "dgvPracticasProg";
            this.dgvPracticasProg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPracticasProg.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPracticasProg.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvPracticasProg.Size = new System.Drawing.Size(785, 154);
            this.dgvPracticasProg.TabIndex = 2;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            // 
            // Docente
            // 
            this.Docente.HeaderText = "Docente";
            this.Docente.Name = "Docente";
            // 
            // Práctica
            // 
            this.Práctica.HeaderText = "Práctica";
            this.Práctica.Name = "Práctica";
            // 
            // Grupo
            // 
            this.Grupo.HeaderText = "Grupo";
            this.Grupo.Name = "Grupo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(28, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(34, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hora:";
            // 
            // txtDocenteAgenda
            // 
            this.txtDocenteAgenda.Location = new System.Drawing.Point(87, 117);
            this.txtDocenteAgenda.Name = "txtDocenteAgenda";
            this.txtDocenteAgenda.Size = new System.Drawing.Size(129, 27);
            this.txtDocenteAgenda.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(10, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Docente:";
            // 
            // txtGrupoAgenda
            // 
            this.txtGrupoAgenda.Location = new System.Drawing.Point(87, 158);
            this.txtGrupoAgenda.Name = "txtGrupoAgenda";
            this.txtGrupoAgenda.Size = new System.Drawing.Size(129, 27);
            this.txtGrupoAgenda.TabIndex = 10;
            // 
            // aaa
            // 
            this.aaa.AutoSize = true;
            this.aaa.BackColor = System.Drawing.Color.Transparent;
            this.aaa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aaa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.aaa.Location = new System.Drawing.Point(24, 158);
            this.aaa.Name = "aaa";
            this.aaa.Size = new System.Drawing.Size(57, 20);
            this.aaa.TabIndex = 9;
            this.aaa.Text = "Grupo:";
            // 
            // dtpFechaAgenda
            // 
            this.dtpFechaAgenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAgenda.Location = new System.Drawing.Point(87, 32);
            this.dtpFechaAgenda.Name = "dtpFechaAgenda";
            this.dtpFechaAgenda.Size = new System.Drawing.Size(118, 27);
            this.dtpFechaAgenda.TabIndex = 11;
            // 
            // dtpHoraAgenda
            // 
            this.dtpHoraAgenda.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraAgenda.Location = new System.Drawing.Point(87, 76);
            this.dtpHoraAgenda.Name = "dtpHoraAgenda";
            this.dtpHoraAgenda.Size = new System.Drawing.Size(118, 27);
            this.dtpHoraAgenda.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(444, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Detalles:";
            // 
            // txtDetallesAgenda
            // 
            this.txtDetallesAgenda.Location = new System.Drawing.Point(519, 34);
            this.txtDetallesAgenda.Multiline = true;
            this.txtDetallesAgenda.Name = "txtDetallesAgenda";
            this.txtDetallesAgenda.Size = new System.Drawing.Size(231, 121);
            this.txtDetallesAgenda.TabIndex = 14;
            // 
            // txtPracticaAgenda
            // 
            this.txtPracticaAgenda.Location = new System.Drawing.Point(87, 200);
            this.txtPracticaAgenda.Name = "txtPracticaAgenda";
            this.txtPracticaAgenda.Size = new System.Drawing.Size(129, 27);
            this.txtPracticaAgenda.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(13, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Práctica:";
            // 
            // btnAgregarAgenda
            // 
            this.btnAgregarAgenda.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAgregarAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarAgenda.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregarAgenda.Location = new System.Drawing.Point(284, 216);
            this.btnAgregarAgenda.Name = "btnAgregarAgenda";
            this.btnAgregarAgenda.Size = new System.Drawing.Size(106, 32);
            this.btnAgregarAgenda.TabIndex = 17;
            this.btnAgregarAgenda.Text = "Agregar";
            this.btnAgregarAgenda.UseVisualStyleBackColor = false;
            // 
            // btnModificarAgenda
            // 
            this.btnModificarAgenda.BackColor = System.Drawing.Color.Olive;
            this.btnModificarAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificarAgenda.ForeColor = System.Drawing.SystemColors.Control;
            this.btnModificarAgenda.Location = new System.Drawing.Point(407, 216);
            this.btnModificarAgenda.Name = "btnModificarAgenda";
            this.btnModificarAgenda.Size = new System.Drawing.Size(106, 32);
            this.btnModificarAgenda.TabIndex = 18;
            this.btnModificarAgenda.Text = "Modificar";
            this.btnModificarAgenda.UseVisualStyleBackColor = false;
            // 
            // btnEliminarAgenda
            // 
            this.btnEliminarAgenda.BackColor = System.Drawing.Color.Maroon;
            this.btnEliminarAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarAgenda.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminarAgenda.Location = new System.Drawing.Point(530, 216);
            this.btnEliminarAgenda.Name = "btnEliminarAgenda";
            this.btnEliminarAgenda.Size = new System.Drawing.Size(106, 32);
            this.btnEliminarAgenda.TabIndex = 19;
            this.btnEliminarAgenda.Text = "Eliminar";
            this.btnEliminarAgenda.UseVisualStyleBackColor = false;
            // 
            // FrmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestorLaboratorio.Properties.Resources.BackgreenDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnEliminarAgenda);
            this.Controls.Add(this.btnModificarAgenda);
            this.Controls.Add(this.btnAgregarAgenda);
            this.Controls.Add(this.txtPracticaAgenda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDetallesAgenda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpHoraAgenda);
            this.Controls.Add(this.dtpFechaAgenda);
            this.Controls.Add(this.txtGrupoAgenda);
            this.Controls.Add(this.aaa);
            this.Controls.Add(this.txtDocenteAgenda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPracticasProg);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAgenda";
            this.Text = "Agenda";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPracticasProg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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