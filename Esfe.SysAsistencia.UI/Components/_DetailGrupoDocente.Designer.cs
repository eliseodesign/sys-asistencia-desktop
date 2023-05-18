namespace Esfe.SysAsistencia.UI.Components
{
    partial class _DetailGrupoDocente
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
            gridGrupoDocentes = new DataGridView();
            Delete = new DataGridViewImageColumn();
            labelCarrera = new Label();
            label1 = new Label();
            listBox = new ListBox();
            lblTitulo = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridGrupoDocentes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(gridGrupoDocentes);
            panel1.Controls.Add(labelCarrera);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(listBox);
            panel1.Controls.Add(lblTitulo);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 0;
            // 
            // gridGrupoDocentes
            // 
            gridGrupoDocentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridGrupoDocentes.Columns.AddRange(new DataGridViewColumn[] { Delete });
            gridGrupoDocentes.Location = new Point(426, 142);
            gridGrupoDocentes.Name = "gridGrupoDocentes";
            gridGrupoDocentes.RowTemplate.Height = 25;
            gridGrupoDocentes.Size = new Size(303, 256);
            gridGrupoDocentes.TabIndex = 7;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.Image = Properties.Resources.deleRoj;
            Delete.Name = "Delete";
            // 
            // labelCarrera
            // 
            labelCarrera.AutoSize = true;
            labelCarrera.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelCarrera.ForeColor = SystemColors.ControlDarkDark;
            labelCarrera.Location = new Point(128, 57);
            labelCarrera.Name = "labelCarrera";
            labelCarrera.Size = new Size(106, 21);
            labelCarrera.TabIndex = 6;
            labelCarrera.Text = "Docentes de ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(27, 57);
            label1.Name = "label1";
            label1.Size = new Size(106, 21);
            label1.TabIndex = 5;
            label1.Text = "Docentes de ";
            // 
            // listBox
            // 
            listBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 21;
            listBox.Location = new Point(27, 142);
            listBox.Name = "listBox";
            listBox.Size = new Size(332, 256);
            listBox.TabIndex = 4;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitulo.Location = new Point(217, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(219, 37);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Asignar Docente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonShadow;
            label2.Location = new Point(27, 97);
            label2.Name = "label2";
            label2.Size = new Size(242, 21);
            label2.TabIndex = 8;
            label2.Text = "Has click para agregar docentes";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.agregar_usuario__1_;
            pictureBox1.Location = new Point(442, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // _DetailGrupoDocente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "_DetailGrupoDocente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "_DetailGrupoDocente";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridGrupoDocentes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitulo;
        private ListBox listBox;
        private Label labelCarrera;
        private Label label1;
        private DataGridView gridGrupoDocentes;
        private DataGridViewImageColumn Delete;
        private PictureBox pictureBox1;
        private Label label2;
    }
}