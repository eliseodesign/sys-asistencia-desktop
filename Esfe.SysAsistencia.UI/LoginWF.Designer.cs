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
            panel1 = new Panel();
            CloseWindow = new PictureBox();
            panelGeneral = new Panel();
            btnIniciarSesion = new Button();
            panelFooter = new Panel();
            label4 = new Label();
            txtUseKey = new TextBox();
            panelLateral = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtUserName = new TextBox();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CloseWindow).BeginInit();
            panelGeneral.SuspendLayout();
            panelFooter.SuspendLayout();
            panelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 46, 46);
            panel1.Controls.Add(CloseWindow);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.WindowFrame;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 32);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // CloseWindow
            // 
            CloseWindow.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CloseWindow.BackColor = Color.FromArgb(214, 15, 15);
            CloseWindow.Cursor = Cursors.Hand;
            CloseWindow.Image = (Image)resources.GetObject("CloseWindow.Image");
            CloseWindow.Location = new Point(768, 0);
            CloseWindow.Name = "CloseWindow";
            CloseWindow.Padding = new Padding(4, 4, 0, 0);
            CloseWindow.Size = new Size(32, 32);
            CloseWindow.TabIndex = 1;
            CloseWindow.TabStop = false;
            CloseWindow.Click += CloseWindow_Click;
            // 
            // panelGeneral
            // 
            panelGeneral.Controls.Add(btnIniciarSesion);
            panelGeneral.Controls.Add(panelFooter);
            panelGeneral.Controls.Add(txtUseKey);
            panelGeneral.Controls.Add(panelLateral);
            panelGeneral.Controls.Add(txtUserName);
            panelGeneral.Controls.Add(pictureBox3);
            panelGeneral.Controls.Add(label6);
            panelGeneral.Controls.Add(pictureBox2);
            panelGeneral.Controls.Add(label5);
            panelGeneral.Dock = DockStyle.Fill;
            panelGeneral.Location = new Point(0, 32);
            panelGeneral.Name = "panelGeneral";
            panelGeneral.Size = new Size(800, 418);
            panelGeneral.TabIndex = 1;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.FromArgb(58, 163, 217);
            btnIniciarSesion.Cursor = Cursors.Hand;
            btnIniciarSesion.FlatStyle = FlatStyle.Flat;
            btnIniciarSesion.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnIniciarSesion.Location = new Point(437, 230);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(183, 37);
            btnIniciarSesion.TabIndex = 21;
            btnIniciarSesion.Text = "Iniciar Sesión";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.White;
            panelFooter.Controls.Add(label4);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(250, 383);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(550, 35);
            panelFooter.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans Unicode", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(6, 8);
            label4.Name = "label4";
            label4.Size = new Size(396, 16);
            label4.TabIndex = 4;
            label4.Text = "Eliseo Arévalo, Daniel Rodrigez, Amilcar Rodrigez  -  TIDS 1año 03";
            // 
            // txtUseKey
            // 
            txtUseKey.BackColor = SystemColors.Control;
            txtUseKey.BorderStyle = BorderStyle.None;
            txtUseKey.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUseKey.Location = new Point(374, 176);
            txtUseKey.Margin = new Padding(10, 3, 3, 3);
            txtUseKey.Name = "txtUseKey";
            txtUseKey.PasswordChar = '*';
            txtUseKey.PlaceholderText = "Ingrese su contraseña";
            txtUseKey.Size = new Size(337, 24);
            txtUseKey.TabIndex = 20;
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
            panelLateral.Size = new Size(250, 418);
            panelLateral.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(44, 264);
            label3.Name = "label3";
            label3.Size = new Size(156, 18);
            label3.TabIndex = 3;
            label3.Text = "asistencia de la ESFE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
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
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(50, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = SystemColors.Control;
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(374, 126);
            txtUserName.Margin = new Padding(10, 3, 3, 3);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "Ingrese su usuario";
            txtUserName.Size = new Size(337, 24);
            txtUserName.TabIndex = 19;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(329, 176);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(367, 187);
            label6.Name = "label6";
            label6.Size = new Size(325, 21);
            label6.TabIndex = 23;
            label6.Text = "_____________________________________________";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(329, 126);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(367, 137);
            label5.Name = "label5";
            label5.Size = new Size(325, 21);
            label5.TabIndex = 22;
            label5.Text = "_____________________________________________";
            // 
            // LoginWF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(panelGeneral);
            Controls.Add(panel1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginWF";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log In";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CloseWindow).EndInit();
            panelGeneral.ResumeLayout(false);
            panelGeneral.PerformLayout();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            panelLateral.ResumeLayout(false);
            panelLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox CloseWindow;
        private Panel panelGeneral;
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
    }
}