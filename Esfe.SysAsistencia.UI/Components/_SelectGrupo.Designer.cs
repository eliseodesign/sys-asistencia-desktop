namespace Esfe.SysAsistencia.UI.Components
{
    partial class _SelectGrupo
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
            clbGruposCarrera = new CheckedListBox();
            label1 = new Label();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // clbGruposCarrera
            // 
            clbGruposCarrera.CheckOnClick = true;
            clbGruposCarrera.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            clbGruposCarrera.FormattingEnabled = true;
            clbGruposCarrera.Location = new Point(12, 101);
            clbGruposCarrera.Name = "clbGruposCarrera";
            clbGruposCarrera.Size = new Size(428, 193);
            clbGruposCarrera.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(50, 26);
            label1.Name = "label1";
            label1.Size = new Size(363, 30);
            label1.TabIndex = 22;
            label1.Text = "Seleccione el grupo para el Docente";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(292, 318);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(148, 38);
            btnAceptar.TabIndex = 23;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // _SelectGrupo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 368);
            Controls.Add(btnAceptar);
            Controls.Add(label1);
            Controls.Add(clbGruposCarrera);
            Name = "_SelectGrupo";
            Text = "_SelectGrupo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox clbGruposCarrera;
        private Label label1;
        private Button btnAceptar;
    }
}