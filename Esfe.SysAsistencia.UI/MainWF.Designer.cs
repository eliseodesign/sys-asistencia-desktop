namespace Esfe.SysAsistencia.UI
{
    partial class MainWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWF));
            panel1 = new Panel();
            CloseWindow = new PictureBox();
            panelGeneral = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CloseWindow).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 46, 46);
            panel1.Controls.Add(CloseWindow);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.WindowFrame;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 43);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // CloseWindow
            // 
            CloseWindow.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CloseWindow.BackColor = Color.FromArgb(214, 15, 15);
            CloseWindow.Cursor = Cursors.Hand;
            CloseWindow.Image = (Image)resources.GetObject("CloseWindow.Image");
            CloseWindow.Location = new Point(878, 0);
            CloseWindow.Margin = new Padding(3, 4, 3, 4);
            CloseWindow.Name = "CloseWindow";
            CloseWindow.Padding = new Padding(5, 5, 0, 0);
            CloseWindow.Size = new Size(37, 43);
            CloseWindow.TabIndex = 1;
            CloseWindow.TabStop = false;
            CloseWindow.Click += CloseWindow_Click;
            // 
            // panelGeneral
            // 
            panelGeneral.Dock = DockStyle.Fill;
            panelGeneral.Location = new Point(0, 43);
            panelGeneral.Margin = new Padding(3, 4, 3, 4);
            panelGeneral.Name = "panelGeneral";
            panelGeneral.Size = new Size(914, 557);
            panelGeneral.TabIndex = 1;
            // 
            // MainWF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(914, 600);
            Controls.Add(panelGeneral);
            Controls.Add(panel1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainWF";
            Opacity = 0.97D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log In";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CloseWindow).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox CloseWindow;
        public Panel panelGeneral;
    }
}