namespace Esfe.SysAsistencia.UI.Components
{
    partial class AsistenciaWF
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
            PanelAsistencia = new Panel();
            label1 = new Label();
            PanelAsistencia.SuspendLayout();
            SuspendLayout();
            // 
            // PanelAsistencia
            // 
            PanelAsistencia.Controls.Add(label1);
            PanelAsistencia.Dock = DockStyle.Fill;
            PanelAsistencia.Location = new Point(0, 0);
            PanelAsistencia.Name = "PanelAsistencia";
            PanelAsistencia.Size = new Size(605, 552);
            PanelAsistencia.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(400, 46);
            label1.TabIndex = 0;
            label1.Text = "Formulario de Asistencia";
            // 
            // AsistenciaWF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 552);
            Controls.Add(PanelAsistencia);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AsistenciaWF";
            Text = "AsistenciaWF";
            PanelAsistencia.ResumeLayout(false);
            PanelAsistencia.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelAsistencia;
        private Label label1;
    }
}