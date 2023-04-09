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
            PanelGrupos = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            btnAgregar = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            cbxAño = new ComboBox();
            cbxCarrera = new ComboBox();
            gridGrupos = new DataGridView();
            Editar = new DataGridViewImageColumn();
            Eliminar = new DataGridViewImageColumn();
            PanelGrupos.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridGrupos).BeginInit();
            SuspendLayout();
            // 
            // PanelGrupos
            // 
            PanelGrupos.Controls.Add(panel2);
            PanelGrupos.Dock = DockStyle.Fill;
            PanelGrupos.Location = new Point(0, 0);
            PanelGrupos.Margin = new Padding(3, 2, 3, 2);
            PanelGrupos.Name = "PanelGrupos";
            PanelGrupos.Size = new Size(600, 500);
            PanelGrupos.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnAgregar);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(cbxAño);
            panel2.Controls.Add(cbxCarrera);
            panel2.Controls.Add(gridGrupos);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(600, 500);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 40, 100);
            label1.Location = new Point(27, 16);
            label1.Name = "label1";
            label1.Size = new Size(106, 37);
            label1.TabIndex = 0;
            label1.Text = "Grupos";
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAgregar.AutoSize = true;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.ForeColor = SystemColors.ActiveCaptionText;
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(286, 434);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(285, 32);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "      Agregar nuevo grupo";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.ImageAlign = ContentAlignment.MiddleLeft;
            label8.Location = new Point(412, 55);
            label8.Name = "label8";
            label8.Size = new Size(41, 21);
            label8.TabIndex = 7;
            label8.Text = "Año:";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Cursor = Cursors.Hand;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.ImageAlign = ContentAlignment.MiddleLeft;
            label7.Location = new Point(260, 55);
            label7.Name = "label7";
            label7.Size = new Size(65, 21);
            label7.TabIndex = 6;
            label7.Text = "Carrera:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Image = (Image)resources.GetObject("label6.Image");
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(495, 16);
            label6.Name = "label6";
            label6.Size = new Size(75, 21);
            label6.TabIndex = 5;
            label6.Text = "      Filtrar";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cbxAño
            // 
            cbxAño.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbxAño.BackColor = Color.FromArgb(0, 40, 100);
            cbxAño.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAño.FlatStyle = FlatStyle.Flat;
            cbxAño.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cbxAño.ForeColor = SystemColors.Menu;
            cbxAño.FormattingEnabled = true;
            cbxAño.ImeMode = ImeMode.NoControl;
            cbxAño.Location = new Point(412, 79);
            cbxAño.Name = "cbxAño";
            cbxAño.Size = new Size(158, 28);
            cbxAño.TabIndex = 4;
            cbxAño.SelectedIndexChanged += actualizarGrid;
            // 
            // cbxCarrera
            // 
            cbxCarrera.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbxCarrera.BackColor = Color.FromArgb(0, 40, 100);
            cbxCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCarrera.FlatStyle = FlatStyle.Flat;
            cbxCarrera.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cbxCarrera.ForeColor = SystemColors.Menu;
            cbxCarrera.FormattingEnabled = true;
            cbxCarrera.Location = new Point(260, 79);
            cbxCarrera.Name = "cbxCarrera";
            cbxCarrera.Size = new Size(146, 28);
            cbxCarrera.TabIndex = 3;
            cbxCarrera.SelectedIndexChanged += actualizarGrid;
            // 
            // gridGrupos
            // 
            gridGrupos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridGrupos.BackgroundColor = Color.FromArgb(220, 230, 241);
            gridGrupos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridGrupos.Columns.AddRange(new DataGridViewColumn[] { Editar, Eliminar });
            gridGrupos.Location = new Point(27, 128);
            gridGrupos.Name = "gridGrupos";
            gridGrupos.RowTemplate.Height = 25;
            gridGrupos.Size = new Size(544, 282);
            gridGrupos.TabIndex = 2;
            gridGrupos.CellClick += gridGrupos_CellClick;
            gridGrupos.CellContentClick += gridGrupos_CellContentClick;
            // 
            // Editar
            // 
            Editar.HeaderText = "Editar";
            Editar.Image = Properties.Resources.EditIco;
            Editar.Name = "Editar";
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Image = Properties.Resources.deleRoj;
            Eliminar.Name = "Eliminar";
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
            ResumeLayout(false);
        }

        #endregion
        private Panel PanelGrupos;
        private Label btnAgregar;
        private Panel panel2;
        private DataGridView gridGrupos;
        private Label label8;
        private Label label7;
        private Label label6;
        private ComboBox cbxAño;
        private ComboBox cbxCarrera;
        private Label label1;
        private DataGridViewImageColumn Editar;
        private DataGridViewImageColumn Eliminar;
    }
}