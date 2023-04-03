namespace Esfe.SysAsistencia.UI
{
    partial class LoginWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginWF));
            panelLateral = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panelFooter = new Panel();
            label4 = new Label();
            btnIniciarSesion = new Button();
            txtUseKey = new TextBox();
            txtUserName = new TextBox();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            lblLoginDocente = new Label();
            pictureBox4 = new PictureBox();
            panelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panelLateral
            // 
            panelLateral.BackColor = Color.FromArgb(0, 40, 100);
            panelLateral.Controls.Add(label3);
            panelLateral.Controls.Add(label2);
            panelLateral.Controls.Add(label1);
            panelLateral.Controls.Add(pictureBox1);
            panelLateral.Dock = DockStyle.Left;
            panelLateral.Location = new Point(0, 0);
            panelLateral.Name = "panelLateral";
            panelLateral.Size = new Size(250, 375);
            panelLateral.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(44, 264);
            label3.Name = "label3";
            label3.Size = new Size(156, 18);
            label3.TabIndex = 3;
            label3.Text = "asistencia de la ESFE";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(30, 246);
            label2.Name = "label2";
            label2.Size = new Size(190, 18);
            label2.TabIndex = 2;
            label2.Text = "Bienvenido al sistema de";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(536, 313);
            label1.Name = "label1";
            label1.Size = new Size(195, 18);
            label1.TabIndex = 1;
            label1.Text = "Bienvenido al sistema de ";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(50, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.White;
            panelFooter.Controls.Add(label4);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(250, 340);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(534, 35);
            panelFooter.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(6, 10);
            label4.Name = "label4";
            label4.Size = new Size(396, 16);
            label4.TabIndex = 4;
            label4.Text = "Eliseo Arévalo, Daniel Rodrigez, Amilcar Rodrigez  -  TIDS 1año 03";
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Anchor = AnchorStyles.None;
            btnIniciarSesion.BackColor = Color.FromArgb(58, 163, 217);
            btnIniciarSesion.Cursor = Cursors.Hand;
            btnIniciarSesion.FlatStyle = FlatStyle.Flat;
            btnIniciarSesion.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnIniciarSesion.ForeColor = SystemColors.ButtonFace;
            btnIniciarSesion.Location = new Point(101, 146);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(231, 37);
            btnIniciarSesion.TabIndex = 28;
            btnIniciarSesion.Text = "Iniciar Sesión";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // txtUseKey
            // 
            txtUseKey.Anchor = AnchorStyles.None;
            txtUseKey.BackColor = SystemColors.Control;
            txtUseKey.BorderStyle = BorderStyle.None;
            txtUseKey.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUseKey.Location = new Point(78, 101);
            txtUseKey.Margin = new Padding(10, 3, 3, 3);
            txtUseKey.Name = "txtUseKey";
            txtUseKey.PasswordChar = '●';
            txtUseKey.PlaceholderText = "Ingrese su contraseña";
            txtUseKey.Size = new Size(318, 24);
            txtUseKey.TabIndex = 27;
            // 
            // txtUserName
            // 
            txtUserName.Anchor = AnchorStyles.None;
            txtUserName.BackColor = SystemColors.Control;
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(78, 51);
            txtUserName.Margin = new Padding(10, 3, 3, 3);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "Ingrese su usuario";
            txtUserName.Size = new Size(318, 24);
            txtUserName.TabIndex = 26;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(29, -265);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 25;
            pictureBox3.TabStop = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(71, 112);
            label6.Name = "label6";
            label6.Size = new Size(325, 21);
            label6.TabIndex = 30;
            label6.Text = "_____________________________________________";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(33, 51);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(71, 62);
            label5.Name = "label5";
            label5.Size = new Size(325, 21);
            label5.TabIndex = 29;
            label5.Text = "_____________________________________________";
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = SystemColors.ControlDarkDark;
            panel1.Location = new Point(250, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(534, 340);
            panel1.TabIndex = 31;
            panel1.Paint += panel1_Paint;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(lblLoginDocente);
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(btnIniciarSesion);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(txtUseKey);
            groupBox1.Controls.Add(txtUserName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.ForeColor = SystemColors.AppWorkspace;
            groupBox1.Location = new Point(58, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(423, 280);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sesión";
            // 
            // lblLoginDocente
            // 
            lblLoginDocente.Anchor = AnchorStyles.None;
            lblLoginDocente.AutoSize = true;
            lblLoginDocente.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoginDocente.ForeColor = Color.FromArgb(58, 163, 217);
            lblLoginDocente.Location = new Point(135, 227);
            lblLoginDocente.Name = "lblLoginDocente";
            lblLoginDocente.Size = new Size(138, 19);
            lblLoginDocente.TabIndex = 32;
            lblLoginDocente.Text = "Iniciar como Docente";
            lblLoginDocente.Click += lblLoginDocente_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.None;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(33, 101);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 31;
            pictureBox4.TabStop = false;
            // 
            // LoginWF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 375);
            Controls.Add(panel1);
            Controls.Add(panelFooter);
            Controls.Add(panelLateral);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginWF";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginWF";
            panelLateral.ResumeLayout(false);
            panelLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLateral;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panelFooter;
        private Label label4;
        private Button btnIniciarSesion;
        private TextBox txtUseKey;
        private TextBox txtUserName;
        private PictureBox pictureBox3;
        private Label label6;
        private PictureBox pictureBox2;
        private Label label5;
        private Panel panel1;
        private GroupBox groupBox1;
        private PictureBox pictureBox4;
        private Label lblLoginDocente;
    }
}