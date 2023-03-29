namespace Esfe.SysAsistencia.UI.Components
{
    partial class BarWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarWF));
            GuardarDatos = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)GuardarDatos).BeginInit();
            SuspendLayout();
            // 
            // GuardarDatos
            // 
            GuardarDatos.Image = (Image)resources.GetObject("GuardarDatos.Image");
            GuardarDatos.Location = new Point(2, 0);
            GuardarDatos.Name = "GuardarDatos";
            GuardarDatos.Padding = new Padding(8, 8, 0, 0);
            GuardarDatos.Size = new Size(38, 42);
            GuardarDatos.TabIndex = 0;
            GuardarDatos.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(584, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 21);
            label1.TabIndex = 1;
            // 
            // Bar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(2, 24, 58);
            ClientSize = new Size(800, 38);
            Controls.Add(label1);
            Controls.Add(GuardarDatos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Bar";
            Text = "Bar";
            ((System.ComponentModel.ISupportInitialize)GuardarDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox GuardarDatos;
        private Label label1;
    }
}