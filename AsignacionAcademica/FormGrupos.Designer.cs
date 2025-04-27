namespace AsignacionAcademica
{
    partial class FormGrupos
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lblCarrera = new Label();
            lblNumAlumnos = new Label();
            lblGrupo = new Label();
            txtNumAlumnos = new TextBox();
            txtGrupo = new TextBox();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            pnlBotonActualizar = new Panel();
            btnActualizar = new Button();
            cmbCarrera = new ComboBox();
            dgvGrupos = new Guna.UI2.WinForms.Guna2DataGridView();
            lblTitulo = new Label();
            pnlBotonActualizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrupos).BeginInit();
            SuspendLayout();
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.ForeColor = Color.White;
            lblCarrera.Location = new Point(30, 203);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(45, 15);
            lblCarrera.TabIndex = 37;
            lblCarrera.Text = "Carrera";
            // 
            // lblNumAlumnos
            // 
            lblNumAlumnos.AutoSize = true;
            lblNumAlumnos.ForeColor = Color.White;
            lblNumAlumnos.Location = new Point(30, 136);
            lblNumAlumnos.Name = "lblNumAlumnos";
            lblNumAlumnos.Size = new Size(116, 15);
            lblNumAlumnos.TabIndex = 36;
            lblNumAlumnos.Text = "Numero de alumnos";
            // 
            // lblGrupo
            // 
            lblGrupo.AutoSize = true;
            lblGrupo.ForeColor = Color.White;
            lblGrupo.Location = new Point(30, 71);
            lblGrupo.Name = "lblGrupo";
            lblGrupo.Size = new Size(40, 15);
            lblGrupo.TabIndex = 35;
            lblGrupo.Text = "Grupo";
            lblGrupo.Click += label1_Click;
            // 
            // txtNumAlumnos
            // 
            txtNumAlumnos.Location = new Point(30, 154);
            txtNumAlumnos.Name = "txtNumAlumnos";
            txtNumAlumnos.Size = new Size(159, 23);
            txtNumAlumnos.TabIndex = 33;
            // 
            // txtGrupo
            // 
            txtGrupo.Location = new Point(30, 89);
            txtGrupo.Name = "txtGrupo";
            txtGrupo.Size = new Size(159, 23);
            txtGrupo.TabIndex = 32;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(231, 175);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 44;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(231, 146);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 43;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(231, 117);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 42;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(231, 88);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 41;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // pnlBotonActualizar
            // 
            pnlBotonActualizar.Controls.Add(btnActualizar);
            pnlBotonActualizar.Location = new Point(228, 88);
            pnlBotonActualizar.Name = "pnlBotonActualizar";
            pnlBotonActualizar.Size = new Size(78, 27);
            pnlBotonActualizar.TabIndex = 45;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(3, 2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 20;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // cmbCarrera
            // 
            cmbCarrera.FormattingEnabled = true;
            cmbCarrera.Items.AddRange(new object[] { "Ing. Civil", "Ing. Sistemas computacionales", "Ing. Industrial", "Administración de empresas" });
            cmbCarrera.Location = new Point(30, 221);
            cmbCarrera.Name = "cmbCarrera";
            cmbCarrera.Size = new Size(159, 23);
            cmbCarrera.TabIndex = 46;
            // 
            // dgvGrupos
            // 
            dgvGrupos.AllowUserToAddRows = false;
            dgvGrupos.AllowUserToDeleteRows = false;
            dgvGrupos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(182, 205, 235);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgvGrupos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvGrupos.BackgroundColor = Color.FromArgb(27, 57, 106);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(27, 57, 160);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(27, 57, 160);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvGrupos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvGrupos.ColumnHeadersHeight = 25;
            dgvGrupos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(182, 205, 235);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvGrupos.DefaultCellStyle = dataGridViewCellStyle3;
            dgvGrupos.GridColor = Color.FromArgb(231, 229, 255);
            dgvGrupos.Location = new Point(378, 90);
            dgvGrupos.Name = "dgvGrupos";
            dgvGrupos.ReadOnly = true;
            dgvGrupos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvGrupos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvGrupos.RowHeadersVisible = false;
            dgvGrupos.Size = new Size(541, 293);
            dgvGrupos.TabIndex = 47;
            dgvGrupos.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvGrupos.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvGrupos.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvGrupos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvGrupos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvGrupos.ThemeStyle.BackColor = Color.FromArgb(27, 57, 106);
            dgvGrupos.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvGrupos.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvGrupos.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvGrupos.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvGrupos.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvGrupos.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvGrupos.ThemeStyle.HeaderStyle.Height = 25;
            dgvGrupos.ThemeStyle.ReadOnly = true;
            dgvGrupos.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvGrupos.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvGrupos.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvGrupos.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvGrupos.ThemeStyle.RowsStyle.Height = 25;
            dgvGrupos.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvGrupos.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvGrupos.CellContentClick += dgvGrupos_CellContentClick;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(378, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(133, 47);
            lblTitulo.TabIndex = 48;
            lblTitulo.Text = "Grupos";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // FormGrupos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 57, 106);
            ClientSize = new Size(931, 559);
            Controls.Add(lblTitulo);
            Controls.Add(dgvGrupos);
            Controls.Add(cmbCarrera);
            Controls.Add(pnlBotonActualizar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(lblCarrera);
            Controls.Add(lblNumAlumnos);
            Controls.Add(lblGrupo);
            Controls.Add(txtNumAlumnos);
            Controls.Add(txtGrupo);
            Name = "FormGrupos";
            Text = "FormGrupos";
            Load += FormGrupos_Load;
            pnlBotonActualizar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGrupos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox textBox4;
        private Label lblCarrera;
        private Label lblNumAlumnos;
        private Label lblGrupo;
        private TextBox txtNumAlumnos;
        private TextBox txtGrupo;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnGuardar;
        private Panel pnlBotonActualizar;
        private Button btnActualizar;
        private ComboBox cmbCarrera;
        private Guna.UI2.WinForms.Guna2DataGridView dgvGrupos;
        private Label lblTitulo;
    }
}