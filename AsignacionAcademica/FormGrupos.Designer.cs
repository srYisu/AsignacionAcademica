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
            lblCurso = new Label();
            lblNumAlumnos = new Label();
            lblGrupo = new Label();
            txtCurso = new TextBox();
            txtNumAlumnos = new TextBox();
            txtGrupo = new TextBox();
            dgvGrupos = new DataGridView();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGrupos).BeginInit();
            SuspendLayout();
            // 
            // lblCurso
            // 
            lblCurso.AutoSize = true;
            lblCurso.Location = new Point(30, 182);
            lblCurso.Name = "lblCurso";
            lblCurso.Size = new Size(38, 15);
            lblCurso.TabIndex = 37;
            lblCurso.Text = "Curso";
            // 
            // lblNumAlumnos
            // 
            lblNumAlumnos.AutoSize = true;
            lblNumAlumnos.Location = new Point(30, 115);
            lblNumAlumnos.Name = "lblNumAlumnos";
            lblNumAlumnos.Size = new Size(116, 15);
            lblNumAlumnos.TabIndex = 36;
            lblNumAlumnos.Text = "Numero de alumnos";
            // 
            // lblGrupo
            // 
            lblGrupo.AutoSize = true;
            lblGrupo.Location = new Point(30, 50);
            lblGrupo.Name = "lblGrupo";
            lblGrupo.Size = new Size(40, 15);
            lblGrupo.TabIndex = 35;
            lblGrupo.Text = "Grupo";
            lblGrupo.Click += label1_Click;
            // 
            // txtCurso
            // 
            txtCurso.Location = new Point(30, 200);
            txtCurso.Name = "txtCurso";
            txtCurso.Size = new Size(159, 23);
            txtCurso.TabIndex = 34;
            // 
            // txtNumAlumnos
            // 
            txtNumAlumnos.Location = new Point(30, 133);
            txtNumAlumnos.Name = "txtNumAlumnos";
            txtNumAlumnos.Size = new Size(159, 23);
            txtNumAlumnos.TabIndex = 33;
            // 
            // txtGrupo
            // 
            txtGrupo.Location = new Point(30, 68);
            txtGrupo.Name = "txtGrupo";
            txtGrupo.Size = new Size(159, 23);
            txtGrupo.TabIndex = 32;
            // 
            // dgvGrupos
            // 
            dgvGrupos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrupos.Location = new Point(354, 47);
            dgvGrupos.Name = "dgvGrupos";
            dgvGrupos.Size = new Size(565, 290);
            dgvGrupos.TabIndex = 31;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(231, 154);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 44;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(231, 125);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 43;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(231, 96);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 42;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(231, 67);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 41;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // FormGrupos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 559);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnGuardar);
            Controls.Add(lblCurso);
            Controls.Add(lblNumAlumnos);
            Controls.Add(lblGrupo);
            Controls.Add(txtCurso);
            Controls.Add(txtNumAlumnos);
            Controls.Add(txtGrupo);
            Controls.Add(dgvGrupos);
            Name = "FormGrupos";
            Text = "FormGrupos";
            Load += FormGrupos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGrupos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox textBox4;
        private Label lblCurso;
        private Label lblNumAlumnos;
        private Label lblGrupo;
        private TextBox txtCurso;
        private TextBox txtNumAlumnos;
        private TextBox txtGrupo;
        private DataGridView dgvGrupos;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnGuardar;
    }
}