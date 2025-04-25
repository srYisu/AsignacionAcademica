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
            lblCarrera = new Label();
            lblNumAlumnos = new Label();
            lblGrupo = new Label();
            txtNumAlumnos = new TextBox();
            txtGrupo = new TextBox();
            dgvGrupos = new DataGridView();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            pnlBotonActualizar = new Panel();
            btnActualizar = new Button();
            cmbCarrera = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvGrupos).BeginInit();
            pnlBotonActualizar.SuspendLayout();
            SuspendLayout();
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.Location = new Point(30, 182);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(45, 15);
            lblCarrera.TabIndex = 37;
            lblCarrera.Text = "Carrera";
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
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(231, 125);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 43;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(231, 96);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 42;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(231, 67);
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
            pnlBotonActualizar.Location = new Point(228, 67);
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
            cmbCarrera.Location = new Point(30, 200);
            cmbCarrera.Name = "cmbCarrera";
            cmbCarrera.Size = new Size(159, 23);
            cmbCarrera.TabIndex = 46;
            // 
            // FormGrupos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 559);
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
            Controls.Add(dgvGrupos);
            Name = "FormGrupos";
            Text = "FormGrupos";
            Load += FormGrupos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGrupos).EndInit();
            pnlBotonActualizar.ResumeLayout(false);
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
        private DataGridView dgvGrupos;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnGuardar;
        private Panel pnlBotonActualizar;
        private Button btnActualizar;
        private ComboBox cmbCarrera;
    }
}