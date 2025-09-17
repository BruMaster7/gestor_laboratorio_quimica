namespace GestorLaboratorio
{
    partial class FrmFormularios
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
            label1 = new Label();
            listSolicitudesForms = new ListBox();
            label2 = new Label();
            txtDocenteForms = new TextBox();
            txtFechaHoraForms = new TextBox();
            label3 = new Label();
            txtGrupoForms = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtDetallesForms = new TextBox();
            txtMotivoForms = new TextBox();
            label6 = new Label();
            btnAprobarForms = new Button();
            btnRechazarForms = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(401, 27);
            label1.Name = "label1";
            label1.Size = new Size(206, 25);
            label1.TabIndex = 0;
            label1.Text = "Solcitudes pendientes";
            // 
            // listSolicitudesForms
            // 
            listSolicitudesForms.BackColor = Color.FromArgb(128, 64, 0);
            listSolicitudesForms.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listSolicitudesForms.ForeColor = SystemColors.Menu;
            listSolicitudesForms.FormattingEnabled = true;
            listSolicitudesForms.ItemHeight = 15;
            listSolicitudesForms.Items.AddRange(new object[] { "[2025-09-03] - Prof. García - Práctica: Reacciones ácido-base", "[2025-09-05] - Prof. López - Práctica: Microscopía" });
            listSolicitudesForms.Location = new Point(322, 55);
            listSolicitudesForms.Name = "listSolicitudesForms";
            listSolicitudesForms.Size = new Size(364, 109);
            listSolicitudesForms.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(30, 238);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre del docente:";
            // 
            // txtDocenteForms
            // 
            txtDocenteForms.BackColor = Color.Sienna;
            txtDocenteForms.BorderStyle = BorderStyle.FixedSingle;
            txtDocenteForms.ForeColor = SystemColors.Window;
            txtDocenteForms.Location = new Point(155, 236);
            txtDocenteForms.Name = "txtDocenteForms";
            txtDocenteForms.ReadOnly = true;
            txtDocenteForms.Size = new Size(131, 23);
            txtDocenteForms.TabIndex = 4;
            txtDocenteForms.Text = "Pepito Lopez";
            // 
            // txtFechaHoraForms
            // 
            txtFechaHoraForms.BackColor = Color.Sienna;
            txtFechaHoraForms.BorderStyle = BorderStyle.FixedSingle;
            txtFechaHoraForms.ForeColor = SystemColors.Window;
            txtFechaHoraForms.Location = new Point(155, 312);
            txtFechaHoraForms.Name = "txtFechaHoraForms";
            txtFechaHoraForms.ReadOnly = true;
            txtFechaHoraForms.Size = new Size(111, 23);
            txtFechaHoraForms.TabIndex = 6;
            txtFechaHoraForms.Text = "09/03 - 11:15 AM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(72, 314);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 5;
            label3.Text = "Fecha y hora:";
            // 
            // txtGrupoForms
            // 
            txtGrupoForms.BackColor = Color.Sienna;
            txtGrupoForms.BorderStyle = BorderStyle.FixedSingle;
            txtGrupoForms.ForeColor = SystemColors.Window;
            txtGrupoForms.Location = new Point(155, 272);
            txtGrupoForms.Name = "txtGrupoForms";
            txtGrupoForms.ReadOnly = true;
            txtGrupoForms.Size = new Size(34, 23);
            txtGrupoForms.TabIndex = 8;
            txtGrupoForms.Text = "9º5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(106, 274);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 7;
            label4.Text = "Grupo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(9, 356);
            label5.Name = "label5";
            label5.Size = new Size(140, 15);
            label5.TabIndex = 9;
            label5.Text = "Detalles/Requerimientos:";
            // 
            // txtDetallesForms
            // 
            txtDetallesForms.BackColor = Color.Sienna;
            txtDetallesForms.BorderStyle = BorderStyle.FixedSingle;
            txtDetallesForms.ForeColor = SystemColors.Window;
            txtDetallesForms.Location = new Point(155, 354);
            txtDetallesForms.Multiline = true;
            txtDetallesForms.Name = "txtDetallesForms";
            txtDetallesForms.ReadOnly = true;
            txtDetallesForms.Size = new Size(269, 97);
            txtDetallesForms.TabIndex = 10;
            txtDetallesForms.Text = "Va a ser una clase de deteccion de PH... vamos a precisar sales y el medidor... etc";
            // 
            // txtMotivoForms
            // 
            txtMotivoForms.BackColor = Color.FromArgb(64, 0, 0);
            txtMotivoForms.BorderStyle = BorderStyle.FixedSingle;
            txtMotivoForms.ForeColor = SystemColors.Window;
            txtMotivoForms.Location = new Point(622, 262);
            txtMotivoForms.Multiline = true;
            txtMotivoForms.Name = "txtMotivoForms";
            txtMotivoForms.Size = new Size(279, 119);
            txtMotivoForms.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(635, 239);
            label6.Name = "label6";
            label6.Size = new Size(249, 20);
            label6.TabIndex = 11;
            label6.Text = "Motivo de rechazo o comentario";
            // 
            // btnAprobarForms
            // 
            btnAprobarForms.BackColor = Color.Green;
            btnAprobarForms.FlatStyle = FlatStyle.Popup;
            btnAprobarForms.Location = new Point(622, 397);
            btnAprobarForms.Name = "btnAprobarForms";
            btnAprobarForms.Size = new Size(135, 34);
            btnAprobarForms.TabIndex = 13;
            btnAprobarForms.Text = "Aprobar";
            btnAprobarForms.UseVisualStyleBackColor = false;
            // 
            // btnRechazarForms
            // 
            btnRechazarForms.BackColor = Color.DarkRed;
            btnRechazarForms.FlatStyle = FlatStyle.Popup;
            btnRechazarForms.Location = new Point(766, 397);
            btnRechazarForms.Name = "btnRechazarForms";
            btnRechazarForms.Size = new Size(135, 34);
            btnRechazarForms.TabIndex = 14;
            btnRechazarForms.Text = "Rechazar";
            btnRechazarForms.UseVisualStyleBackColor = false;
            // 
            // FrmFormularios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackbrownDark;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(962, 500);
            Controls.Add(btnRechazarForms);
            Controls.Add(btnAprobarForms);
            Controls.Add(txtMotivoForms);
            Controls.Add(label6);
            Controls.Add(txtDetallesForms);
            Controls.Add(label5);
            Controls.Add(txtGrupoForms);
            Controls.Add(label4);
            Controls.Add(txtFechaHoraForms);
            Controls.Add(label3);
            Controls.Add(txtDocenteForms);
            Controls.Add(label2);
            Controls.Add(listSolicitudesForms);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.Menu;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmFormularios";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formularios";
            TransparencyKey = Color.Transparent;
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listSolicitudesForms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDocenteForms;
        private System.Windows.Forms.TextBox txtFechaHoraForms;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGrupoForms;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDetallesForms;
        private System.Windows.Forms.TextBox txtMotivoForms;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAprobarForms;
        private System.Windows.Forms.Button btnRechazarForms;
    }
}