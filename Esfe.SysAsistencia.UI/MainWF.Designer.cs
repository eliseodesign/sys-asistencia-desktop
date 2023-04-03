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
            panelGeneral = new Panel();
            SuspendLayout();
            // 
            // panelGeneral
            // 
            panelGeneral.Dock = DockStyle.Fill;
            panelGeneral.Location = new Point(0, 0);
            panelGeneral.Margin = new Padding(0);
            panelGeneral.Name = "panelGeneral";
            panelGeneral.Size = new Size(934, 561);
            panelGeneral.TabIndex = 1;
            // 
            // MainWF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(934, 561);
            Controls.Add(panelGeneral);
            ForeColor = Color.White;
            Name = "MainWF";
            Opacity = 0.97D;
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "2";
            Text = "Sistema de Asistencia";
            ResumeLayout(false);
        }

        #endregion
        public Panel panelGeneral;
    }
}