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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarWF));
            GuardarDatos = new PictureBox();
            txtLoginNombre = new Label();
            lblHour = new Label();
            timeHour = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)GuardarDatos).BeginInit();
            SuspendLayout();
            // 
            // GuardarDatos
            // 
            GuardarDatos.Cursor = Cursors.Hand;
            GuardarDatos.Image = (Image)resources.GetObject("GuardarDatos.Image");
            GuardarDatos.Location = new Point(2, 0);
            GuardarDatos.Margin = new Padding(3, 4, 3, 4);
            GuardarDatos.Name = "GuardarDatos";
            GuardarDatos.Padding = new Padding(9, 11, 0, 0);
            GuardarDatos.Size = new Size(43, 56);
            GuardarDatos.TabIndex = 0;
            GuardarDatos.TabStop = false;
            GuardarDatos.Click += GuardarDatos_Click;
            // 
            // txtLoginNombre
            // 
            txtLoginNombre.BackColor = Color.Transparent;
            txtLoginNombre.Dock = DockStyle.Right;
            txtLoginNombre.FlatStyle = FlatStyle.Flat;
            txtLoginNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLoginNombre.ForeColor = SystemColors.ButtonFace;
            txtLoginNombre.Location = new Point(755, 0);
            txtLoginNombre.Name = "txtLoginNombre";
            txtLoginNombre.Size = new Size(159, 51);
            txtLoginNombre.TabIndex = 1;
            txtLoginNombre.Text = "User    ";
            txtLoginNombre.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblHour
            // 
            lblHour.BackColor = Color.Transparent;
            lblHour.Dock = DockStyle.Fill;
            lblHour.FlatStyle = FlatStyle.Flat;
            lblHour.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblHour.ForeColor = SystemColors.ButtonFace;
            lblHour.Location = new Point(0, 0);
            lblHour.Name = "lblHour";
            lblHour.Size = new Size(914, 51);
            lblHour.TabIndex = 2;
            lblHour.Text = "12:23";
            lblHour.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timeHour
            // 
            timeHour.Enabled = true;
            timeHour.Interval = 1000;
            timeHour.Tick += timeHour_Tick;
            // 
            // BarWF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(2, 24, 58);
            ClientSize = new Size(914, 51);
            Controls.Add(GuardarDatos);
            Controls.Add(txtLoginNombre);
            Controls.Add(lblHour);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "BarWF";
            Text = "Bar";
            ((System.ComponentModel.ISupportInitialize)GuardarDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox GuardarDatos;
        private Label txtLoginNombre;
        private Label lblHour;
        private System.Windows.Forms.Timer timeHour;
    }
}