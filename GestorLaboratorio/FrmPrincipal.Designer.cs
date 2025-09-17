namespace GestorLaboratorio
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            menuStrip1 = new MenuStrip();
            toolStripMenuItem7 = new ToolStripMenuItem();
            gestiónToolStripMenuItem = new ToolStripMenuItem();
            sustanciasToolStripMenuItem = new ToolStripMenuItem();
            gestionarExistentesToolStripMenuItem = new ToolStripMenuItem();
            añadirNuevaToolStripMenuItem = new ToolStripMenuItem();
            accesoriosToolStripMenuItem = new ToolStripMenuItem();
            gestorDeExistentesToolStripMenuItem = new ToolStripMenuItem();
            añadirNuevoToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            prácticasToolStripMenuItem = new ToolStripMenuItem();
            agendaToolStripMenuItem = new ToolStripMenuItem();
            formularioToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            alertasToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            historialToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightGreen;
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem7, gestiónToolStripMenuItem, toolStripMenuItem1, prácticasToolStripMenuItem, toolStripMenuItem2, alertasToolStripMenuItem, toolStripMenuItem3, historialToolStripMenuItem, toolStripMenuItem5, salirToolStripMenuItem, toolStripMenuItem6 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(145, 749);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.Enabled = false;
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(130, 31);
            toolStripMenuItem7.Text = "------------";
            // 
            // gestiónToolStripMenuItem
            // 
            gestiónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sustanciasToolStripMenuItem, accesoriosToolStripMenuItem });
            gestiónToolStripMenuItem.Name = "gestiónToolStripMenuItem";
            gestiónToolStripMenuItem.Size = new Size(130, 31);
            gestiónToolStripMenuItem.Text = "Gestión";
            // 
            // sustanciasToolStripMenuItem
            // 
            sustanciasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gestionarExistentesToolStripMenuItem, añadirNuevaToolStripMenuItem });
            sustanciasToolStripMenuItem.Name = "sustanciasToolStripMenuItem";
            sustanciasToolStripMenuItem.Size = new Size(215, 32);
            sustanciasToolStripMenuItem.Text = "Sustancias";
            // 
            // gestionarExistentesToolStripMenuItem
            // 
            gestionarExistentesToolStripMenuItem.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gestionarExistentesToolStripMenuItem.Name = "gestionarExistentesToolStripMenuItem";
            gestionarExistentesToolStripMenuItem.Size = new Size(279, 26);
            gestionarExistentesToolStripMenuItem.Text = "Gestionar existentes";
            gestionarExistentesToolStripMenuItem.Click += gestionarExistentesToolStripMenuItem_Click;
            // 
            // añadirNuevaToolStripMenuItem
            // 
            añadirNuevaToolStripMenuItem.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            añadirNuevaToolStripMenuItem.Name = "añadirNuevaToolStripMenuItem";
            añadirNuevaToolStripMenuItem.Size = new Size(279, 26);
            añadirNuevaToolStripMenuItem.Text = "Añadir nueva";
            añadirNuevaToolStripMenuItem.Click += añadirNuevaToolStripMenuItem_Click;
            // 
            // accesoriosToolStripMenuItem
            // 
            accesoriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gestorDeExistentesToolStripMenuItem, añadirNuevoToolStripMenuItem });
            accesoriosToolStripMenuItem.Name = "accesoriosToolStripMenuItem";
            accesoriosToolStripMenuItem.Size = new Size(215, 32);
            accesoriosToolStripMenuItem.Text = "Accesorios";
            // 
            // gestorDeExistentesToolStripMenuItem
            // 
            gestorDeExistentesToolStripMenuItem.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gestorDeExistentesToolStripMenuItem.Name = "gestorDeExistentesToolStripMenuItem";
            gestorDeExistentesToolStripMenuItem.Size = new Size(275, 26);
            gestorDeExistentesToolStripMenuItem.Text = "Gestor de existentes";
            gestorDeExistentesToolStripMenuItem.Click += gestorDeExistentesToolStripMenuItem_Click;
            // 
            // añadirNuevoToolStripMenuItem
            // 
            añadirNuevoToolStripMenuItem.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            añadirNuevoToolStripMenuItem.Name = "añadirNuevoToolStripMenuItem";
            añadirNuevoToolStripMenuItem.Size = new Size(275, 26);
            añadirNuevoToolStripMenuItem.Text = "Añadir nuevo";
            añadirNuevoToolStripMenuItem.Click += añadirNuevoToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Enabled = false;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(130, 31);
            toolStripMenuItem1.Text = "------------";
            // 
            // prácticasToolStripMenuItem
            // 
            prácticasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agendaToolStripMenuItem, formularioToolStripMenuItem });
            prácticasToolStripMenuItem.Name = "prácticasToolStripMenuItem";
            prácticasToolStripMenuItem.Size = new Size(130, 31);
            prácticasToolStripMenuItem.Text = "Prácticas";
            // 
            // agendaToolStripMenuItem
            // 
            agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            agendaToolStripMenuItem.Size = new Size(236, 32);
            agendaToolStripMenuItem.Text = "Agenda";
            agendaToolStripMenuItem.Click += agendaToolStripMenuItem_Click;
            // 
            // formularioToolStripMenuItem
            // 
            formularioToolStripMenuItem.Name = "formularioToolStripMenuItem";
            formularioToolStripMenuItem.Size = new Size(236, 32);
            formularioToolStripMenuItem.Text = "Formularios";
            formularioToolStripMenuItem.Click += formularioToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Enabled = false;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(130, 31);
            toolStripMenuItem2.Text = "------------";
            // 
            // alertasToolStripMenuItem
            // 
            alertasToolStripMenuItem.Name = "alertasToolStripMenuItem";
            alertasToolStripMenuItem.Size = new Size(130, 31);
            alertasToolStripMenuItem.Text = "Alertas";
            alertasToolStripMenuItem.Click += alertasToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Enabled = false;
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(130, 31);
            toolStripMenuItem3.Text = "------------";
            // 
            // historialToolStripMenuItem
            // 
            historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            historialToolStripMenuItem.Size = new Size(130, 31);
            historialToolStripMenuItem.Text = "Historial";
            historialToolStripMenuItem.Click += historialToolStripMenuItem_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Enabled = false;
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(130, 31);
            toolStripMenuItem5.Text = "------------";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(130, 31);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Enabled = false;
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(130, 31);
            toolStripMenuItem6.Text = "------------";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightGreen;
            pictureBox1.Image = Properties.Resources.ProbetaLogo;
            pictureBox1.Location = new Point(-7, 502);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 172);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.LabFakeReSize;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1182, 749);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new Size(1491, 825);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sustanciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accesoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prácticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alertasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem gestionarExistentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirNuevaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestorDeExistentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirNuevoToolStripMenuItem;
    }
}