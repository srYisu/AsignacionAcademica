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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            dgvAsignaturas = new DataGridView();
            lblAsignatura = new Label();
            txtDuracion = new Label();
            cmbTipo = new Label();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAsignaturas).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(159, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(23, 133);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(159, 23);
            textBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(23, 195);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(159, 23);
            comboBox1.TabIndex = 5;
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
            // txtDuracion
            // 
            txtDuracion.AutoSize = true;
            txtDuracion.Location = new Point(23, 115);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(55, 15);
            txtDuracion.TabIndex = 17;
            txtDuracion.Text = "Duracion";
            // 
            // cmbTipo
            // 
            cmbTipo.AutoSize = true;
            cmbTipo.Location = new Point(23, 177);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(31, 15);
            cmbTipo.TabIndex = 19;
            cmbTipo.Text = "Tipo";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(232, 155);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 23;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(232, 126);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 22;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(232, 97);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 21;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(232, 68);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 20;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // FormAsignaturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 559);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnGuardar);
            Controls.Add(cmbTipo);
            Controls.Add(txtDuracion);
            Controls.Add(lblAsignatura);
            Controls.Add(dgvAsignaturas);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "FormAsignaturas";
            Text = "FormAsignaturas";
            ((System.ComponentModel.ISupportInitialize)dgvAsignaturas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private DataGridView dgvAsignaturas;
        private Label lblAsignatura;
        private Label txtDuracion;
        private Label cmbTipo;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnGuardar;
    }
}