namespace AsignacionAcademica
{
    partial class FormAulas
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
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            lblUbicacion = new Label();
            lblCapacidad = new Label();
            lblNombreAula = new Label();
            txtUbicacion = new TextBox();
            txtCapacidad = new TextBox();
            txtNombreAula = new TextBox();
            pnlBotonActualizar = new Panel();
            btnActualizar = new Button();
            dgvAulas = new Guna.UI2.WinForms.Guna2DataGridView();
            lblTitulo = new Label();
            pnlBotonActualizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAulas).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(220, 88);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(220, 117);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(220, 146);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(220, 175);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblUbicacion
            // 
            lblUbicacion.AutoSize = true;
            lblUbicacion.ForeColor = Color.White;
            lblUbicacion.Location = new Point(22, 203);
            lblUbicacion.Name = "lblUbicacion";
            lblUbicacion.Size = new Size(60, 15);
            lblUbicacion.TabIndex = 24;
            lblUbicacion.Text = "Ubicación";
            // 
            // lblCapacidad
            // 
            lblCapacidad.AutoSize = true;
            lblCapacidad.ForeColor = Color.White;
            lblCapacidad.Location = new Point(22, 136);
            lblCapacidad.Name = "lblCapacidad";
            lblCapacidad.Size = new Size(63, 15);
            lblCapacidad.TabIndex = 23;
            lblCapacidad.Text = "Capacidad";
            // 
            // lblNombreAula
            // 
            lblNombreAula.AutoSize = true;
            lblNombreAula.ForeColor = Color.White;
            lblNombreAula.Location = new Point(22, 71);
            lblNombreAula.Name = "lblNombreAula";
            lblNombreAula.Size = new Size(95, 15);
            lblNombreAula.TabIndex = 22;
            lblNombreAula.Text = "Nombre del aula";
            // 
            // txtUbicacion
            // 
            txtUbicacion.Location = new Point(22, 221);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(159, 23);
            txtUbicacion.TabIndex = 21;
            // 
            // txtCapacidad
            // 
            txtCapacidad.Location = new Point(22, 154);
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.Size = new Size(159, 23);
            txtCapacidad.TabIndex = 20;
            // 
            // txtNombreAula
            // 
            txtNombreAula.Location = new Point(22, 89);
            txtNombreAula.Name = "txtNombreAula";
            txtNombreAula.Size = new Size(159, 23);
            txtNombreAula.TabIndex = 19;
            // 
            // pnlBotonActualizar
            // 
            pnlBotonActualizar.Controls.Add(btnActualizar);
            pnlBotonActualizar.Location = new Point(216, 85);
            pnlBotonActualizar.Name = "pnlBotonActualizar";
            pnlBotonActualizar.Size = new Size(79, 30);
            pnlBotonActualizar.TabIndex = 25;
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
            // dgvAulas
            // 
            dgvAulas.AllowUserToAddRows = false;
            dgvAulas.AllowUserToDeleteRows = false;
            dgvAulas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(182, 205, 235);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgvAulas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAulas.BackgroundColor = Color.FromArgb(27, 57, 106);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(27, 57, 160);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(27, 57, 160);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAulas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAulas.ColumnHeadersHeight = 25;
            dgvAulas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(182, 205, 235);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvAulas.DefaultCellStyle = dataGridViewCellStyle3;
            dgvAulas.GridColor = Color.FromArgb(231, 229, 255);
            dgvAulas.Location = new Point(378, 89);
            dgvAulas.Name = "dgvAulas";
            dgvAulas.ReadOnly = true;
            dgvAulas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvAulas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvAulas.RowHeadersVisible = false;
            dgvAulas.Size = new Size(541, 293);
            dgvAulas.TabIndex = 48;
            dgvAulas.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvAulas.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvAulas.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvAulas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvAulas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvAulas.ThemeStyle.BackColor = Color.FromArgb(27, 57, 106);
            dgvAulas.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvAulas.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvAulas.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvAulas.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvAulas.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvAulas.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvAulas.ThemeStyle.HeaderStyle.Height = 25;
            dgvAulas.ThemeStyle.ReadOnly = true;
            dgvAulas.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvAulas.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAulas.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvAulas.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvAulas.ThemeStyle.RowsStyle.Height = 25;
            dgvAulas.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvAulas.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(378, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(104, 47);
            lblTitulo.TabIndex = 49;
            lblTitulo.Text = "Aulas";
            // 
            // FormAulas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 57, 106);
            ClientSize = new Size(931, 559);
            Controls.Add(lblTitulo);
            Controls.Add(dgvAulas);
            Controls.Add(pnlBotonActualizar);
            Controls.Add(lblUbicacion);
            Controls.Add(lblCapacidad);
            Controls.Add(lblNombreAula);
            Controls.Add(txtUbicacion);
            Controls.Add(txtCapacidad);
            Controls.Add(txtNombreAula);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Name = "FormAulas";
            Text = "FormAulas";
            pnlBotonActualizar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAulas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Label lblUbicacion;
        private Label lblCapacidad;
        private Label lblNombreAula;
        private TextBox txtUbicacion;
        private TextBox txtCapacidad;
        private TextBox txtNombreAula;
        private Panel pnlBotonActualizar;
        private Button btnActualizar;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAulas;
        private Label lblTitulo;
    }
}