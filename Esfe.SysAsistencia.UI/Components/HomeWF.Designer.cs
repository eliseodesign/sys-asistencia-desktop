namespace Esfe.SysAsistencia.UI.Components
{
    partial class HomeWF
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            panel3 = new Panel();
            lblGrupos = new Label();
            label3 = new Label();
            panel2 = new Panel();
            lblEstudiantes = new Label();
            label2 = new Label();
            panel1 = new Panel();
            lblDocentes = new Label();
            groupBox2 = new GroupBox();
            lblFecha = new Label();
            lblHora = new Label();
            timer = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(39, 83);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "Docentes";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(panel1);
            groupBox1.ForeColor = SystemColors.ControlDarkDark;
            groupBox1.Location = new Point(37, 134);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(573, 228);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estadisticas ";
            // 
            // panel3
            // 
            panel3.Controls.Add(lblGrupos);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(380, 78);
            panel3.Name = "panel3";
            panel3.Size = new Size(173, 112);
            panel3.TabIndex = 4;
            // 
            // lblGrupos
            // 
            lblGrupos.AutoSize = true;
            lblGrupos.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblGrupos.Location = new Point(57, 29);
            lblGrupos.Name = "lblGrupos";
            lblGrupos.Size = new Size(33, 20);
            lblGrupos.TabIndex = 3;
            lblGrupos.Text = "___";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(57, 83);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 2;
            label3.Text = "Grupos";
            // 
            // panel2
            // 
            panel2.Controls.Add(lblEstudiantes);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(201, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(173, 112);
            panel2.TabIndex = 4;
            // 
            // lblEstudiantes
            // 
            lblEstudiantes.AutoSize = true;
            lblEstudiantes.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEstudiantes.Location = new Point(53, 29);
            lblEstudiantes.Name = "lblEstudiantes";
            lblEstudiantes.Size = new Size(33, 20);
            lblEstudiantes.TabIndex = 2;
            lblEstudiantes.Text = "___";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(41, 83);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 1;
            label2.Text = "Estudiantes";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblDocentes);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(18, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(173, 112);
            panel1.TabIndex = 3;
            // 
            // lblDocentes
            // 
            lblDocentes.AutoSize = true;
            lblDocentes.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDocentes.Location = new Point(39, 29);
            lblDocentes.Name = "lblDocentes";
            lblDocentes.Size = new Size(33, 20);
            lblDocentes.TabIndex = 1;
            lblDocentes.Text = "___";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(lblFecha);
            groupBox2.Controls.Add(lblHora);
            groupBox2.ForeColor = SystemColors.ControlDarkDark;
            groupBox2.Location = new Point(37, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(573, 90);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Fecha y Hora";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Lucida Sans Unicode", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblFecha.ForeColor = Color.FromArgb(60, 152, 222);
            lblFecha.Location = new Point(18, 54);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(21, 23);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "_";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Lucida Sans Unicode", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblHora.ForeColor = Color.FromArgb(0, 40, 100);
            lblHora.Location = new Point(18, 19);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(31, 35);
            lblHora.TabIndex = 0;
            lblHora.Text = "_";
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // HomeWF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 387);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomeWF";
            Text = "HomeWF";
            groupBox1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private Label lblFecha;
        private Label lblHora;
        private System.Windows.Forms.Timer timer;
        private Panel panel3;
        private Label lblGrupos;
        private Panel panel2;
        private Label lblEstudiantes;
        private Panel panel1;
        private Label lblDocentes;
    }
}