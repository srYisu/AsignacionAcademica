namespace AsignacionAcademica
{
    partial class FormAsignaciones
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
            cmbGrupo = new ComboBox();
            cmbProfesor = new ComboBox();
            cmbAula = new ComboBox();
            cmbAsignatura = new ComboBox();
            lblGrupo = new Label();
            lblProfesor = new Label();
            lblAula = new Label();
            lblAsignatura = new Label();
            dtpHoraInicio = new DateTimePicker();
            dtpHoraFin = new DateTimePicker();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            lblHoraInicio = new Label();
            lblHoraFin = new Label();
            lblDias = new Label();
            pnlBotonActualizar = new Panel();
            btnActualizar = new Button();
            cmDia = new ComboBox();
            dgvClases = new Guna.UI2.WinForms.Guna2DataGridView();
            lblTitulo = new Label();
            pnlBotonActualizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClases).BeginInit();
            SuspendLayout();
            // 
            // cmbGrupo
            // 
            cmbGrupo.FormattingEnabled = true;
            cmbGrupo.Location = new Point(27, 89);
            cmbGrupo.Name = "cmbGrupo";
            cmbGrupo.Size = new Size(170, 23);
            cmbGrupo.TabIndex = 0;
            // 
            // cmbProfesor
            // 
            cmbProfesor.FormattingEnabled = true;
            cmbProfesor.Location = new Point(27, 153);
            cmbProfesor.Name = "cmbProfesor";
            cmbProfesor.Size = new Size(170, 23);
            cmbProfesor.TabIndex = 1;
            // 
            // cmbAula
            // 
            cmbAula.FormattingEnabled = true;
            cmbAula.Location = new Point(27, 218);
            cmbAula.Name = "cmbAula";
            cmbAula.Size = new Size(170, 23);
            cmbAula.TabIndex = 2;
            // 
            // cmbAsignatura
            // 
            cmbAsignatura.FormattingEnabled = true;
            cmbAsignatura.Location = new Point(27, 285);
            cmbAsignatura.Name = "cmbAsignatura";
            cmbAsignatura.Size = new Size(170, 23);
            cmbAsignatura.TabIndex = 3;
            // 
            // lblGrupo
            // 
            lblGrupo.AutoSize = true;
            lblGrupo.ForeColor = Color.White;
            lblGrupo.Location = new Point(27, 71);
            lblGrupo.Name = "lblGrupo";
            lblGrupo.Size = new Size(40, 15);
            lblGrupo.TabIndex = 4;
            lblGrupo.Text = "Grupo";
            // 
            // lblProfesor
            // 
            lblProfesor.AutoSize = true;
            lblProfesor.ForeColor = Color.White;
            lblProfesor.Location = new Point(27, 135);
            lblProfesor.Name = "lblProfesor";
            lblProfesor.Size = new Size(51, 15);
            lblProfesor.TabIndex = 5;
            lblProfesor.Text = "Profesor";
            // 
            // lblAula
            // 
            lblAula.AutoSize = true;
            lblAula.ForeColor = Color.White;
            lblAula.Location = new Point(27, 200);
            lblAula.Name = "lblAula";
            lblAula.Size = new Size(31, 15);
            lblAula.TabIndex = 6;
            lblAula.Text = "Aula";
            // 
            // lblAsignatura
            // 
            lblAsignatura.AutoSize = true;
            lblAsignatura.ForeColor = Color.White;
            lblAsignatura.Location = new Point(27, 267);
            lblAsignatura.Name = "lblAsignatura";
            lblAsignatura.Size = new Size(64, 15);
            lblAsignatura.TabIndex = 7;
            lblAsignatura.Text = "Asignatura";
            // 
            // dtpHoraInicio
            // 
            dtpHoraInicio.Location = new Point(27, 349);
            dtpHoraInicio.Name = "dtpHoraInicio";
            dtpHoraInicio.Size = new Size(216, 23);
            dtpHoraInicio.TabIndex = 8;
            // 
            // dtpHoraFin
            // 
            dtpHoraFin.Location = new Point(27, 416);
            dtpHoraFin.Name = "dtpHoraFin";
            dtpHoraFin.Size = new Size(216, 23);
            dtpHoraFin.TabIndex = 9;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(230, 175);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 21;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(230, 146);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 20;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(230, 117);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 19;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(230, 88);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblHoraInicio
            // 
            lblHoraInicio.AutoSize = true;
            lblHoraInicio.ForeColor = Color.White;
            lblHoraInicio.Location = new Point(27, 331);
            lblHoraInicio.Name = "lblHoraInicio";
            lblHoraInicio.Size = new Size(81, 15);
            lblHoraInicio.TabIndex = 22;
            lblHoraInicio.Text = "Hora de inicio";
            // 
            // lblHoraFin
            // 
            lblHoraFin.AutoSize = true;
            lblHoraFin.ForeColor = Color.White;
            lblHoraFin.Location = new Point(27, 398);
            lblHoraFin.Name = "lblHoraFin";
            lblHoraFin.Size = new Size(112, 15);
            lblHoraFin.TabIndex = 23;
            lblHoraFin.Text = "Hora de finalización";
            // 
            // lblDias
            // 
            lblDias.AutoSize = true;
            lblDias.ForeColor = Color.White;
            lblDias.Location = new Point(27, 463);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(24, 15);
            lblDias.TabIndex = 24;
            lblDias.Text = "Dia";
            // 
            // pnlBotonActualizar
            // 
            pnlBotonActualizar.Controls.Add(btnActualizar);
            pnlBotonActualizar.Location = new Point(227, 86);
            pnlBotonActualizar.Name = "pnlBotonActualizar";
            pnlBotonActualizar.Size = new Size(78, 27);
            pnlBotonActualizar.TabIndex = 46;
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
            // cmDia
            // 
            cmDia.FormattingEnabled = true;
            cmDia.Location = new Point(27, 481);
            cmDia.Name = "cmDia";
            cmDia.Size = new Size(170, 23);
            cmDia.TabIndex = 52;
            // 
            // dgvClases
            // 
            dgvClases.AllowUserToAddRows = false;
            dgvClases.AllowUserToDeleteRows = false;
            dgvClases.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(182, 205, 235);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgvClases.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvClases.BackgroundColor = Color.FromArgb(27, 57, 106);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(27, 57, 160);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(27, 57, 160);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvClases.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvClases.ColumnHeadersHeight = 25;
            dgvClases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(182, 205, 235);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvClases.DefaultCellStyle = dataGridViewCellStyle3;
            dgvClases.GridColor = Color.FromArgb(231, 229, 255);
            dgvClases.Location = new Point(378, 86);
            dgvClases.Name = "dgvClases";
            dgvClases.ReadOnly = true;
            dgvClases.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvClases.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvClases.RowHeadersVisible = false;
            dgvClases.Size = new Size(541, 293);
            dgvClases.TabIndex = 53;
            dgvClases.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvClases.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvClases.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvClases.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvClases.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvClases.ThemeStyle.BackColor = Color.FromArgb(27, 57, 106);
            dgvClases.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvClases.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvClases.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvClases.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvClases.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvClases.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvClases.ThemeStyle.HeaderStyle.Height = 25;
            dgvClases.ThemeStyle.ReadOnly = true;
            dgvClases.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvClases.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvClases.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvClases.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvClases.ThemeStyle.RowsStyle.Height = 25;
            dgvClases.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvClases.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvClases.CellContentClick += dgvClases_CellContentClick;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(378, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(116, 47);
            lblTitulo.TabIndex = 54;
            lblTitulo.Text = "Clases";
            // 
            // FormAsignaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 57, 106);
            ClientSize = new Size(931, 559);
            Controls.Add(lblTitulo);
            Controls.Add(dgvClases);
            Controls.Add(cmDia);
            Controls.Add(pnlBotonActualizar);
            Controls.Add(lblDias);
            Controls.Add(lblHoraFin);
            Controls.Add(lblHoraInicio);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(dtpHoraFin);
            Controls.Add(dtpHoraInicio);
            Controls.Add(lblAsignatura);
            Controls.Add(lblAula);
            Controls.Add(lblProfesor);
            Controls.Add(lblGrupo);
            Controls.Add(cmbAsignatura);
            Controls.Add(cmbAula);
            Controls.Add(cmbProfesor);
            Controls.Add(cmbGrupo);
            Name = "FormAsignaciones";
            Text = "FormAsignaciones";
            pnlBotonActualizar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClases).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbGrupo;
        private ComboBox cmbProfesor;
        private ComboBox cmbAula;
        private ComboBox cmbAsignatura;
        private Label lblGrupo;
        private Label lblProfesor;
        private Label lblAula;
        private Label lblAsignatura;
        private DateTimePicker dtpHoraInicio;
        private DateTimePicker dtpHoraFin;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnGuardar;
        private Label lblHoraInicio;
        private Label lblHoraFin;
        private Label lblDias;
        private Panel pnlBotonActualizar;
        private Button btnActualizar;
        private ComboBox cmDia;
        private Guna.UI2.WinForms.Guna2DataGridView dgvClases;
        private Label lblTitulo;
    }
}