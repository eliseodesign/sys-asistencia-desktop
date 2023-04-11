namespace Esfe.SysAsistencia.UI.Components
{
    partial class DocentesWF
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
            panel1 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            panel4 = new Panel();
            groupBox1 = new GroupBox();
            btnEliminar = new Button();
            btnGuardar = new Button();
            label8 = new Label();
            btnChangeHuella = new Button();
            label7 = new Label();
            txtCarrera = new ComboBox();
            label6 = new Label();
            txtTelefono = new TextBox();
            label5 = new Label();
            txtDui = new TextBox();
            label4 = new Label();
            txtNit = new TextBox();
            label3 = new Label();
            txtApellidos = new TextBox();
            label1 = new Label();
            txtNombres = new TextBox();
            panel2 = new Panel();
            gridDocentes = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridDocentes).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(720, 546);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(720, 546);
            panel3.TabIndex = 10;
            panel3.Paint += panel3_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 40, 100);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(131, 37);
            label2.TabIndex = 11;
            label2.Text = "Docentes";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel4.AutoScroll = true;
            panel4.Controls.Add(groupBox1);
            panel4.Location = new Point(0, 49);
            panel4.Name = "panel4";
            panel4.Size = new Size(315, 485);
            panel4.TabIndex = 21;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btnChangeHuella);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtCarrera);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtDui);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtNit);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtApellidos);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNombres);
            groupBox1.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.AppWorkspace;
            groupBox1.Location = new Point(12, 20);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(303, 463);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Editar";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Salmon;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = SystemColors.ActiveCaptionText;
            btnEliminar.Location = new Point(15, 415);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(130, 32);
            btnEliminar.TabIndex = 21;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.SkyBlue;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = SystemColors.ActiveCaptionText;
            btnGuardar.Location = new Point(151, 415);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(136, 32);
            btnGuardar.TabIndex = 22;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(18, 342);
            label8.Name = "label8";
            label8.Size = new Size(53, 18);
            label8.TabIndex = 19;
            label8.Text = "Huella";
            // 
            // btnChangeHuella
            // 
            btnChangeHuella.ForeColor = SystemColors.GrayText;
            btnChangeHuella.Location = new Point(105, 333);
            btnChangeHuella.Margin = new Padding(3, 2, 3, 2);
            btnChangeHuella.Name = "btnChangeHuella";
            btnChangeHuella.Size = new Size(186, 37);
            btnChangeHuella.TabIndex = 18;
            btnChangeHuella.Text = "Escanear Huella";
            btnChangeHuella.UseVisualStyleBackColor = true;
            btnChangeHuella.Click += btnChangeHuella_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(11, 288);
            label7.Name = "label7";
            label7.Size = new Size(62, 18);
            label7.TabIndex = 17;
            label7.Text = "Carrera";
            // 
            // txtCarrera
            // 
            txtCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            txtCarrera.FormattingEnabled = true;
            txtCarrera.Location = new Point(101, 280);
            txtCarrera.Margin = new Padding(3, 2, 3, 2);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(186, 26);
            txtCarrera.TabIndex = 16;
            txtCarrera.SelectedValueChanged += txtCarrera_SelectedValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(13, 197);
            label6.Name = "label6";
            label6.Size = new Size(33, 18);
            label6.TabIndex = 15;
            label6.Text = "NIT";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.Location = new Point(13, 155);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.MaxLength = 9;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(274, 27);
            txtTelefono.TabIndex = 14;
            txtTelefono.KeyPress += textBox_Press;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(13, 238);
            label5.Name = "label5";
            label5.Size = new Size(33, 18);
            label5.TabIndex = 13;
            label5.Text = "DUI";
            // 
            // txtDui
            // 
            txtDui.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDui.Location = new Point(101, 239);
            txtDui.Margin = new Padding(3, 2, 3, 2);
            txtDui.MaxLength = 10;
            txtDui.Name = "txtDui";
            txtDui.Size = new Size(185, 27);
            txtDui.TabIndex = 12;
            txtDui.TextChanged += txtDui_TextChanged;
            txtDui.KeyPress += textBox_Press;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(13, 134);
            label4.Name = "label4";
            label4.Size = new Size(75, 18);
            label4.TabIndex = 11;
            label4.Text = "Teléfono";
            // 
            // txtNit
            // 
            txtNit.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNit.Location = new Point(101, 197);
            txtNit.Margin = new Padding(3, 2, 3, 2);
            txtNit.MaxLength = 17;
            txtNit.Name = "txtNit";
            txtNit.Size = new Size(186, 27);
            txtNit.TabIndex = 10;
            txtNit.TextChanged += txtNit_TextChanged;
            txtNit.KeyPress += textBox_Press;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(11, 85);
            label3.Name = "label3";
            label3.Size = new Size(76, 18);
            label3.TabIndex = 9;
            label3.Text = "Apellidos";
            // 
            // txtApellidos
            // 
            txtApellidos.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellidos.Location = new Point(13, 106);
            txtApellidos.Margin = new Padding(3, 2, 3, 2);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(273, 27);
            txtApellidos.TabIndex = 8;
            txtApellidos.KeyPress += textBox_Press;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(75, 18);
            label1.TabIndex = 7;
            label1.Text = "Nombres";
            // 
            // txtNombres
            // 
            txtNombres.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombres.Location = new Point(13, 48);
            txtNombres.Margin = new Padding(3, 2, 3, 2);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(274, 27);
            txtNombres.TabIndex = 2;
            txtNombres.KeyPress += textBox_Press;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(gridDocentes);
            panel2.Location = new Point(312, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(408, 546);
            panel2.TabIndex = 11;
            // 
            // gridDocentes
            // 
            gridDocentes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridDocentes.BackgroundColor = Color.FromArgb(220, 230, 241);
            gridDocentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridDocentes.Location = new Point(16, 12);
            gridDocentes.Name = "gridDocentes";
            gridDocentes.RowHeadersWidth = 51;
            gridDocentes.RowTemplate.Height = 25;
            gridDocentes.Size = new Size(380, 522);
            gridDocentes.TabIndex = 0;
            gridDocentes.SelectionChanged += gridDocentes_SelectionChanged;
            // 
            // DocentesWF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 546);
            Controls.Add(panel1);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "DocentesWF";
            Text = "DocentesWF";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridDocentes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private DataGridView gridDocentes;
        private Panel panel4;
        private GroupBox groupBox1;
        private Label label8;
        private Button btnChangeHuella;
        private Label label7;
        private ComboBox txtCarrera;
        private Label label6;
        private TextBox txtTelefono;
        private Label label5;
        private TextBox txtDui;
        private Label label4;
        private TextBox txtNit;
        private Label label3;
        private TextBox txtApellidos;
        private Label label1;
        private TextBox txtNombres;
        private Button btnEliminar;
        private Button btnGuardar;
        private Label label2;
    }
}