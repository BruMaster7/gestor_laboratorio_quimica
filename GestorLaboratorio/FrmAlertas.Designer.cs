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
            label1 = new Label();
            listAlertas = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Name = "label1";
            // 
            // listAlertas
            // 
            listAlertas.BackColor = Color.SaddleBrown;
            listAlertas.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(listAlertas, "listAlertas");
            listAlertas.ForeColor = SystemColors.Menu;
            listAlertas.FormattingEnabled = true;
            listAlertas.Items.AddRange(new object[] { resources.GetString("listAlertas.Items"), resources.GetString("listAlertas.Items1"), resources.GetString("listAlertas.Items2"), resources.GetString("listAlertas.Items3"), resources.GetString("listAlertas.Items4"), resources.GetString("listAlertas.Items5") });
            listAlertas.Name = "listAlertas";
            listAlertas.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // FrmAlertas
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackbrownDark;
            Controls.Add(listAlertas);
            Controls.Add(label1);
            DoubleBuffered = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAlertas";
            ShowIcon = false;
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listAlertas;
    }
}