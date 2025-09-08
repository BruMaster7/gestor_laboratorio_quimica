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
            this.label1 = new System.Windows.Forms.Label();
            this.listSolicitudesForms = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDocenteForms = new System.Windows.Forms.TextBox();
            this.txtFechaHoraForms = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGrupoForms = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDetallesForms = new System.Windows.Forms.TextBox();
            this.txtMotivoForms = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAprobarForms = new System.Windows.Forms.Button();
            this.btnRechazarForms = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(293, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Solcitudes pendientes";
            // 
            // listSolicitudesForms
            // 
            this.listSolicitudesForms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.listSolicitudesForms.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSolicitudesForms.ForeColor = System.Drawing.SystemColors.Menu;
            this.listSolicitudesForms.FormattingEnabled = true;
            this.listSolicitudesForms.ItemHeight = 15;
            this.listSolicitudesForms.Items.AddRange(new object[] {
            "[2025-09-03] - Prof. García - Práctica: Reacciones ácido-base",
            "[2025-09-05] - Prof. López - Práctica: Microscopía"});
            this.listSolicitudesForms.Location = new System.Drawing.Point(214, 37);
            this.listSolicitudesForms.Name = "listSolicitudesForms";
            this.listSolicitudesForms.Size = new System.Drawing.Size(364, 109);
            this.listSolicitudesForms.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(24, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre del docente:";
            // 
            // txtDocenteForms
            // 
            this.txtDocenteForms.BackColor = System.Drawing.Color.Sienna;
            this.txtDocenteForms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDocenteForms.ForeColor = System.Drawing.SystemColors.Window;
            this.txtDocenteForms.Location = new System.Drawing.Point(149, 169);
            this.txtDocenteForms.Name = "txtDocenteForms";
            this.txtDocenteForms.ReadOnly = true;
            this.txtDocenteForms.Size = new System.Drawing.Size(131, 23);
            this.txtDocenteForms.TabIndex = 4;
            this.txtDocenteForms.Text = "Pepito Lopez";
            // 
            // txtFechaHoraForms
            // 
            this.txtFechaHoraForms.BackColor = System.Drawing.Color.Sienna;
            this.txtFechaHoraForms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFechaHoraForms.ForeColor = System.Drawing.SystemColors.Window;
            this.txtFechaHoraForms.Location = new System.Drawing.Point(149, 245);
            this.txtFechaHoraForms.Name = "txtFechaHoraForms";
            this.txtFechaHoraForms.ReadOnly = true;
            this.txtFechaHoraForms.Size = new System.Drawing.Size(111, 23);
            this.txtFechaHoraForms.TabIndex = 6;
            this.txtFechaHoraForms.Text = "09/03 - 11:15 AM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(66, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha y hora:";
            // 
            // txtGrupoForms
            // 
            this.txtGrupoForms.BackColor = System.Drawing.Color.Sienna;
            this.txtGrupoForms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGrupoForms.ForeColor = System.Drawing.SystemColors.Window;
            this.txtGrupoForms.Location = new System.Drawing.Point(149, 205);
            this.txtGrupoForms.Name = "txtGrupoForms";
            this.txtGrupoForms.ReadOnly = true;
            this.txtGrupoForms.Size = new System.Drawing.Size(34, 23);
            this.txtGrupoForms.TabIndex = 8;
            this.txtGrupoForms.Text = "9º5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(100, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Grupo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(3, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Detalles/Requerimientos:";
            // 
            // txtDetallesForms
            // 
            this.txtDetallesForms.BackColor = System.Drawing.Color.Sienna;
            this.txtDetallesForms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetallesForms.ForeColor = System.Drawing.SystemColors.Window;
            this.txtDetallesForms.Location = new System.Drawing.Point(149, 287);
            this.txtDetallesForms.Multiline = true;
            this.txtDetallesForms.Name = "txtDetallesForms";
            this.txtDetallesForms.ReadOnly = true;
            this.txtDetallesForms.Size = new System.Drawing.Size(269, 97);
            this.txtDetallesForms.TabIndex = 10;
            this.txtDetallesForms.Text = "Va a ser una clase de deteccion de PH... vamos a precisar sales y el medidor... e" +
    "tc";
            // 
            // txtMotivoForms
            // 
            this.txtMotivoForms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtMotivoForms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMotivoForms.ForeColor = System.Drawing.SystemColors.Window;
            this.txtMotivoForms.Location = new System.Drawing.Point(493, 205);
            this.txtMotivoForms.Multiline = true;
            this.txtMotivoForms.Name = "txtMotivoForms";
            this.txtMotivoForms.Size = new System.Drawing.Size(279, 69);
            this.txtMotivoForms.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(511, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Motivo de rechazo o comentario";
            // 
            // btnAprobarForms
            // 
            this.btnAprobarForms.BackColor = System.Drawing.Color.Green;
            this.btnAprobarForms.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAprobarForms.Location = new System.Drawing.Point(493, 298);
            this.btnAprobarForms.Name = "btnAprobarForms";
            this.btnAprobarForms.Size = new System.Drawing.Size(135, 34);
            this.btnAprobarForms.TabIndex = 13;
            this.btnAprobarForms.Text = "Aprobar";
            this.btnAprobarForms.UseVisualStyleBackColor = false;
            // 
            // btnRechazarForms
            // 
            this.btnRechazarForms.BackColor = System.Drawing.Color.DarkRed;
            this.btnRechazarForms.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRechazarForms.Location = new System.Drawing.Point(637, 298);
            this.btnRechazarForms.Name = "btnRechazarForms";
            this.btnRechazarForms.Size = new System.Drawing.Size(135, 34);
            this.btnRechazarForms.TabIndex = 14;
            this.btnRechazarForms.Text = "Rechazar";
            this.btnRechazarForms.UseVisualStyleBackColor = false;
            // 
            // FrmFormularios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestorLaboratorio.Properties.Resources.BackbrownDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnRechazarForms);
            this.Controls.Add(this.btnAprobarForms);
            this.Controls.Add(this.txtMotivoForms);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDetallesForms);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGrupoForms);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFechaHoraForms);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDocenteForms);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listSolicitudesForms);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Menu;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(948, 594);
            this.Name = "FrmFormularios";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formularios";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);
            this.PerformLayout();

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