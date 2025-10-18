namespace GestorLaboratorio
{
    partial class FrmGestionUsuarios
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
            txtContrasenaUsuario = new TextBox();
            Labellll = new Label();
            txtnombreUsuario = new TextBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            btnCrearUsuario = new Button();
            groupBox2 = new GroupBox();
            btnBorrarUsuario = new Button();
            txtUsuarioAborrar = new TextBox();
            label1 = new Label();
            dgvUsuarios = new DataGridView();
            columnaUsuarios = new DataGridViewTextBoxColumn();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // txtContrasenaUsuario
            // 
            txtContrasenaUsuario.Location = new Point(194, 77);
            txtContrasenaUsuario.Name = "txtContrasenaUsuario";
            txtContrasenaUsuario.PasswordChar = '*';
            txtContrasenaUsuario.Size = new Size(144, 33);
            txtContrasenaUsuario.TabIndex = 14;
            // 
            // Labellll
            // 
            Labellll.AutoSize = true;
            Labellll.BackColor = Color.Transparent;
            Labellll.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Labellll.ForeColor = SystemColors.ButtonFace;
            Labellll.Location = new Point(92, 77);
            Labellll.Name = "Labellll";
            Labellll.Size = new Size(92, 20);
            Labellll.TabIndex = 13;
            Labellll.Text = "Contraseña:";
            // 
            // txtnombreUsuario
            // 
            txtnombreUsuario.Location = new Point(194, 32);
            txtnombreUsuario.Name = "txtnombreUsuario";
            txtnombreUsuario.Size = new Size(144, 33);
            txtnombreUsuario.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(117, 32);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 11;
            label4.Text = "Usuario:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(btnCrearUsuario);
            groupBox1.Controls.Add(txtnombreUsuario);
            groupBox1.Controls.Add(txtContrasenaUsuario);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(Labellll);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.LimeGreen;
            groupBox1.Location = new Point(12, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(377, 170);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Crear usuario";
            // 
            // btnCrearUsuario
            // 
            btnCrearUsuario.BackColor = Color.DarkGreen;
            btnCrearUsuario.FlatStyle = FlatStyle.Popup;
            btnCrearUsuario.ForeColor = SystemColors.ControlLight;
            btnCrearUsuario.Location = new Point(227, 125);
            btnCrearUsuario.Name = "btnCrearUsuario";
            btnCrearUsuario.Size = new Size(89, 36);
            btnCrearUsuario.TabIndex = 15;
            btnCrearUsuario.Text = "Crear";
            btnCrearUsuario.UseVisualStyleBackColor = false;
            btnCrearUsuario.Click += btnCrearUsuario_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(btnBorrarUsuario);
            groupBox2.Controls.Add(txtUsuarioAborrar);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.Red;
            groupBox2.Location = new Point(12, 277);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(377, 125);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Borrar Usuario";
            // 
            // btnBorrarUsuario
            // 
            btnBorrarUsuario.BackColor = Color.Maroon;
            btnBorrarUsuario.FlatStyle = FlatStyle.Popup;
            btnBorrarUsuario.ForeColor = SystemColors.ControlLight;
            btnBorrarUsuario.Location = new Point(227, 71);
            btnBorrarUsuario.Name = "btnBorrarUsuario";
            btnBorrarUsuario.Size = new Size(89, 36);
            btnBorrarUsuario.TabIndex = 16;
            btnBorrarUsuario.Text = "Borrar";
            btnBorrarUsuario.UseVisualStyleBackColor = false;
            btnBorrarUsuario.Click += btnBorrarUsuario_Click;
            // 
            // txtUsuarioAborrar
            // 
            txtUsuarioAborrar.Location = new Point(194, 32);
            txtUsuarioAborrar.Name = "txtUsuarioAborrar";
            txtUsuarioAborrar.Size = new Size(144, 33);
            txtUsuarioAborrar.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(117, 32);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 11;
            label1.Text = "Usuario:";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.BackgroundColor = Color.SaddleBrown;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { columnaUsuarios });
            dgvUsuarios.Location = new Point(520, 71);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.Size = new Size(188, 331);
            dgvUsuarios.TabIndex = 17;
            // 
            // columnaUsuarios
            // 
            columnaUsuarios.HeaderText = "                      Usuarios";
            columnaUsuarios.Name = "columnaUsuarios";
            columnaUsuarios.Width = 185;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(549, 47);
            label2.Name = "label2";
            label2.Size = new Size(130, 21);
            label2.TabIndex = 18;
            label2.Text = "Lista de usuarios";
            // 
            // FrmGestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackbrownDark;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(dgvUsuarios);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Name = "FrmGestionUsuarios";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion de Usuarios";
            Load += FrmGestionUsuarios_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtContrasenaUsuario;
        private Label Labellll;
        private TextBox txtnombreUsuario;
        private Label label4;
        private GroupBox groupBox1;
        private Button btnCrearUsuario;
        private GroupBox groupBox2;
        private Button btnBorrarUsuario;
        private TextBox txtUsuarioAborrar;
        private Label label1;
        private DataGridView dgvUsuarios;
        private Label label2;
        private DataGridViewTextBoxColumn columnaUsuarios;
    }
}