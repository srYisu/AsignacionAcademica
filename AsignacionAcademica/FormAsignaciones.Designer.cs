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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            lblGrupo = new Label();
            lblProfesor = new Label();
            lblAula = new Label();
            lblAsignatura = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            comboBox5 = new ComboBox();
            dgvClases = new DataGridView();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnGuardar = new Button();
            lblHoraInicio = new Label();
            lblHoraFin = new Label();
            lblDias = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClases).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(27, 61);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(170, 23);
            comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(27, 125);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(170, 23);
            comboBox2.TabIndex = 1;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(27, 190);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(170, 23);
            comboBox3.TabIndex = 2;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(27, 257);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(170, 23);
            comboBox4.TabIndex = 3;
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(27, 321);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(216, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(27, 388);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(216, 23);
            dateTimePicker2.TabIndex = 9;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(27, 453);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(170, 23);
            comboBox5.TabIndex = 10;
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
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(230, 118);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 20;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(230, 89);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 19;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(230, 60);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
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
            // FormAsignaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 559);
            Controls.Add(lblDias);
            Controls.Add(lblHoraFin);
            Controls.Add(lblHoraInicio);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnGuardar);
            Controls.Add(dgvClases);
            Controls.Add(comboBox5);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblAsignatura);
            Controls.Add(lblAula);
            Controls.Add(lblProfesor);
            Controls.Add(lblGrupo);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Name = "FormAsignaciones";
            Text = "FormAsignaciones";
            ((System.ComponentModel.ISupportInitialize)dgvClases).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Label lblGrupo;
        private Label lblProfesor;
        private Label lblAula;
        private Label lblAsignatura;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private ComboBox comboBox5;
        private DataGridView dgvClases;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnGuardar;
        private Label lblHoraInicio;
        private Label lblHoraFin;
        private Label lblDias;
    }
}