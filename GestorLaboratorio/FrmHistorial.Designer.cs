namespace GestorLaboratorio
{
    partial class FrmHistorial
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
            this.listHistorial = new System.Windows.Forms.ListBox();
            this.btnImpHistorial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listHistorial
            // 
            this.listHistorial.BackColor = System.Drawing.Color.Sienna;
            this.listHistorial.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listHistorial.ForeColor = System.Drawing.SystemColors.Info;
            this.listHistorial.FormattingEnabled = true;
            this.listHistorial.ItemHeight = 21;
            this.listHistorial.Items.AddRange(new object[] {
            "Alerta: Vencimiento ALcohol...",
            "Eliminacion práctica agendada",
            "Practica añadida manualmente: \" \"",
            "Formulario Aceptado: 00/00/00 Pepita Lopez"});
            this.listHistorial.Location = new System.Drawing.Point(12, 88);
            this.listHistorial.Name = "listHistorial";
            this.listHistorial.Size = new System.Drawing.Size(584, 361);
            this.listHistorial.TabIndex = 0;
            // 
            // btnImpHistorial
            // 
            this.btnImpHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnImpHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImpHistorial.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImpHistorial.ForeColor = System.Drawing.SystemColors.Control;
            this.btnImpHistorial.Location = new System.Drawing.Point(602, 229);
            this.btnImpHistorial.Name = "btnImpHistorial";
            this.btnImpHistorial.Size = new System.Drawing.Size(156, 68);
            this.btnImpHistorial.TabIndex = 1;
            this.btnImpHistorial.Text = "Imprimir reporte";
            this.btnImpHistorial.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(209, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Historial";
            // 
            // FrmHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestorLaboratorio.Properties.Resources.BackbrownDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImpHistorial);
            this.Controls.Add(this.listHistorial);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.Name = "FrmHistorial";
            this.ShowIcon = false;
            this.Text = "Historial";
            this.Load += new System.EventHandler(this.FrmHistorial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listHistorial;
        private System.Windows.Forms.Button btnImpHistorial;
        private System.Windows.Forms.Label label1;
    }
}