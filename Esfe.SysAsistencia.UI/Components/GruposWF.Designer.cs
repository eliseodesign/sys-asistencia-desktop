namespace Esfe.SysAsistencia.UI.Components
{
    partial class GruposWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GruposWF));
            label1 = new Label();
            PanelGrupos = new Panel();
            panel2 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            gridGrupos = new DataGridView();
            panel1 = new Panel();
            label5 = new Label();
            btnEliminar = new Label();
            btnEditar = new Label();
            btnAgregar = new Label();
            PanelGrupos.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridGrupos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(32, 18);
            label1.Name = "label1";
            label1.Size = new Size(94, 37);
            label1.TabIndex = 0;
            label1.Text = "Grupo";
            // 
            // PanelGrupos
            // 
            PanelGrupos.Controls.Add(panel2);
            PanelGrupos.Controls.Add(panel1);
            PanelGrupos.Dock = DockStyle.Fill;
            PanelGrupos.Location = new Point(0, 0);
            PanelGrupos.Margin = new Padding(3, 2, 3, 2);
            PanelGrupos.Name = "PanelGrupos";
            PanelGrupos.Size = new Size(600, 500);
            PanelGrupos.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(gridGrupos);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(248, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(352, 500);
            panel2.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.ImageAlign = ContentAlignment.MiddleLeft;
            label8.Location = new Point(171, 76);
            label8.Name = "label8";
            label8.Size = new Size(41, 21);
            label8.TabIndex = 7;
            label8.Text = "Año:";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Cursor = Cursors.Hand;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.ImageAlign = ContentAlignment.MiddleLeft;
            label7.Location = new Point(19, 76);
            label7.Name = "label7";
            label7.Size = new Size(65, 21);
            label7.TabIndex = 6;
            label7.Text = "Carrera:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Image = (Image)resources.GetObject("label6.Image");
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(17, 44);
            label6.Name = "label6";
            label6.Size = new Size(75, 21);
            label6.TabIndex = 5;
            label6.Text = "      Filtrar";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(171, 100);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(158, 23);
            comboBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(19, 100);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(146, 23);
            comboBox1.TabIndex = 3;
            // 
            // gridGrupos
            // 
            gridGrupos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridGrupos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridGrupos.Location = new Point(17, 129);
            gridGrupos.Name = "gridGrupos";
            gridGrupos.RowTemplate.Height = 25;
            gridGrupos.Size = new Size(312, 344);
            gridGrupos.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 500);
            panel1.TabIndex = 2;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Image = (Image)resources.GetObject("label5.Image");
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(31, 312);
            label5.Name = "label5";
            label5.Size = new Size(171, 32);
            label5.TabIndex = 4;
            label5.Text = "      Asistencias";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Left;
            btnEliminar.AutoSize = true;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = SystemColors.ActiveCaptionText;
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(32, 260);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(141, 32);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "      Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Left;
            btnEditar.AutoSize = true;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditar.ForeColor = SystemColors.ActiveCaptionText;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(32, 202);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(116, 32);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "      Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Left;
            btnAgregar.AutoSize = true;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.ForeColor = SystemColors.ActiveCaptionText;
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(32, 142);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(140, 32);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "      Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // GruposWF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 500);
            Controls.Add(PanelGrupos);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "GruposWF";
            Text = "GruposWF";
            PanelGrupos.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridGrupos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel PanelGrupos;
        private Panel panel1;
        private Label btnAgregar;
        private Label label5;
        private Label btnEliminar;
        private Label btnEditar;
        private Panel panel2;
        private DataGridView gridGrupos;
        private Label label8;
        private Label label7;
        private Label label6;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
    }
}