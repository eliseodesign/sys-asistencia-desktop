namespace Esfe.SysAsistencia.UI
{
    partial class CaptureForm
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
        public virtual void InitializeComponent()
        {
            StatusLabel = new Label();
            Picture = new PictureBox();
            StatusText = new TextBox();
            StatusLine = new Label();
            CloseButton = new Button();
            lblDescription = new Label();
            lblTitle = new Label();
            groupBox1 = new GroupBox();
            lblMuestra4 = new Label();
            lblMuestra3 = new Label();
            lblMuestra2 = new Label();
            lblMuestra1 = new Label();
            cbxPersons = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)Picture).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(14, 284);
            StatusLabel.Margin = new Padding(4, 0, 4, 0);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(129, 15);
            StatusLabel.TabIndex = 3;
            StatusLabel.Text = "Información de Estado:";
            // 
            // Picture
            // 
            Picture.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Picture.BackColor = SystemColors.Window;
            Picture.BorderStyle = BorderStyle.Fixed3D;
            Picture.Location = new Point(14, 14);
            Picture.Margin = new Padding(4);
            Picture.Name = "Picture";
            Picture.Size = new Size(257, 256);
            Picture.TabIndex = 0;
            Picture.TabStop = false;
            // 
            // StatusText
            // 
            StatusText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StatusText.BackColor = SystemColors.Window;
            StatusText.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            StatusText.Location = new Point(14, 303);
            StatusText.Margin = new Padding(4);
            StatusText.MaximumSize = new Size(769, 105);
            StatusText.MinimumSize = new Size(769, 105);
            StatusText.Multiline = true;
            StatusText.Name = "StatusText";
            StatusText.ReadOnly = true;
            StatusText.ScrollBars = ScrollBars.Both;
            StatusText.Size = new Size(769, 105);
            StatusText.TabIndex = 4;
            // 
            // StatusLine
            // 
            StatusLine.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StatusLine.Location = new Point(13, 414);
            StatusLine.Margin = new Padding(4, 0, 4, 0);
            StatusLine.Name = "StatusLine";
            StatusLine.Size = new Size(468, 45);
            StatusLine.TabIndex = 5;
            StatusLine.Text = "[Status line]";
            // 
            // CloseButton
            // 
            CloseButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CloseButton.BackColor = Color.FromArgb(58, 163, 217);
            CloseButton.DialogResult = DialogResult.Cancel;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.ForeColor = Color.White;
            CloseButton.Location = new Point(605, 425);
            CloseButton.Margin = new Padding(4);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(178, 35);
            CloseButton.TabIndex = 6;
            CloseButton.Text = "Cerrar";
            CloseButton.UseVisualStyleBackColor = false;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescription.Location = new Point(327, 58);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(415, 20);
            lblDescription.TabIndex = 8;
            lblDescription.Text = "Por favor, complete las cuatro muestras de huellas necesarias.";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(393, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(287, 37);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "Registrar Nueva Huella";
            // 
            // groupBox1
            // 
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.Controls.Add(lblMuestra4);
            groupBox1.Controls.Add(lblMuestra3);
            groupBox1.Controls.Add(lblMuestra2);
            groupBox1.Controls.Add(lblMuestra1);
            groupBox1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(277, 92);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.MaximumSize = new Size(488, 175);
            groupBox1.MinimumSize = new Size(488, 175);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(488, 175);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Muestras";
            // 
            // lblMuestra4
            // 
            lblMuestra4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblMuestra4.AutoSize = true;
            lblMuestra4.FlatStyle = FlatStyle.Flat;
            lblMuestra4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMuestra4.Image = Properties.Resources.huella_dactilar_;
            lblMuestra4.Location = new Point(345, 28);
            lblMuestra4.MaximumSize = new Size(105, 120);
            lblMuestra4.MinimumSize = new Size(105, 120);
            lblMuestra4.Name = "lblMuestra4";
            lblMuestra4.Size = new Size(105, 120);
            lblMuestra4.TabIndex = 10;
            lblMuestra4.Text = "Incompleta";
            lblMuestra4.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblMuestra3
            // 
            lblMuestra3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblMuestra3.AutoSize = true;
            lblMuestra3.FlatStyle = FlatStyle.Flat;
            lblMuestra3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMuestra3.Image = Properties.Resources.huella_dactilar_;
            lblMuestra3.Location = new Point(246, 28);
            lblMuestra3.MaximumSize = new Size(105, 120);
            lblMuestra3.MinimumSize = new Size(105, 120);
            lblMuestra3.Name = "lblMuestra3";
            lblMuestra3.Size = new Size(105, 120);
            lblMuestra3.TabIndex = 9;
            lblMuestra3.Text = "Incompleta";
            lblMuestra3.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblMuestra2
            // 
            lblMuestra2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblMuestra2.AutoSize = true;
            lblMuestra2.FlatStyle = FlatStyle.Flat;
            lblMuestra2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMuestra2.Image = Properties.Resources.huella_dactilar_;
            lblMuestra2.Location = new Point(146, 28);
            lblMuestra2.MaximumSize = new Size(105, 120);
            lblMuestra2.MinimumSize = new Size(105, 120);
            lblMuestra2.Name = "lblMuestra2";
            lblMuestra2.Size = new Size(105, 120);
            lblMuestra2.TabIndex = 8;
            lblMuestra2.Text = "Innecesaria";
            lblMuestra2.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblMuestra1
            // 
            lblMuestra1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblMuestra1.AutoSize = true;
            lblMuestra1.FlatStyle = FlatStyle.Flat;
            lblMuestra1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMuestra1.Image = Properties.Resources.huella_dactilar_;
            lblMuestra1.Location = new Point(46, 28);
            lblMuestra1.MaximumSize = new Size(105, 120);
            lblMuestra1.MinimumSize = new Size(105, 120);
            lblMuestra1.Name = "lblMuestra1";
            lblMuestra1.Size = new Size(105, 120);
            lblMuestra1.TabIndex = 7;
            lblMuestra1.Text = "Incompleta";
            lblMuestra1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // cbxPersons
            // 
            cbxPersons.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbxPersons.FormattingEnabled = true;
            cbxPersons.Location = new Point(423, 424);
            cbxPersons.Name = "cbxPersons";
            cbxPersons.Size = new Size(166, 29);
            cbxPersons.TabIndex = 10;
            cbxPersons.SelectedIndexChanged += cbxPersons_SelectedIndexChanged;
            // 
            // CaptureForm
            // 
            AcceptButton = CloseButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = CloseButton;
            ClientSize = new Size(795, 468);
            Controls.Add(cbxPersons);
            Controls.Add(groupBox1);
            Controls.Add(lblDescription);
            Controls.Add(lblTitle);
            Controls.Add(CloseButton);
            Controls.Add(StatusLine);
            Controls.Add(StatusText);
            Controls.Add(StatusLabel);
            Controls.Add(Picture);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MaximumSize = new Size(811, 507);
            MinimizeBox = false;
            MinimumSize = new Size(811, 507);
            Name = "CaptureForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Capture Enrollment";
            FormClosed += CaptureForm_FormClosed;
            Load += CaptureForm_Load;
            ((System.ComponentModel.ISupportInitialize)Picture).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.TextBox StatusText;
        private System.Windows.Forms.Label StatusLine;
        private System.Windows.Forms.Label StatusLabel;
        private Label lblDescription;
        private Label lblTitle;
        private GroupBox groupBox1;
        private Label lblMuestra4;
        private Label lblMuestra3;
        private Label lblMuestra2;
        private Label lblMuestra1;
        public ComboBox cbxPersons;
        public Button CloseButton;
    }
}