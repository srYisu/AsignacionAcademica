namespace AsignacionAcademica
{
    partial class FormAsignaturas
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
            txtAsignatura = new TextBox();
            cmbTipo = new ComboBox();
            lblAsignatura = new Label();
            lblTipo = new Label();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            pnlBotonActualizar = new Panel();
            btnActualizar = new Button();
            dgvAsignaturas = new Guna.UI2.WinForms.Guna2DataGridView();
            lblTitulo = new Label();
            pnlBotonActualizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAsignaturas).BeginInit();
            SuspendLayout();
            // 
            // txtAsignatura
            // 
            txtAsignatura.Location = new Point(23, 89);
            txtAsignatura.Name = "txtAsignatura";
            txtAsignatura.Size = new Size(159, 23);
            txtAsignatura.TabIndex = 2;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Teorica", "Practica", "Mixta" });
            cmbTipo.Location = new Point(23, 147);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(159, 23);
            cmbTipo.TabIndex = 5;
            // 
            // lblAsignatura
            // 
            lblAsignatura.AutoSize = true;
            lblAsignatura.ForeColor = Color.White;
            lblAsignatura.Location = new Point(23, 71);
            lblAsignatura.Name = "lblAsignatura";
            lblAsignatura.Size = new Size(64, 15);
            lblAsignatura.TabIndex = 16;
            lblAsignatura.Text = "Asignatura";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.ForeColor = Color.White;
            lblTipo.Location = new Point(23, 129);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(31, 15);
            lblTipo.TabIndex = 19;
            lblTipo.Text = "Tipo";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(232, 176);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 23;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(232, 147);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 22;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(232, 118);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 21;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(232, 89);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 20;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // pnlBotonActualizar
            // 
            pnlBotonActualizar.Controls.Add(btnActualizar);
            pnlBotonActualizar.Location = new Point(228, 89);
            pnlBotonActualizar.Name = "pnlBotonActualizar";
            pnlBotonActualizar.Size = new Size(79, 27);
            pnlBotonActualizar.TabIndex = 26;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(3, 2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 20;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click_1;
            // 
            // dgvAsignaturas
            // 
            dgvAsignaturas.AllowUserToAddRows = false;
            dgvAsignaturas.AllowUserToDeleteRows = false;
            dgvAsignaturas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(182, 205, 235);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgvAsignaturas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAsignaturas.BackgroundColor = Color.FromArgb(27, 57, 106);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(27, 57, 160);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(27, 57, 160);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAsignaturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAsignaturas.ColumnHeadersHeight = 25;
            dgvAsignaturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(182, 205, 235);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvAsignaturas.DefaultCellStyle = dataGridViewCellStyle3;
            dgvAsignaturas.GridColor = Color.FromArgb(231, 229, 255);
            dgvAsignaturas.Location = new Point(378, 89);
            dgvAsignaturas.Name = "dgvAsignaturas";
            dgvAsignaturas.ReadOnly = true;
            dgvAsignaturas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvAsignaturas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvAsignaturas.RowHeadersVisible = false;
            dgvAsignaturas.Size = new Size(541, 293);
            dgvAsignaturas.TabIndex = 48;
            dgvAsignaturas.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvAsignaturas.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvAsignaturas.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvAsignaturas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvAsignaturas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvAsignaturas.ThemeStyle.BackColor = Color.FromArgb(27, 57, 106);
            dgvAsignaturas.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvAsignaturas.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvAsignaturas.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvAsignaturas.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvAsignaturas.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvAsignaturas.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvAsignaturas.ThemeStyle.HeaderStyle.Height = 25;
            dgvAsignaturas.ThemeStyle.ReadOnly = true;
            dgvAsignaturas.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvAsignaturas.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAsignaturas.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvAsignaturas.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvAsignaturas.ThemeStyle.RowsStyle.Height = 25;
            dgvAsignaturas.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvAsignaturas.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(360, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(202, 47);
            lblTitulo.TabIndex = 50;
            lblTitulo.Text = "Asignaturas";
            // 
            // FormAsignaturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 57, 106);
            ClientSize = new Size(931, 559);
            Controls.Add(lblTitulo);
            Controls.Add(dgvAsignaturas);
            Controls.Add(pnlBotonActualizar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(lblTipo);
            Controls.Add(lblAsignatura);
            Controls.Add(cmbTipo);
            Controls.Add(txtAsignatura);
            Name = "FormAsignaturas";
            Text = "FormAsignaturas";
            pnlBotonActualizar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAsignaturas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAsignatura;
        private ComboBox cmbTipo;
        private Label lblAsignatura;
        private Label lblTipo;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnGuardar;
        private Panel pnlBotonActualizar;
        private Button btnActualizar;
        private Button btnEditar;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAsignaturas;
        private Label lblTitulo;
    }
}