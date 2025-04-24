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
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvAulas = new DataGridView();
            lblUbicacion = new Label();
            lblCapacidad = new Label();
            lblNombreAula = new Label();
            txtUbicación = new TextBox();
            txtCapacidad = new TextBox();
            txtNombreAula = new TextBox();
            lblDisponibilidad = new Label();
            cboxDisponible = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvAulas).BeginInit();
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
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(220, 95);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 7;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(220, 124);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(220, 153);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
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
            // txtUbicación
            // 
            txtUbicación.Location = new Point(22, 199);
            txtUbicación.Name = "txtUbicación";
            txtUbicación.Size = new Size(159, 23);
            txtUbicación.TabIndex = 21;
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
            // lblDisponibilidad
            // 
            lblDisponibilidad.AutoSize = true;
            lblDisponibilidad.Location = new Point(25, 241);
            lblDisponibilidad.Name = "lblDisponibilidad";
            lblDisponibilidad.Size = new Size(83, 15);
            lblDisponibilidad.TabIndex = 29;
            lblDisponibilidad.Text = "Disponibilidad";
            // 
            // cboxDisponible
            // 
            cboxDisponible.AutoSize = true;
            cboxDisponible.Location = new Point(22, 264);
            cboxDisponible.Name = "cboxDisponible";
            cboxDisponible.Size = new Size(82, 19);
            cboxDisponible.TabIndex = 28;
            cboxDisponible.Text = "Disponible";
            cboxDisponible.UseVisualStyleBackColor = true;
            // 
            // FormAulas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 559);
            Controls.Add(lblDisponibilidad);
            Controls.Add(cboxDisponible);
            Controls.Add(lblUbicacion);
            Controls.Add(lblCapacidad);
            Controls.Add(lblNombreAula);
            Controls.Add(txtUbicación);
            Controls.Add(txtCapacidad);
            Controls.Add(txtNombreAula);
            Controls.Add(dgvAulas);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnGuardar);
            Name = "FormAulas";
            Text = "FormAulas";
            Load += FormAulas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAulas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnGuardar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DataGridView dgvAulas;
        private Label lblUbicacion;
        private Label lblCapacidad;
        private Label lblNombreAula;
        private TextBox txtUbicación;
        private TextBox txtCapacidad;
        private TextBox txtNombreAula;
        private Label lblDisponibilidad;
        private CheckBox cboxDisponible;
    }
}