namespace Esfe.SysAsistencia.UI
{
    partial class EstudianteWF
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
            txtUserName = new TextBox();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.BackColor = SystemColors.Control;
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(28, 12);
            txtUserName.Margin = new Padding(10, 3, 3, 3);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "Ingrese su usuario";
            txtUserName.Size = new Size(337, 24);
            txtUserName.TabIndex = 6;
            // 
            // EstudianteWF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtUserName);
            Name = "EstudianteWF";
            Text = "EstudianteWF";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
    }
}