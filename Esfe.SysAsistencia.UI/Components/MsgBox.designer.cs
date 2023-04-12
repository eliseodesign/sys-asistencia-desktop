namespace DataEdit
{
    partial class MsgBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsgBox));
            pL1 = new Panel();
            pL2 = new Panel();
            lblTitulo = new Label();
            lblMsg = new Label();
            pbError = new PictureBox();
            pbWar = new PictureBox();
            pbQue = new PictureBox();
            btnOk = new Button();
            btnCancel = new Button();
            pbfilled = new PictureBox();
            pbInformation = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbWar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbQue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbfilled).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbInformation).BeginInit();
            SuspendLayout();
            // 
            // pL1
            // 
            pL1.BackColor = SystemColors.ActiveCaptionText;
            pL1.Location = new Point(-1, 74);
            pL1.Margin = new Padding(4, 3, 4, 3);
            pL1.Name = "pL1";
            pL1.Size = new Size(492, 5);
            pL1.TabIndex = 0;
            // 
            // pL2
            // 
            pL2.BackColor = Color.Gray;
            pL2.Location = new Point(-1, 179);
            pL2.Margin = new Padding(4, 3, 4, 3);
            pL2.Name = "pL2";
            pL2.Size = new Size(492, 5);
            pL2.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(79, 29);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(66, 24);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "label1";
            // 
            // lblMsg
            // 
            lblMsg.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMsg.ForeColor = Color.White;
            lblMsg.Location = new Point(14, 92);
            lblMsg.Margin = new Padding(4, 0, 4, 0);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(462, 74);
            lblMsg.TabIndex = 3;
            lblMsg.Text = "label1";
            // 
            // pbError
            // 
            pbError.Image = Esfe.SysAsistencia.UI.Properties.Resources.error1;
            pbError.Location = new Point(14, 14);
            pbError.Margin = new Padding(4, 3, 4, 3);
            pbError.Name = "pbError";
            pbError.Size = new Size(58, 58);
            pbError.SizeMode = PictureBoxSizeMode.Zoom;
            pbError.TabIndex = 6;
            pbError.TabStop = false;
            pbError.Visible = false;
            // 
            // pbWar
            // 
            pbWar.Image = Esfe.SysAsistencia.UI.Properties.Resources.warning1;
            pbWar.Location = new Point(14, 14);
            pbWar.Margin = new Padding(4, 3, 4, 3);
            pbWar.Name = "pbWar";
            pbWar.Size = new Size(58, 58);
            pbWar.SizeMode = PictureBoxSizeMode.Zoom;
            pbWar.TabIndex = 5;
            pbWar.TabStop = false;
            pbWar.Visible = false;
            // 
            // pbQue
            // 
            pbQue.Image = Esfe.SysAsistencia.UI.Properties.Resources.question;
            pbQue.Location = new Point(14, 14);
            pbQue.Margin = new Padding(4, 3, 4, 3);
            pbQue.Name = "pbQue";
            pbQue.Size = new Size(58, 58);
            pbQue.SizeMode = PictureBoxSizeMode.Zoom;
            pbQue.TabIndex = 4;
            pbQue.TabStop = false;
            pbQue.Visible = false;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.FromArgb(0, 111, 230);
            btnOk.FlatAppearance.BorderColor = Color.FromArgb(0, 111, 230);
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnOk.ForeColor = Color.White;
            btnOk.Location = new Point(269, 190);
            btnOk.Margin = new Padding(4, 3, 4, 3);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(99, 35);
            btnOk.TabIndex = 7;
            btnOk.Text = "Aceptar";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            btnOk.MouseEnter += btn_MouseEnter;
            btnOk.MouseLeave += btn_MouseLeave;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(0, 111, 230);
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(0, 111, 230);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(383, 190);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(99, 35);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            btnCancel.MouseEnter += btn_MouseEnter;
            btnCancel.MouseLeave += btn_MouseLeave;
            // 
            // pbfilled
            // 
            pbfilled.Image = (Image)resources.GetObject("pbfilled.Image");
            pbfilled.Location = new Point(14, 14);
            pbfilled.Margin = new Padding(4, 3, 4, 3);
            pbfilled.Name = "pbfilled";
            pbfilled.Size = new Size(58, 58);
            pbfilled.SizeMode = PictureBoxSizeMode.Zoom;
            pbfilled.TabIndex = 9;
            pbfilled.TabStop = false;
            pbfilled.Visible = false;
            // 
            // pbInformation
            // 
            pbInformation.Image = (Image)resources.GetObject("pbInformation.Image");
            pbInformation.Location = new Point(14, 14);
            pbInformation.Margin = new Padding(4, 3, 4, 3);
            pbInformation.Name = "pbInformation";
            pbInformation.Size = new Size(58, 58);
            pbInformation.SizeMode = PictureBoxSizeMode.Zoom;
            pbInformation.TabIndex = 10;
            pbInformation.TabStop = false;
            pbInformation.Visible = false;
            // 
            // MsgBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(490, 231);
            Controls.Add(pbInformation);
            Controls.Add(pbfilled);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(pbError);
            Controls.Add(pbWar);
            Controls.Add(pbQue);
            Controls.Add(lblMsg);
            Controls.Add(lblTitulo);
            Controls.Add(pL2);
            Controls.Add(pL1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MsgBox";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MsgBox";
            ((System.ComponentModel.ISupportInitialize)pbError).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbWar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbQue).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbfilled).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbInformation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pL1;
        private System.Windows.Forms.Panel pL2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.PictureBox pbQue;
        private System.Windows.Forms.PictureBox pbWar;
        private System.Windows.Forms.PictureBox pbError;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private PictureBox pbfilled;
        private PictureBox pbInformation;
    }
}