namespace AsignacionAcademica
{
    partial class FormProfesores
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblEspecialidad = new Label();
            txtEspecialidad = new TextBox();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            txtApellidoMaterno = new TextBox();
            lblApellidoMaterno = new Label();
            txtApellidoPaterno = new TextBox();
            lblApellidoPaterno = new Label();
            pnlBotonActualizar = new Panel();
            btnActualizar = new Button();
            dgvProfesores = new Guna.UI2.WinForms.Guna2DataGridView();
            lblTitulo = new Label();
            pnlBotonActualizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProfesores).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(32, 71);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre(s)";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(32, 89);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(159, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.ForeColor = Color.White;
            lblEspecialidad.Location = new Point(32, 273);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(72, 15);
            lblEspecialidad.TabIndex = 2;
            lblEspecialidad.Text = "Especialidad";
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Location = new Point(32, 291);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(159, 23);
            txtEspecialidad.TabIndex = 3;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(250, 88);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(250, 117);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(250, 146);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
;            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(250, 175);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // txtApellidoMaterno
            // 
            txtApellidoMaterno.Location = new Point(32, 222);
            txtApellidoMaterno.Name = "txtApellidoMaterno";
            txtApellidoMaterno.Size = new Size(159, 23);
            txtApellidoMaterno.TabIndex = 17;
            // 
            // lblApellidoMaterno
            // 
            lblApellidoMaterno.AutoSize = true;
            lblApellidoMaterno.ForeColor = Color.White;
            lblApellidoMaterno.Location = new Point(32, 204);
            lblApellidoMaterno.Name = "lblApellidoMaterno";
            lblApellidoMaterno.Size = new Size(99, 15);
            lblApellidoMaterno.TabIndex = 16;
            lblApellidoMaterno.Text = "Apellido Materno";
            // 
            // txtApellidoPaterno
            // 
            txtApellidoPaterno.Location = new Point(32, 154);
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoPaterno.Size = new Size(159, 23);
            txtApellidoPaterno.TabIndex = 15;
            // 
            // lblApellidoPaterno
            // 
            lblApellidoPaterno.AutoSize = true;
            lblApellidoPaterno.ForeColor = Color.White;
            lblApellidoPaterno.Location = new Point(32, 136);
            lblApellidoPaterno.Name = "lblApellidoPaterno";
            lblApellidoPaterno.Size = new Size(95, 15);
            lblApellidoPaterno.TabIndex = 14;
            lblApellidoPaterno.Text = "Apellido paterno";
            // 
            // pnlBotonActualizar
            // 
            pnlBotonActualizar.Controls.Add(btnActualizar);
            pnlBotonActualizar.Location = new Point(246, 85);
            pnlBotonActualizar.Name = "pnlBotonActualizar";
            pnlBotonActualizar.Size = new Size(79, 30);
            pnlBotonActualizar.TabIndex = 19;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(3, 3);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 20;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click_1;
            // 
            // dgvProfesores
            // 
            dgvProfesores.AllowUserToAddRows = false;
            dgvProfesores.AllowUserToDeleteRows = false;
            dgvProfesores.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(182, 205, 235);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgvProfesores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProfesores.BackgroundColor = Color.FromArgb(27, 57, 106);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(27, 57, 160);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(27, 57, 160);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProfesores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProfesores.ColumnHeadersHeight = 25;
            dgvProfesores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(182, 205, 235);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvProfesores.DefaultCellStyle = dataGridViewCellStyle3;
            dgvProfesores.GridColor = Color.FromArgb(231, 229, 255);
            dgvProfesores.Location = new Point(378, 89);
            dgvProfesores.Name = "dgvProfesores";
            dgvProfesores.ReadOnly = true;
            dgvProfesores.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvProfesores.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvProfesores.RowHeadersVisible = false;
            dgvProfesores.Size = new Size(541, 293);
            dgvProfesores.TabIndex = 20;
            dgvProfesores.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvProfesores.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvProfesores.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvProfesores.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvProfesores.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvProfesores.ThemeStyle.BackColor = Color.FromArgb(27, 57, 106);
            dgvProfesores.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvProfesores.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvProfesores.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProfesores.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvProfesores.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvProfesores.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvProfesores.ThemeStyle.HeaderStyle.Height = 25;
            dgvProfesores.ThemeStyle.ReadOnly = true;
            dgvProfesores.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvProfesores.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProfesores.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvProfesores.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvProfesores.ThemeStyle.RowsStyle.Height = 25;
            dgvProfesores.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvProfesores.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(378, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(183, 47);
            lblTitulo.TabIndex = 21;
            lblTitulo.Text = "Profesores";
            // 
            // FormProfesores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 57, 106);
            ClientSize = new Size(931, 559);
            Controls.Add(lblTitulo);
            Controls.Add(dgvProfesores);
            Controls.Add(pnlBotonActualizar);
            Controls.Add(txtApellidoMaterno);
            Controls.Add(lblApellidoMaterno);
            Controls.Add(txtApellidoPaterno);
            Controls.Add(lblApellidoPaterno);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(txtEspecialidad);
            Controls.Add(lblEspecialidad);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "FormProfesores";
            Text = "FormProfesores";
            pnlBotonActualizar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProfesores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblEspecialidad;
        private TextBox txtEspecialidad;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private CheckedListBox checkedListBox1;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private TextBox txtApellidoMaterno;
        private Label lblApellidoMaterno;
        private TextBox txtApellidoPaterno;
        private Label lblApellidoPaterno;
        private Panel pnlBotonActualizar;
        private Button btnActualizar;
        private Guna.UI2.WinForms.Guna2DataGridView dgvProfesores;
        private Label lblTitulo;
    }
}