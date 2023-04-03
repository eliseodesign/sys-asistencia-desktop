namespace Esfe.SysAsistencia.UI
{
    partial class AplicationWF
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
            PanelAplication = new Panel();
            PanelApp = new Panel();
            mainLateral = new Panel();
            btnCerrarSesion = new Button();
            panel5 = new Panel();
            btnGrupos = new Button();
            panel4 = new Panel();
            btnDocentes = new Button();
            panel3 = new Panel();
            btnAlumnos = new Button();
            panel2 = new Panel();
            btnAsistencia = new Button();
            label3 = new Label();
            lblAsitencia = new Label();
            label2 = new Label();
            label5 = new Label();
            panelBar = new Panel();
            PanelAplication.SuspendLayout();
            mainLateral.SuspendLayout();
            SuspendLayout();
            // 
            // PanelAplication
            // 
            PanelAplication.Controls.Add(PanelApp);
            PanelAplication.Controls.Add(mainLateral);
            PanelAplication.Controls.Add(panelBar);
            PanelAplication.Dock = DockStyle.Fill;
            PanelAplication.Location = new Point(0, 0);
            PanelAplication.Name = "PanelAplication";
            PanelAplication.Size = new Size(800, 414);
            PanelAplication.TabIndex = 0;
            // 
            // PanelApp
            // 
            PanelApp.Dock = DockStyle.Fill;
            PanelApp.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PanelApp.Location = new Point(203, 38);
            PanelApp.Name = "PanelApp";
            PanelApp.Size = new Size(597, 376);
            PanelApp.TabIndex = 7;
            // 
            // mainLateral
            // 
            mainLateral.BackColor = Color.FromArgb(0, 40, 100);
            mainLateral.Controls.Add(btnCerrarSesion);
            mainLateral.Controls.Add(panel5);
            mainLateral.Controls.Add(btnGrupos);
            mainLateral.Controls.Add(panel4);
            mainLateral.Controls.Add(btnDocentes);
            mainLateral.Controls.Add(panel3);
            mainLateral.Controls.Add(btnAlumnos);
            mainLateral.Controls.Add(panel2);
            mainLateral.Controls.Add(btnAsistencia);
            mainLateral.Controls.Add(label3);
            mainLateral.Controls.Add(lblAsitencia);
            mainLateral.Controls.Add(label2);
            mainLateral.Controls.Add(label5);
            mainLateral.Dock = DockStyle.Left;
            mainLateral.Location = new Point(0, 38);
            mainLateral.Name = "mainLateral";
            mainLateral.Size = new Size(203, 376);
            mainLateral.TabIndex = 6;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Cursor = Cursors.Hand;
            btnCerrarSesion.Dock = DockStyle.Bottom;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrarSesion.ForeColor = Color.FromArgb(68, 158, 227);
            btnCerrarSesion.Image = Properties.Resources.salida;
            btnCerrarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.Location = new Point(0, 321);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(203, 55);
            btnCerrarSesion.TabIndex = 34;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleRight;
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(46, 46, 46);
            panel5.Location = new Point(0, 244);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 29);
            panel5.TabIndex = 32;
            // 
            // btnGrupos
            // 
            btnGrupos.Cursor = Cursors.Hand;
            btnGrupos.FlatAppearance.BorderSize = 0;
            btnGrupos.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 46, 46);
            btnGrupos.FlatStyle = FlatStyle.Flat;
            btnGrupos.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGrupos.ForeColor = SystemColors.ButtonFace;
            btnGrupos.Location = new Point(12, 244);
            btnGrupos.Name = "btnGrupos";
            btnGrupos.Size = new Size(191, 29);
            btnGrupos.TabIndex = 31;
            btnGrupos.Text = "Grupos";
            btnGrupos.UseVisualStyleBackColor = true;
            btnGrupos.Click += btnGrupos_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(46, 46, 46);
            panel4.Location = new Point(0, 209);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 29);
            panel4.TabIndex = 30;
            // 
            // btnDocentes
            // 
            btnDocentes.BackColor = Color.FromArgb(0, 40, 100);
            btnDocentes.Cursor = Cursors.Hand;
            btnDocentes.FlatAppearance.BorderSize = 0;
            btnDocentes.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 46, 46);
            btnDocentes.FlatStyle = FlatStyle.Flat;
            btnDocentes.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDocentes.ForeColor = SystemColors.ButtonFace;
            btnDocentes.Location = new Point(12, 209);
            btnDocentes.Name = "btnDocentes";
            btnDocentes.Size = new Size(191, 29);
            btnDocentes.TabIndex = 29;
            btnDocentes.Text = "Docentes";
            btnDocentes.UseVisualStyleBackColor = false;
            btnDocentes.Click += btnDocentes_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(46, 46, 46);
            panel3.Location = new Point(0, 174);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 29);
            panel3.TabIndex = 28;
            // 
            // btnAlumnos
            // 
            btnAlumnos.Cursor = Cursors.Hand;
            btnAlumnos.FlatAppearance.BorderSize = 0;
            btnAlumnos.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 46, 46);
            btnAlumnos.FlatStyle = FlatStyle.Flat;
            btnAlumnos.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAlumnos.ForeColor = SystemColors.ButtonFace;
            btnAlumnos.Location = new Point(12, 174);
            btnAlumnos.Name = "btnAlumnos";
            btnAlumnos.Size = new Size(191, 29);
            btnAlumnos.TabIndex = 27;
            btnAlumnos.Text = "Alumnos";
            btnAlumnos.UseVisualStyleBackColor = true;
            btnAlumnos.Click += btnAlumnos_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(46, 46, 46);
            panel2.Location = new Point(0, 139);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 29);
            panel2.TabIndex = 26;
            // 
            // btnAsistencia
            // 
            btnAsistencia.Cursor = Cursors.Hand;
            btnAsistencia.FlatAppearance.BorderSize = 0;
            btnAsistencia.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 46, 46);
            btnAsistencia.FlatStyle = FlatStyle.Flat;
            btnAsistencia.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAsistencia.ForeColor = SystemColors.ButtonFace;
            btnAsistencia.Location = new Point(12, 139);
            btnAsistencia.Name = "btnAsistencia";
            btnAsistencia.Size = new Size(191, 29);
            btnAsistencia.TabIndex = 25;
            btnAsistencia.Text = "Asistencia";
            btnAsistencia.UseVisualStyleBackColor = true;
            btnAsistencia.Click += btnAsistencia_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.AppWorkspace;
            label3.Location = new Point(26, 83);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 5;
            label3.Text = "Esfe/Agape";
            // 
            // lblAsitencia
            // 
            lblAsitencia.AutoSize = true;
            lblAsitencia.Cursor = Cursors.Hand;
            lblAsitencia.Font = new Font("Lucida Sans Unicode", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAsitencia.ForeColor = SystemColors.ButtonFace;
            lblAsitencia.Location = new Point(26, 38);
            lblAsitencia.Name = "lblAsitencia";
            lblAsitencia.Size = new Size(159, 34);
            lblAsitencia.TabIndex = 4;
            lblAsitencia.Text = "Asistencia";
            lblAsitencia.Click += lblAsitencia_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.AppWorkspace;
            label2.Location = new Point(12, 18);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 3;
            label2.Text = "Sistema De ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Yellow;
            label5.Location = new Point(26, 62);
            label5.Name = "label5";
            label5.Size = new Size(157, 21);
            label5.TabIndex = 24;
            label5.Text = "_____________________";
            // 
            // panelBar
            // 
            panelBar.BackColor = Color.FromArgb(2, 24, 58);
            panelBar.Dock = DockStyle.Top;
            panelBar.Location = new Point(0, 0);
            panelBar.Name = "panelBar";
            panelBar.Size = new Size(800, 38);
            panelBar.TabIndex = 0;
            // 
            // AplicationWF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 414);
            Controls.Add(PanelAplication);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AplicationWF";
            Text = "Main";
            PanelAplication.ResumeLayout(false);
            mainLateral.ResumeLayout(false);
            mainLateral.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelAplication;
        private Panel PanelApp;
        private Panel mainLateral;
        private Button btnCerrarSesion;
        private Panel panel5;
        private Button btnGrupos;
        private Panel panel4;
        private Button btnDocentes;
        private Panel panel3;
        private Button btnAlumnos;
        private Panel panel2;
        private Button btnAsistencia;
        private Label label3;
        private Label lblAsitencia;
        private Label label2;
        private Label label5;
        private Panel panelBar;
    }
}