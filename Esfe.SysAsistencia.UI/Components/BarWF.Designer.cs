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
            txtLoginNombre = new Label();
            ((System.ComponentModel.ISupportInitialize)GuardarDatos).BeginInit();
            SuspendLayout();
            // 
            // GuardarDatos
            // 
            GuardarDatos.Cursor = Cursors.Hand;
            GuardarDatos.Image = (Image)resources.GetObject("GuardarDatos.Image");
            GuardarDatos.Location = new Point(2, 0);
            GuardarDatos.Name = "GuardarDatos";
            GuardarDatos.Padding = new Padding(8, 8, 0, 0);
            GuardarDatos.Size = new Size(38, 42);
            GuardarDatos.TabIndex = 0;
            GuardarDatos.TabStop = false;
            GuardarDatos.Click += GuardarDatos_Click;
            // 
            // txtLoginNombre
            // 
            txtLoginNombre.Anchor = AnchorStyles.Top;
            txtLoginNombre.AutoSize = true;
            txtLoginNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLoginNombre.ForeColor = SystemColors.ButtonFace;
            txtLoginNombre.Location = new Point(686, 8);
            txtLoginNombre.Name = "txtLoginNombre";
            txtLoginNombre.Size = new Size(42, 21);
            txtLoginNombre.TabIndex = 1;
            txtLoginNombre.Text = "User";
            // 
            // BarWF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(2, 24, 58);
            ClientSize = new Size(800, 38);
            Controls.Add(txtLoginNombre);
            Controls.Add(GuardarDatos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BarWF";
            Text = "Bar";
            ((System.ComponentModel.ISupportInitialize)GuardarDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox GuardarDatos;
        private Label txtLoginNombre;
    }
}