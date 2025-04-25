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
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvAulas = new DataGridView();
            lblUbicacion = new Label();
            lblCapacidad = new Label();
            lblNombreAula = new Label();
            txtUbicacion = new TextBox();
            txtCapacidad = new TextBox();
            txtNombreAula = new TextBox();
            pnlBotonActualizar = new Panel();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAulas).BeginInit();
            pnlBotonActualizar.SuspendLayout();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(220, 66);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(220, 95);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(220, 124);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(220, 153);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvAulas
            // 
            dgvAulas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAulas.Location = new Point(330, 49);
            dgvAulas.Name = "dgvAulas";
            dgvAulas.Size = new Size(589, 207);
            dgvAulas.TabIndex = 10;
            // 
            // lblUbicacion
            // 
            lblUbicacion.AutoSize = true;
            lblUbicacion.Location = new Point(22, 181);
            lblUbicacion.Name = "lblUbicacion";
            lblUbicacion.Size = new Size(60, 15);
            lblUbicacion.TabIndex = 24;
            lblUbicacion.Text = "Ubicación";
            // 
            // lblCapacidad
            // 
            lblCapacidad.AutoSize = true;
            lblCapacidad.Location = new Point(22, 114);
            lblCapacidad.Name = "lblCapacidad";
            lblCapacidad.Size = new Size(63, 15);
            lblCapacidad.TabIndex = 23;
            lblCapacidad.Text = "Capacidad";
            // 
            // lblNombreAula
            // 
            lblNombreAula.AutoSize = true;
            lblNombreAula.Location = new Point(22, 49);
            lblNombreAula.Name = "lblNombreAula";
            lblNombreAula.Size = new Size(95, 15);
            lblNombreAula.TabIndex = 22;
            lblNombreAula.Text = "Nombre del aula";
            // 
            // txtUbicacion
            // 
            txtUbicacion.Location = new Point(22, 199);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(159, 23);
            txtUbicacion.TabIndex = 21;
            // 
            // txtCapacidad
            // 
            txtCapacidad.Location = new Point(22, 132);
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.Size = new Size(159, 23);
            txtCapacidad.TabIndex = 20;
            // 
            // txtNombreAula
            // 
            txtNombreAula.Location = new Point(22, 67);
            txtNombreAula.Name = "txtNombreAula";
            txtNombreAula.Size = new Size(159, 23);
            txtNombreAula.TabIndex = 19;
            // 
            // pnlBotonActualizar
            // 
            pnlBotonActualizar.Controls.Add(btnActualizar);
            pnlBotonActualizar.Location = new Point(216, 63);
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
            // FormAulas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 559);
            Controls.Add(pnlBotonActualizar);
            Controls.Add(lblUbicacion);
            Controls.Add(lblCapacidad);
            Controls.Add(lblNombreAula);
            Controls.Add(txtUbicacion);
            Controls.Add(txtCapacidad);
            Controls.Add(txtNombreAula);
            Controls.Add(dgvAulas);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Name = "FormAulas";
            Text = "FormAulas";
            Load += FormAulas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAulas).EndInit();
            pnlBotonActualizar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DataGridView dgvAulas;
        private Label lblUbicacion;
        private Label lblCapacidad;
        private Label lblNombreAula;
        private TextBox txtUbicacion;
        private TextBox txtCapacidad;
        private TextBox txtNombreAula;
        private Panel pnlBotonActualizar;
        private Button btnActualizar;
    }
}