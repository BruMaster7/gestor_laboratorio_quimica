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
            listHistorial = new ListBox();
            btnImpHistorial = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // listHistorial
            // 
            listHistorial.BackColor = Color.Sienna;
            listHistorial.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listHistorial.ForeColor = SystemColors.Info;
            listHistorial.FormattingEnabled = true;
            listHistorial.ItemHeight = 21;
            listHistorial.Items.AddRange(new object[] { "Alerta: Vencimiento ALcohol...", "Eliminacion práctica agendada", "Practica añadida manualmente: \" \"", "Formulario Aceptado: 00/00/00 Pepita Lopez" });
            listHistorial.Location = new Point(14, 102);
            listHistorial.Margin = new Padding(4, 3, 4, 3);
            listHistorial.Name = "listHistorial";
            listHistorial.Size = new Size(681, 403);
            listHistorial.TabIndex = 0;
            // 
            // btnImpHistorial
            // 
            btnImpHistorial.BackColor = Color.FromArgb(128, 64, 0);
            btnImpHistorial.FlatStyle = FlatStyle.Popup;
            btnImpHistorial.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnImpHistorial.ForeColor = SystemColors.Control;
            btnImpHistorial.Location = new Point(702, 264);
            btnImpHistorial.Margin = new Padding(4, 3, 4, 3);
            btnImpHistorial.Name = "btnImpHistorial";
            btnImpHistorial.Size = new Size(182, 78);
            btnImpHistorial.TabIndex = 1;
            btnImpHistorial.Text = "Imprimir reporte";
            btnImpHistorial.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(244, 36);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(163, 50);
            label1.TabIndex = 2;
            label1.Text = "Historial";
            // 
            // FrmHistorial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackbrownDark;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(915, 532);
            Controls.Add(label1);
            Controls.Add(btnImpHistorial);
            Controls.Add(listHistorial);
            DoubleBuffered = true;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmHistorial";
            ShowIcon = false;
            Text = "Historial";
            WindowState = FormWindowState.Maximized;
            Load += FrmHistorial_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listHistorial;
        private System.Windows.Forms.Button btnImpHistorial;
        private System.Windows.Forms.Label label1;
    }
}