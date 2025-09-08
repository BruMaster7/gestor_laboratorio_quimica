namespace GestorLaboratorio
{
    partial class FrmAlertas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlertas));
            this.label1 = new System.Windows.Forms.Label();
            this.listAlertas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Name = "label1";
            // 
            // listAlertas
            // 
            this.listAlertas.BackColor = System.Drawing.Color.SaddleBrown;
            this.listAlertas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.listAlertas, "listAlertas");
            this.listAlertas.ForeColor = System.Drawing.SystemColors.Menu;
            this.listAlertas.FormattingEnabled = true;
            this.listAlertas.Items.AddRange(new object[] {
            resources.GetString("listAlertas.Items"),
            resources.GetString("listAlertas.Items1"),
            resources.GetString("listAlertas.Items2"),
            resources.GetString("listAlertas.Items3"),
            resources.GetString("listAlertas.Items4"),
            resources.GetString("listAlertas.Items5")});
            this.listAlertas.Name = "listAlertas";
            this.listAlertas.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // FrmAlertas
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestorLaboratorio.Properties.Resources.BackbrownDark;
            this.Controls.Add(this.listAlertas);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "FrmAlertas";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listAlertas;
    }
}