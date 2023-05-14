//namespace Esfe.SysAsistencia.UI.Components
//{
//    partial class _DetailGrupo
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            lblTitulo = new Label();
//            groupBox = new GroupBox();
//            lblVirtual = new Label();
//            lblPresencial = new Label();
//            vie = new CheckBox();
//            jue = new CheckBox();
//            mie = new CheckBox();
//            mar = new CheckBox();
//            lun = new CheckBox();
//            label5 = new Label();
//            label4 = new Label();
//            label3 = new Label();
//            cbxTurno = new ComboBox();
//            label2 = new Label();
//            numEstudiantes = new NumericUpDown();
//            label1 = new Label();
//            cbxAño = new ComboBox();
//            label7 = new Label();
//            cbxCarrera = new ComboBox();
//            btnGuardar = new Button();
//            btnCancelar = new Button();
//            imgEdit = new PictureBox();
//            imgAgregar = new PictureBox();
//            panel1 = new Panel();
//            groupBox.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)numEstudiantes).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)imgEdit).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)imgAgregar).BeginInit();
//            panel1.SuspendLayout();
//            SuspendLayout();
//            // 
//            // lblTitulo
//            // 
//            lblTitulo.AutoSize = true;
//            lblTitulo.BackColor = Color.White;
//            lblTitulo.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
//            lblTitulo.ForeColor = Color.Black;
//            lblTitulo.Location = new Point(202, 12);
//            lblTitulo.Name = "lblTitulo";
//            lblTitulo.Size = new Size(192, 46);
//            lblTitulo.TabIndex = 1;
//            lblTitulo.Text = "_____  ______";
//            // 
//            // groupBox
//            // 
//            groupBox.Anchor = AnchorStyles.Left;
//            groupBox.BackColor = Color.White;
//            groupBox.Controls.Add(lblVirtual);
//            groupBox.Controls.Add(lblPresencial);
//            groupBox.Controls.Add(vie);
//            groupBox.Controls.Add(jue);
//            groupBox.Controls.Add(mie);
//            groupBox.Controls.Add(mar);
//            groupBox.Controls.Add(lun);
//            groupBox.Controls.Add(label5);
//            groupBox.Controls.Add(label4);
//            groupBox.Controls.Add(label3);
//            groupBox.Controls.Add(cbxTurno);
//            groupBox.Controls.Add(label2);
//            groupBox.Controls.Add(numEstudiantes);
//            groupBox.Controls.Add(label1);
//            groupBox.Controls.Add(cbxAño);
//            groupBox.Controls.Add(label7);
//            groupBox.Controls.Add(cbxCarrera);
//            groupBox.Controls.Add(btnGuardar);
//            groupBox.Controls.Add(btnCancelar);
//            groupBox.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
//            groupBox.ForeColor = SystemColors.AppWorkspace;
//            groupBox.Location = new Point(11, 88);
//            groupBox.Name = "groupBox";
//            groupBox.Size = new Size(577, 451);
//            groupBox.TabIndex = 10;
//            groupBox.TabStop = false;
//            groupBox.Text = "Datos del grupo";
//            // 
//            // lblVirtual
//            // 
//            lblVirtual.AutoSize = true;
//            lblVirtual.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
//            lblVirtual.ForeColor = Color.FromArgb(58, 163, 217);
//            lblVirtual.Location = new Point(427, 285);
//            lblVirtual.Name = "lblVirtual";
//            lblVirtual.Size = new Size(88, 23);
//            lblVirtual.TabIndex = 34;
//            lblVirtual.Text = "5 virtual";
//            // 
//            // lblPresencial
//            // 
//            lblPresencial.AutoSize = true;
//            lblPresencial.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
//            lblPresencial.ForeColor = Color.FromArgb(58, 163, 217);
//            lblPresencial.Location = new Point(287, 285);
//            lblPresencial.Name = "lblPresencial";
//            lblPresencial.Size = new Size(125, 23);
//            lblPresencial.TabIndex = 33;
//            lblPresencial.Text = "0 presencial";
//            // 
//            // vie
//            // 
//            vie.AutoSize = true;
//            vie.Location = new Point(525, 239);
//            vie.Margin = new Padding(3, 4, 3, 4);
//            vie.Name = "vie";
//            vie.Size = new Size(18, 17);
//            vie.TabIndex = 32;
//            vie.UseVisualStyleBackColor = true;
//            vie.CheckedChanged += changeLbl;
//            // 
//            // jue
//            // 
//            jue.AutoSize = true;
//            jue.Location = new Point(468, 240);
//            jue.Margin = new Padding(3, 4, 3, 4);
//            jue.Name = "jue";
//            jue.Size = new Size(18, 17);
//            jue.TabIndex = 31;
//            jue.UseVisualStyleBackColor = true;
//            jue.CheckedChanged += changeLbl;
//            // 
//            // mie
//            // 
//            mie.AutoSize = true;
//            mie.Location = new Point(401, 240);
//            mie.Margin = new Padding(3, 4, 3, 4);
//            mie.Name = "mie";
//            mie.Size = new Size(18, 17);
//            mie.TabIndex = 30;
//            mie.UseVisualStyleBackColor = true;
//            mie.CheckedChanged += changeLbl;
//            // 
//            // mar
//            // 
//            mar.AutoSize = true;
//            mar.Location = new Point(341, 240);
//            mar.Margin = new Padding(3, 4, 3, 4);
//            mar.Name = "mar";
//            mar.Size = new Size(18, 17);
//            mar.TabIndex = 29;
//            mar.UseVisualStyleBackColor = true;
//            mar.CheckedChanged += changeLbl;
//            // 
//            // lun
//            // 
//            lun.AutoSize = true;
//            lun.Location = new Point(285, 240);
//            lun.Margin = new Padding(3, 4, 3, 4);
//            lun.Name = "lun";
//            lun.Size = new Size(18, 17);
//            lun.TabIndex = 28;
//            lun.UseVisualStyleBackColor = true;
//            lun.CheckedChanged += changeLbl;
//            // 
//            // label5
//            // 
//            label5.AutoSize = true;
//            label5.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
//            label5.ForeColor = SystemColors.ControlDarkDark;
//            label5.Location = new Point(267, 195);
//            label5.Name = "label5";
//            label5.Size = new Size(300, 23);
//            label5.TabIndex = 27;
//            label5.Text = "lun.    mar.    mie.     jue.    vie.";
//            // 
//            // label4
//            // 
//            label4.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
//            label4.ForeColor = SystemColors.ActiveCaptionText;
//            label4.Location = new Point(267, 147);
//            label4.Name = "label4";
//            label4.Size = new Size(294, 34);
//            label4.TabIndex = 26;
//            label4.Text = "Días presenciales";
//            label4.TextAlign = ContentAlignment.MiddleLeft;
//            // 
//            // label3
//            // 
//            label3.AutoSize = true;
//            label3.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
//            label3.ForeColor = SystemColors.ActiveCaptionText;
//            label3.Location = new Point(21, 235);
//            label3.Name = "label3";
//            label3.Size = new Size(66, 23);
//            label3.TabIndex = 25;
//            label3.Text = "Turno";
//            // 
//            // cbxTurno
//            // 
//            cbxTurno.DropDownStyle = ComboBoxStyle.DropDownList;
//            cbxTurno.FormattingEnabled = true;
//            cbxTurno.Location = new Point(21, 275);
//            cbxTurno.Name = "cbxTurno";
//            cbxTurno.Size = new Size(212, 31);
//            cbxTurno.TabIndex = 24;
//            // 
//            // label2
//            // 
//            label2.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
//            label2.ForeColor = SystemColors.ActiveCaptionText;
//            label2.Location = new Point(267, 48);
//            label2.Name = "label2";
//            label2.Size = new Size(294, 23);
//            label2.TabIndex = 23;
//            label2.Text = "Estudiantes Máximos";
//            label2.TextAlign = ContentAlignment.MiddleLeft;
//            // 
//            // numEstudiantes
//            // 
//            numEstudiantes.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
//            numEstudiantes.Location = new Point(267, 95);
//            numEstudiantes.Margin = new Padding(3, 4, 3, 4);
//            numEstudiantes.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
//            numEstudiantes.Name = "numEstudiantes";
//            numEstudiantes.Size = new Size(294, 32);
//            numEstudiantes.TabIndex = 22;
//            // 
//            // label1
//            // 
//            label1.AutoSize = true;
//            label1.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
//            label1.ForeColor = SystemColors.ActiveCaptionText;
//            label1.Location = new Point(21, 147);
//            label1.Name = "label1";
//            label1.Size = new Size(47, 23);
//            label1.TabIndex = 21;
//            label1.Text = "Año";
//            // 
//            // cbxAño
//            // 
//            cbxAño.DropDownStyle = ComboBoxStyle.DropDownList;
//            cbxAño.FormattingEnabled = true;
//            cbxAño.Location = new Point(21, 184);
//            cbxAño.Name = "cbxAño";
//            cbxAño.Size = new Size(212, 31);
//            cbxAño.TabIndex = 20;
//            // 
//            // label7
//            // 
//            label7.AutoSize = true;
//            label7.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
//            label7.ForeColor = SystemColors.ActiveCaptionText;
//            label7.Location = new Point(21, 48);
//            label7.Name = "label7";
//            label7.Size = new Size(80, 23);
//            label7.TabIndex = 17;
//            label7.Text = "Carrera";
//            // 
//            // cbxCarrera
//            // 
//            cbxCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
//            cbxCarrera.FormattingEnabled = true;
//            cbxCarrera.Location = new Point(21, 95);
//            cbxCarrera.Name = "cbxCarrera";
//            cbxCarrera.Size = new Size(212, 31);
//            cbxCarrera.TabIndex = 16;
//            // 
//            // btnGuardar
//            // 
//            btnGuardar.BackColor = Color.FromArgb(58, 163, 217);
//            btnGuardar.FlatStyle = FlatStyle.Flat;
//            btnGuardar.ForeColor = SystemColors.ButtonFace;
//            btnGuardar.Location = new Point(314, 364);
//            btnGuardar.Name = "btnGuardar";
//            btnGuardar.Size = new Size(213, 52);
//            btnGuardar.TabIndex = 1;
//            btnGuardar.Text = "Aceptar";
//            btnGuardar.UseVisualStyleBackColor = false;
//            btnGuardar.Click += btnGuardar_Click;
//            // 
//            // btnCancelar
//            // 
//            btnCancelar.BackColor = Color.Salmon;
//            btnCancelar.FlatStyle = FlatStyle.Flat;
//            btnCancelar.ForeColor = SystemColors.Control;
//            btnCancelar.Location = new Point(56, 364);
//            btnCancelar.Name = "btnCancelar";
//            btnCancelar.Size = new Size(213, 52);
//            btnCancelar.TabIndex = 0;
//            btnCancelar.Text = "Cancelar";
//            btnCancelar.UseVisualStyleBackColor = false;
//            btnCancelar.Click += btnCancelar_Click;
//            // 
//            // imgEdit
//            // 
//            imgEdit.BackColor = Color.White;
//            imgEdit.Image = Properties.Resources.editVer;
//            imgEdit.Location = new Point(142, 16);
//            imgEdit.Margin = new Padding(3, 4, 3, 4);
//            imgEdit.Name = "imgEdit";
//            imgEdit.Size = new Size(40, 47);
//            imgEdit.SizeMode = PictureBoxSizeMode.Zoom;
//            imgEdit.TabIndex = 11;
//            imgEdit.TabStop = false;
//            // 
//            // imgAgregar
//            // 
//            imgAgregar.BackColor = Color.White;
//            imgAgregar.Image = Properties.Resources.agregar_documento__2_;
//            imgAgregar.Location = new Point(136, 8);
//            imgAgregar.Margin = new Padding(3, 4, 3, 4);
//            imgAgregar.Name = "imgAgregar";
//            imgAgregar.Size = new Size(40, 47);
//            imgAgregar.SizeMode = PictureBoxSizeMode.Zoom;
//            imgAgregar.TabIndex = 12;
//            imgAgregar.TabStop = false;
//            // 
//            // panel1
//            // 
//            panel1.BackColor = Color.White;
//            panel1.Controls.Add(imgAgregar);
//            panel1.Location = new Point(6, 8);
//            panel1.Name = "panel1";
//            panel1.Padding = new Padding(22);
//            panel1.Size = new Size(588, 558);
//            panel1.TabIndex = 35;
//            // 
//            // _DetailGrupo
//            // 
//            AutoScaleDimensions = new SizeF(8F, 20F);
//            AutoScaleMode = AutoScaleMode.Font;
//            BackColor = Color.Black;
//            ClientSize = new Size(603, 573);
//            Controls.Add(imgEdit);
//            Controls.Add(groupBox);
//            Controls.Add(lblTitulo);
//            Controls.Add(panel1);
//            FormBorderStyle = FormBorderStyle.None;
//            Margin = new Padding(3, 4, 3, 4);
//            Name = "_DetailGrupo";
//            StartPosition = FormStartPosition.CenterParent;
//            Text = "_DetailGrupo";
//            groupBox.ResumeLayout(false);
//            groupBox.PerformLayout();
//            ((System.ComponentModel.ISupportInitialize)numEstudiantes).EndInit();
//            ((System.ComponentModel.ISupportInitialize)imgEdit).EndInit();
//            ((System.ComponentModel.ISupportInitialize)imgAgregar).EndInit();
//            panel1.ResumeLayout(false);
//            ResumeLayout(false);
//            PerformLayout();
//        }

//        #endregion

//        private Label lblTitulo;
//        private GroupBox groupBox;
//        private Label label2;
//        private NumericUpDown numEstudiantes;
//        private Label label1;
//        private ComboBox cbxAño;
//        private Label label7;
//        private ComboBox cbxCarrera;
//        private Button btnGuardar;
//        private Button btnCancelar;
//        private Label label3;
//        private ComboBox cbxTurno;
//        private PictureBox imgEdit;
//        private PictureBox imgAgregar;
//        private CheckBox vie;
//        private CheckBox jue;
//        private CheckBox mie;
//        private CheckBox mar;
//        private CheckBox lun;
//        private Label label5;
//        private Label label4;
//        private Label lblVirtual;
//        private Label lblPresencial;
//        private Panel panel1;
//    }
//}