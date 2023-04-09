namespace Esfe.SysAsistencia.UI.Components
{
    partial class _DetailGrupo
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
            lblTitulo = new Label();
            groupBox = new GroupBox();
            lblVirtual = new Label();
            lblPresencial = new Label();
            vie = new CheckBox();
            jue = new CheckBox();
            mie = new CheckBox();
            mar = new CheckBox();
            lun = new CheckBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            cbxTurno = new ComboBox();
            label2 = new Label();
            numEstudiantes = new NumericUpDown();
            label1 = new Label();
            cbxAño = new ComboBox();
            label7 = new Label();
            cbxCarrera = new ComboBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            imgEdit = new PictureBox();
            imgAgregar = new PictureBox();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numEstudiantes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgAgregar).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(177, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(152, 37);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "_____  ______";
            // 
            // groupBox
            // 
            groupBox.Anchor = AnchorStyles.Left;
            groupBox.Controls.Add(lblVirtual);
            groupBox.Controls.Add(lblPresencial);
            groupBox.Controls.Add(vie);
            groupBox.Controls.Add(jue);
            groupBox.Controls.Add(mie);
            groupBox.Controls.Add(mar);
            groupBox.Controls.Add(lun);
            groupBox.Controls.Add(label5);
            groupBox.Controls.Add(label4);
            groupBox.Controls.Add(label3);
            groupBox.Controls.Add(cbxTurno);
            groupBox.Controls.Add(label2);
            groupBox.Controls.Add(numEstudiantes);
            groupBox.Controls.Add(label1);
            groupBox.Controls.Add(cbxAño);
            groupBox.Controls.Add(label7);
            groupBox.Controls.Add(cbxCarrera);
            groupBox.Controls.Add(btnGuardar);
            groupBox.Controls.Add(btnCancelar);
            groupBox.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox.ForeColor = SystemColors.AppWorkspace;
            groupBox.Location = new Point(12, 66);
            groupBox.Margin = new Padding(3, 2, 3, 2);
            groupBox.Name = "groupBox";
            groupBox.Padding = new Padding(3, 2, 3, 2);
            groupBox.Size = new Size(492, 338);
            groupBox.TabIndex = 10;
            groupBox.TabStop = false;
            groupBox.Text = "Datos del grupo";
            // 
            // lblVirtual
            // 
            lblVirtual.AutoSize = true;
            lblVirtual.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblVirtual.ForeColor = Color.FromArgb(58, 163, 217);
            lblVirtual.Location = new Point(367, 214);
            lblVirtual.Name = "lblVirtual";
            lblVirtual.Size = new Size(67, 18);
            lblVirtual.TabIndex = 34;
            lblVirtual.Text = "5 virtual";
            // 
            // lblPresencial
            // 
            lblPresencial.AutoSize = true;
            lblPresencial.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPresencial.ForeColor = Color.FromArgb(58, 163, 217);
            lblPresencial.Location = new Point(244, 214);
            lblPresencial.Name = "lblPresencial";
            lblPresencial.Size = new Size(96, 18);
            lblPresencial.TabIndex = 33;
            lblPresencial.Text = "0 presencial";
            // 
            // vie
            // 
            vie.AutoSize = true;
            vie.Location = new Point(454, 179);
            vie.Name = "vie";
            vie.Size = new Size(15, 14);
            vie.TabIndex = 32;
            vie.UseVisualStyleBackColor = true;
            vie.CheckedChanged += changeLbl;
            // 
            // jue
            // 
            jue.AutoSize = true;
            jue.Location = new Point(404, 180);
            jue.Name = "jue";
            jue.Size = new Size(15, 14);
            jue.TabIndex = 31;
            jue.UseVisualStyleBackColor = true;
            jue.CheckedChanged += changeLbl;
            // 
            // mie
            // 
            mie.AutoSize = true;
            mie.Location = new Point(346, 180);
            mie.Name = "mie";
            mie.Size = new Size(15, 14);
            mie.TabIndex = 30;
            mie.UseVisualStyleBackColor = true;
            mie.CheckedChanged += changeLbl;
            // 
            // mar
            // 
            mar.AutoSize = true;
            mar.Location = new Point(293, 180);
            mar.Name = "mar";
            mar.Size = new Size(15, 14);
            mar.TabIndex = 29;
            mar.UseVisualStyleBackColor = true;
            mar.CheckedChanged += changeLbl;
            // 
            // lun
            // 
            lun.AutoSize = true;
            lun.Location = new Point(244, 180);
            lun.Name = "lun";
            lun.Size = new Size(15, 14);
            lun.TabIndex = 28;
            lun.UseVisualStyleBackColor = true;
            lun.CheckedChanged += changeLbl;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(244, 146);
            label5.Name = "label5";
            label5.Size = new Size(239, 18);
            label5.TabIndex = 27;
            label5.Text = "lun.    mar.    mie.     jue.    vie.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(244, 110);
            label4.Name = "label4";
            label4.Size = new Size(117, 18);
            label4.TabIndex = 26;
            label4.Text = "Días presencial";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(18, 176);
            label3.Name = "label3";
            label3.Size = new Size(52, 18);
            label3.TabIndex = 25;
            label3.Text = "Turno";
            // 
            // cbxTurno
            // 
            cbxTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTurno.FormattingEnabled = true;
            cbxTurno.Location = new Point(18, 206);
            cbxTurno.Margin = new Padding(3, 2, 3, 2);
            cbxTurno.Name = "cbxTurno";
            cbxTurno.Size = new Size(186, 26);
            cbxTurno.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(244, 36);
            label2.Name = "label2";
            label2.Size = new Size(133, 18);
            label2.TabIndex = 23;
            label2.Text = "Estudiantes max.";
            // 
            // numEstudiantes
            // 
            numEstudiantes.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            numEstudiantes.Location = new Point(244, 71);
            numEstudiantes.Name = "numEstudiantes";
            numEstudiantes.Size = new Size(186, 27);
            numEstudiantes.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(18, 110);
            label1.Name = "label1";
            label1.Size = new Size(37, 18);
            label1.TabIndex = 21;
            label1.Text = "Año";
            // 
            // cbxAño
            // 
            cbxAño.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAño.FormattingEnabled = true;
            cbxAño.Location = new Point(18, 138);
            cbxAño.Margin = new Padding(3, 2, 3, 2);
            cbxAño.Name = "cbxAño";
            cbxAño.Size = new Size(186, 26);
            cbxAño.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(18, 36);
            label7.Name = "label7";
            label7.Size = new Size(62, 18);
            label7.TabIndex = 17;
            label7.Text = "Carrera";
            // 
            // cbxCarrera
            // 
            cbxCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCarrera.FormattingEnabled = true;
            cbxCarrera.Location = new Point(18, 71);
            cbxCarrera.Margin = new Padding(3, 2, 3, 2);
            cbxCarrera.Name = "cbxCarrera";
            cbxCarrera.Size = new Size(186, 26);
            cbxCarrera.TabIndex = 16;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(58, 163, 217);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = SystemColors.ButtonFace;
            btnGuardar.Location = new Point(244, 272);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(186, 39);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Okey";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Salmon;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = SystemColors.Control;
            btnCancelar.Location = new Point(18, 272);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(186, 39);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // imgEdit
            // 
            imgEdit.Image = Properties.Resources.editVer;
            imgEdit.Location = new Point(124, 12);
            imgEdit.Name = "imgEdit";
            imgEdit.Size = new Size(35, 35);
            imgEdit.SizeMode = PictureBoxSizeMode.Zoom;
            imgEdit.TabIndex = 11;
            imgEdit.TabStop = false;
            // 
            // imgAgregar
            // 
            imgAgregar.Image = Properties.Resources.agregar_documento__2_;
            imgAgregar.Location = new Point(124, 12);
            imgAgregar.Name = "imgAgregar";
            imgAgregar.Size = new Size(35, 35);
            imgAgregar.SizeMode = PictureBoxSizeMode.Zoom;
            imgAgregar.TabIndex = 12;
            imgAgregar.TabStop = false;
            // 
            // _DetailGrupo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(528, 430);
            Controls.Add(imgAgregar);
            Controls.Add(imgEdit);
            Controls.Add(groupBox);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "_DetailGrupo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "_DetailGrupo";
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numEstudiantes).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgAgregar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private GroupBox groupBox;
        private Label label2;
        private NumericUpDown numEstudiantes;
        private Label label1;
        private ComboBox cbxAño;
        private Label label7;
        private ComboBox cbxCarrera;
        private Button btnGuardar;
        private Button btnCancelar;
        private Label label3;
        private ComboBox cbxTurno;
        private PictureBox imgEdit;
        private PictureBox imgAgregar;
        private CheckBox vie;
        private CheckBox jue;
        private CheckBox mie;
        private CheckBox mar;
        private CheckBox lun;
        private Label label5;
        private Label label4;
        private Label lblVirtual;
        private Label lblPresencial;
    }
}