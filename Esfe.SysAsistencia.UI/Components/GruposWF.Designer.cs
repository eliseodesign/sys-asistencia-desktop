namespace Esfe.SysAsistencia.UI.Components
{
    partial class GruposWF
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
            label1 = new Label();
            PanelGrupos = new Panel();
            PanelGrupos.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(357, 46);
            label1.TabIndex = 0;
            label1.Text = "Formulario de Grupos";
            // 
            // PanelGrupos
            // 
            PanelGrupos.Controls.Add(label1);
            PanelGrupos.Dock = DockStyle.Fill;
            PanelGrupos.Location = new Point(0, 0);
            PanelGrupos.Name = "PanelGrupos";
            PanelGrupos.Size = new Size(587, 505);
            PanelGrupos.TabIndex = 2;
            // 
            // GruposWF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 505);
            Controls.Add(PanelGrupos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GruposWF";
            Text = "GruposWF";
            PanelGrupos.ResumeLayout(false);
            PanelGrupos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel PanelGrupos;
    }
}