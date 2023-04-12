namespace Esfe.SysAsistencia.UI
{
    partial class VerificarWF
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
            SuspendLayout();
            // 
            // CloseButton
            // 
            CloseButton.FlatAppearance.BorderSize = 0;
            // 
            // VerificarWF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            ClientSize = new Size(1035, 817);
            Margin = new Padding(6, 7, 6, 7);
            MaximumSize = new Size(1053, 864);
            MinimumSize = new Size(1053, 864);
            Name = "VerificarWF";
            Text = "Verificar Huella";
            FormClosing += VerificarWF_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}