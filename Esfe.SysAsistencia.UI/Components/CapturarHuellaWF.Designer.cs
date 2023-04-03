namespace Esfe.SysAsistencia.UI.Components
{
    partial class CapturarHuellaWF
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
            pbHuellaImage = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pbHuellaImage).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pbHuellaImage
            // 
            pbHuellaImage.Location = new Point(12, 119);
            pbHuellaImage.Name = "pbHuellaImage";
            pbHuellaImage.Size = new Size(233, 322);
            pbHuellaImage.TabIndex = 0;
            pbHuellaImage.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(227, 13);
            label1.Name = "label1";
            label1.Size = new Size(359, 46);
            label1.TabIndex = 1;
            label1.Text = "Registrar Nueva Huella";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(151, 72);
            label2.Name = "label2";
            label2.Size = new Size(531, 25);
            label2.TabIndex = 2;
            label2.Text = "Por favor, complete las cuatro muestras de huellas necesarias.";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(268, 119);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(505, 322);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Muestras";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Image = Properties.Resources.huella_dactilar_;
            label5.Location = new Point(371, 101);
            label5.MinimumSize = new Size(64, 120);
            label5.Name = "label5";
            label5.Size = new Size(110, 120);
            label5.TabIndex = 10;
            label5.Text = "Incompleta";
            label5.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Image = Properties.Resources.huella_dactilar_;
            label6.Location = new Point(255, 101);
            label6.MinimumSize = new Size(64, 120);
            label6.Name = "label6";
            label6.Size = new Size(110, 120);
            label6.TabIndex = 9;
            label6.Text = "Incompleta";
            label6.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Image = Properties.Resources.huella_dactilar_;
            label4.Location = new Point(141, 101);
            label4.MinimumSize = new Size(64, 120);
            label4.Name = "label4";
            label4.Size = new Size(110, 120);
            label4.TabIndex = 8;
            label4.Text = "Incompleta";
            label4.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Image = Properties.Resources.huella_dactilar_;
            label3.Location = new Point(25, 101);
            label3.MinimumSize = new Size(64, 120);
            label3.Name = "label3";
            label3.Size = new Size(110, 120);
            label3.TabIndex = 7;
            label3.Text = "Incompleta";
            label3.TextAlign = ContentAlignment.BottomCenter;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(58, 163, 217);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(604, 466);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(169, 46);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // CapturarHuellaWF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 524);
            Controls.Add(btnCancel);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbHuellaImage);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CapturarHuellaWF";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CapturarHuellaWF";
            ((System.ComponentModel.ISupportInitialize)pbHuellaImage).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbHuellaImage;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label3;
        private Button btnCancel;
    }
}