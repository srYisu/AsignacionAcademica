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
            dgvClases = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)dgvClases).BeginInit();
            pnlBotonActualizar.SuspendLayout();
            SuspendLayout();
            // 
            // cmbGrupo
            // 
            cmbGrupo.FormattingEnabled = true;
            cmbGrupo.Location = new Point(27, 61);
            cmbGrupo.Name = "cmbGrupo";
            cmbGrupo.Size = new Size(170, 23);
            cmbGrupo.TabIndex = 0;
            // 
            // cmbProfesor
            // 
            cmbProfesor.FormattingEnabled = true;
            cmbProfesor.Location = new Point(27, 125);
            cmbProfesor.Name = "cmbProfesor";
            cmbProfesor.Size = new Size(170, 23);
            cmbProfesor.TabIndex = 1;
            // 
            // cmbAula
            // 
            cmbAula.FormattingEnabled = true;
            cmbAula.Location = new Point(27, 190);
            cmbAula.Name = "cmbAula";
            cmbAula.Size = new Size(170, 23);
            cmbAula.TabIndex = 2;
            // 
            // cmbAsignatura
            // 
            cmbAsignatura.FormattingEnabled = true;
            cmbAsignatura.Location = new Point(27, 257);
            cmbAsignatura.Name = "cmbAsignatura";
            cmbAsignatura.Size = new Size(170, 23);
            cmbAsignatura.TabIndex = 3;
            // 
            // lblGrupo
            // 
            lblGrupo.AutoSize = true;
            lblGrupo.Location = new Point(27, 43);
            lblGrupo.Name = "lblGrupo";
            lblGrupo.Size = new Size(40, 15);
            lblGrupo.TabIndex = 4;
            lblGrupo.Text = "Grupo";
            // 
            // lblProfesor
            // 
            lblProfesor.AutoSize = true;
            lblProfesor.Location = new Point(27, 107);
            lblProfesor.Name = "lblProfesor";
            lblProfesor.Size = new Size(51, 15);
            lblProfesor.TabIndex = 5;
            lblProfesor.Text = "Profesor";
            // 
            // lblAula
            // 
            lblAula.AutoSize = true;
            lblAula.Location = new Point(27, 172);
            lblAula.Name = "lblAula";
            lblAula.Size = new Size(31, 15);
            lblAula.TabIndex = 6;
            lblAula.Text = "Aula";
            // 
            // lblAsignatura
            // 
            lblAsignatura.AutoSize = true;
            lblAsignatura.Location = new Point(27, 239);
            lblAsignatura.Name = "lblAsignatura";
            lblAsignatura.Size = new Size(64, 15);
            lblAsignatura.TabIndex = 7;
            lblAsignatura.Text = "Asignatura";
            // 
            // dtpHoraInicio
            // 
            dtpHoraInicio.Location = new Point(27, 321);
            dtpHoraInicio.Name = "dtpHoraInicio";
            dtpHoraInicio.Size = new Size(216, 23);
            dtpHoraInicio.TabIndex = 8;
            // 
            // dtpHoraFin
            // 
            dtpHoraFin.Location = new Point(27, 388);
            dtpHoraFin.Name = "dtpHoraFin";
            dtpHoraFin.Size = new Size(216, 23);
            dtpHoraFin.TabIndex = 9;
            // 
            // dgvClases
            // 
            dgvClases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClases.Location = new Point(372, 43);
            dgvClases.Name = "dgvClases";
            dgvClases.Size = new Size(547, 237);
            dgvClases.TabIndex = 16;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(230, 147);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 21;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(230, 118);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 20;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(230, 89);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 19;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(230, 60);
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
            lblHoraInicio.Location = new Point(27, 303);
            lblHoraInicio.Name = "lblHoraInicio";
            lblHoraInicio.Size = new Size(81, 15);
            lblHoraInicio.TabIndex = 22;
            lblHoraInicio.Text = "Hora de inicio";
            // 
            // lblHoraFin
            // 
            lblHoraFin.AutoSize = true;
            lblHoraFin.Location = new Point(27, 370);
            lblHoraFin.Name = "lblHoraFin";
            lblHoraFin.Size = new Size(112, 15);
            lblHoraFin.TabIndex = 23;
            lblHoraFin.Text = "Hora de finalización";
            // 
            // lblDias
            // 
            lblDias.AutoSize = true;
            lblDias.Location = new Point(27, 435);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(24, 15);
            lblDias.TabIndex = 24;
            lblDias.Text = "Dia";
            // 
            // pnlBotonActualizar
            // 
            pnlBotonActualizar.Controls.Add(btnActualizar);
            pnlBotonActualizar.Location = new Point(227, 58);
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
            cmDia.Location = new Point(27, 453);
            cmDia.Name = "cmDia";
            cmDia.Size = new Size(170, 23);
            cmDia.TabIndex = 52;
            // 
            // FormAsignaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 559);
            Controls.Add(cmDia);
            Controls.Add(pnlBotonActualizar);
            Controls.Add(lblDias);
            Controls.Add(lblHoraFin);
            Controls.Add(lblHoraInicio);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(dgvClases);
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
            ((System.ComponentModel.ISupportInitialize)dgvClases).EndInit();
            pnlBotonActualizar.ResumeLayout(false);
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
        private DataGridView dgvClases;
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
    }
}