namespace Esfe.SysAsistencia.UI.Components
{
    partial class AlumnosWF
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel3 = new Panel();
            label9 = new Label();
            panel2 = new Panel();
            gridEstudiantes = new DataGridView();
            groupBox1 = new GroupBox();
            cbxGrupo = new ComboBox();
            label2 = new Label();
            label8 = new Label();
            btnChangeHuella = new Button();
            label7 = new Label();
            cbxCarrera = new ComboBox();
            txtTelefono = new TextBox();
            label5 = new Label();
            txtDui = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtApellidos = new TextBox();
            label1 = new Label();
            txtNombres = new TextBox();
            btnGuardar = new Button();
            btnEliminar = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridEstudiantes).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(827, 704);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(label9);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(groupBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(827, 704);
            panel3.TabIndex = 11;
            panel3.Paint += panel3_Paint;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(0, 40, 100);
            label9.Location = new Point(14, 16);
            label9.Name = "label9";
            label9.Size = new Size(157, 46);
            label9.TabIndex = 12;
            label9.Text = "Alumnos";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(gridEstudiantes);
            panel2.Location = new Point(367, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(461, 704);
            panel2.TabIndex = 11;
            // 
            // gridEstudiantes
            // 
            gridEstudiantes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridEstudiantes.BackgroundColor = Color.FromArgb(220, 230, 241);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridEstudiantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridEstudiantes.Location = new Point(3, 16);
            gridEstudiantes.Margin = new Padding(3, 4, 3, 4);
            gridEstudiantes.Name = "gridEstudiantes";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gridEstudiantes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gridEstudiantes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            gridEstudiantes.RowTemplate.Height = 25;
            gridEstudiantes.Size = new Size(443, 672);
            gridEstudiantes.TabIndex = 21;
            gridEstudiantes.SelectionChanged += gridDocentes_SelectionChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbxGrupo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btnChangeHuella);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cbxCarrera);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtDui);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtApellidos);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNombres);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.AppWorkspace;
            groupBox1.Location = new Point(14, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(346, 599);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Editar";
            // 
            // cbxGrupo
            // 
            cbxGrupo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxGrupo.FormattingEnabled = true;
            cbxGrupo.Location = new Point(114, 425);
            cbxGrupo.Name = "cbxGrupo";
            cbxGrupo.Size = new Size(212, 31);
            cbxGrupo.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(14, 436);
            label2.Name = "label2";
            label2.Size = new Size(68, 23);
            label2.TabIndex = 21;
            label2.Text = "Grupo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(14, 375);
            label8.Name = "label8";
            label8.Size = new Size(70, 23);
            label8.TabIndex = 19;
            label8.Text = "Huella";
            // 
            // btnChangeHuella
            // 
            btnChangeHuella.ForeColor = SystemColors.GrayText;
            btnChangeHuella.Location = new Point(115, 376);
            btnChangeHuella.Name = "btnChangeHuella";
            btnChangeHuella.Size = new Size(213, 35);
            btnChangeHuella.TabIndex = 18;
            btnChangeHuella.Text = "Cambiar Huella";
            btnChangeHuella.UseVisualStyleBackColor = true;
            btnChangeHuella.Click += btnChangeHuella_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(15, 320);
            label7.Name = "label7";
            label7.Size = new Size(80, 23);
            label7.TabIndex = 17;
            label7.Text = "Carrera";
            // 
            // cbxCarrera
            // 
            cbxCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCarrera.FormattingEnabled = true;
            cbxCarrera.Location = new Point(115, 317);
            cbxCarrera.Name = "cbxCarrera";
            cbxCarrera.Size = new Size(212, 31);
            cbxCarrera.TabIndex = 16;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.Location = new Point(15, 207);
            txtTelefono.MaxLength = 9;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(313, 32);
            txtTelefono.TabIndex = 14;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            txtTelefono.KeyPress += textBox_Press;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(15, 261);
            label5.Name = "label5";
            label5.Size = new Size(42, 23);
            label5.TabIndex = 13;
            label5.Text = "DUI";
            // 
            // txtDui
            // 
            txtDui.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDui.Location = new Point(115, 263);
            txtDui.MaxLength = 10;
            txtDui.Name = "txtDui";
            txtDui.Size = new Size(211, 32);
            txtDui.TabIndex = 12;
            txtDui.TextChanged += txtDui_TextChanged;
            txtDui.KeyPress += textBox_Press;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(15, 179);
            label4.Name = "label4";
            label4.Size = new Size(93, 23);
            label4.TabIndex = 11;
            label4.Text = "Teléfono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(13, 113);
            label3.Name = "label3";
            label3.Size = new Size(98, 23);
            label3.TabIndex = 9;
            label3.Text = "Apellidos";
            // 
            // txtApellidos
            // 
            txtApellidos.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellidos.Location = new Point(15, 141);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(311, 32);
            txtApellidos.TabIndex = 8;
            txtApellidos.KeyPress += textBox_Press;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(14, 36);
            label1.Name = "label1";
            label1.Size = new Size(95, 23);
            label1.TabIndex = 7;
            label1.Text = "Nombres";
            // 
            // txtNombres
            // 
            txtNombres.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombres.Location = new Point(15, 64);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(313, 32);
            txtNombres.TabIndex = 2;
            txtNombres.KeyPress += textBox_Press;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.SkyBlue;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = SystemColors.ActiveCaptionText;
            btnGuardar.Location = new Point(174, 537);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(153, 43);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Salmon;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = SystemColors.ActiveCaptionText;
            btnEliminar.Location = new Point(15, 537);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(153, 43);
            btnEliminar.TabIndex = 0;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // AlumnosWF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 704);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AlumnosWF";
            Text = "AlumnosWF";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridEstudiantes).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private GroupBox groupBox1;
        private Label label8;
        private Button btnChangeHuella;
        private Label label7;
        private ComboBox cbxCarrera;
        private TextBox txtTelefono;
        private Label label5;
        private TextBox txtDui;
        private Label label4;
        private Label label3;
        private TextBox txtApellidos;
        private Label label1;
        private TextBox txtNombres;
        private Button btnGuardar;
        private Button btnEliminar;
        private ComboBox cbxGrupo;
        private Label label2;
        private Panel panel2;
        private DataGridView gridEstudiantes;
        private Label label9;
    }
}