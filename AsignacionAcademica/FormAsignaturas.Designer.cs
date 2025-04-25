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
            txtAsignatura = new TextBox();
            cmbTipo = new ComboBox();
            dgvAsignaturas = new DataGridView();
            lblAsignatura = new Label();
            lblTipo = new Label();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            pnlBotonActualizar = new Panel();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAsignaturas).BeginInit();
            pnlBotonActualizar.SuspendLayout();
            SuspendLayout();
            // 
            // txtAsignatura
            // 
            txtAsignatura.Location = new Point(23, 68);
            txtAsignatura.Name = "txtAsignatura";
            txtAsignatura.Size = new Size(159, 23);
            txtAsignatura.TabIndex = 2;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Teorica", "Practica", "Mixta" });
            cmbTipo.Location = new Point(23, 126);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(159, 23);
            cmbTipo.TabIndex = 5;
            // 
            // dgvAsignaturas
            // 
            dgvAsignaturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsignaturas.Location = new Point(361, 50);
            dgvAsignaturas.Name = "dgvAsignaturas";
            dgvAsignaturas.Size = new Size(558, 194);
            dgvAsignaturas.TabIndex = 6;
            // 
            // lblAsignatura
            // 
            lblAsignatura.AutoSize = true;
            lblAsignatura.Location = new Point(23, 50);
            lblAsignatura.Name = "lblAsignatura";
            lblAsignatura.Size = new Size(64, 15);
            lblAsignatura.TabIndex = 16;
            lblAsignatura.Text = "Asignatura";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(23, 108);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(31, 15);
            lblTipo.TabIndex = 19;
            lblTipo.Text = "Tipo";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(232, 155);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 23;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(232, 126);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 22;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(232, 97);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 21;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(232, 68);
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
            pnlBotonActualizar.Location = new Point(228, 68);
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
            // FormAsignaturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 559);
            Controls.Add(pnlBotonActualizar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(lblTipo);
            Controls.Add(lblAsignatura);
            Controls.Add(dgvAsignaturas);
            Controls.Add(cmbTipo);
            Controls.Add(txtAsignatura);
            Name = "FormAsignaturas";
            Text = "FormAsignaturas";
            ((System.ComponentModel.ISupportInitialize)dgvAsignaturas).EndInit();
            pnlBotonActualizar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAsignatura;
        private ComboBox cmbTipo;
        private DataGridView dgvAsignaturas;
        private Label lblAsignatura;
        private Label lblTipo;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnGuardar;
        private Panel pnlBotonActualizar;
        private Button btnActualizar;
        private Button btnEditar;
    }
}