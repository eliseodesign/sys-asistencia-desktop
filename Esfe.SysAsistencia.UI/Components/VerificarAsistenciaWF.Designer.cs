namespace Esfe.SysAsistencia.UI.Components
{
    partial class VerificarAsistenciaWF
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
        public void InitializeComponent()
        {
            panelThis = new Panel();
            panel1 = new Panel();
            btnEnableAsis = new Button();
            lblName = new Label();
            lblHuella = new Label();
            lblStatus = new Label();
            panelThis.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // CloseButton
            // 
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.Location = new Point(621, 464);
            // 
            // panelThis
            // 
            panelThis.Controls.Add(panel1);
            panelThis.Dock = DockStyle.Fill;
            panelThis.Location = new Point(0, 0);
            panelThis.Name = "panelThis";
            panelThis.Size = new Size(811, 507);
            panelThis.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnEnableAsis);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(lblHuella);
            panel1.Controls.Add(lblStatus);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 430);
            panel1.TabIndex = 8;
            // 
            // btnEnableAsis
            // 
            btnEnableAsis.BackColor = Color.FromArgb(90, 200, 90);
            btnEnableAsis.FlatStyle = FlatStyle.Flat;
            btnEnableAsis.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnEnableAsis.ForeColor = Color.White;
            btnEnableAsis.Location = new Point(12, 375);
            btnEnableAsis.Name = "btnEnableAsis";
            btnEnableAsis.Size = new Size(219, 40);
            btnEnableAsis.TabIndex = 9;
            btnEnableAsis.Text = "Comenzar Asistencias";
            btnEnableAsis.UseVisualStyleBackColor = false;
            btnEnableAsis.Click += btnEnableAsis_Click;
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ImageAlign = ContentAlignment.MiddleRight;
            lblName.Location = new Point(0, 278);
            lblName.MaximumSize = new Size(248, 200);
            lblName.Name = "lblName";
            lblName.Size = new Size(245, 94);
            lblName.TabIndex = 10;
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHuella
            // 
            lblHuella.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblHuella.Image = Properties.Resources.huella_dactilar_;
            lblHuella.ImageAlign = ContentAlignment.TopCenter;
            lblHuella.Location = new Point(0, 149);
            lblHuella.MaximumSize = new Size(900, 900);
            lblHuella.MinimumSize = new Size(160, 100);
            lblHuella.Name = "lblHuella";
            lblHuella.Size = new Size(248, 118);
            lblHuella.TabIndex = 9;
            lblHuella.Text = "Esperando...";
            lblHuella.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.ImageAlign = ContentAlignment.MiddleRight;
            lblStatus.Location = new Point(4, 22);
            lblStatus.MaximumSize = new Size(300, 100);
            lblStatus.MinimumSize = new Size(240, 56);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(241, 85);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Esperando la Huella del Alumno";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // VerificarAsistenciaWF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 507);
            Controls.Add(panelThis);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VerificarAsistenciaWF";
            Text = "VerificarAsistenciaWF";
            Controls.SetChildIndex(CloseButton, 0);
            Controls.SetChildIndex(cbxPersons, 0);
            Controls.SetChildIndex(panelThis, 0);
            panelThis.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelThis;
        private Panel panel1;
        private Label lblName;
        private Label lblHuella;
        private Label lblStatus;
        private Button button2;
        private Button btnEnableAsis;
    }
}