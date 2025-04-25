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
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblEspecialidad = new Label();
            txtEspecialidad = new TextBox();
            cboxDisponible = new CheckBox();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvProfesores = new DataGridView();
            txtApellidoMaterno = new TextBox();
            lblApellidoMaterno = new Label();
            txtApellidoPaterno = new TextBox();
            lblApellidoPaterno = new Label();
            lblDisponibilidad = new Label();
            pnlBotonActualizar = new Panel();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProfesores).BeginInit();
            pnlBotonActualizar.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(32, 32);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre(s)";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(32, 50);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(159, 23);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += textBox1_TextChanged;
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Location = new Point(32, 234);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(65, 15);
            lblEspecialidad.TabIndex = 2;
            lblEspecialidad.Text = "Especialida";
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Location = new Point(32, 252);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(159, 23);
            txtEspecialidad.TabIndex = 3;
            // 
            // cboxDisponible
            // 
            cboxDisponible.AutoSize = true;
            cboxDisponible.Location = new Point(32, 313);
            cboxDisponible.Name = "cboxDisponible";
            cboxDisponible.Size = new Size(82, 19);
            cboxDisponible.TabIndex = 7;
            cboxDisponible.Text = "Disponible";
            cboxDisponible.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(250, 49);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(250, 78);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(250, 107);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += button3_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(250, 136);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // dgvProfesores
            // 
            dgvProfesores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProfesores.Location = new Point(350, 32);
            dgvProfesores.Name = "dgvProfesores";
            dgvProfesores.Size = new Size(569, 273);
            dgvProfesores.TabIndex = 12;
            // 
            // txtApellidoMaterno
            // 
            txtApellidoMaterno.Location = new Point(32, 183);
            txtApellidoMaterno.Name = "txtApellidoMaterno";
            txtApellidoMaterno.Size = new Size(159, 23);
            txtApellidoMaterno.TabIndex = 17;
            // 
            // lblApellidoMaterno
            // 
            lblApellidoMaterno.AutoSize = true;
            lblApellidoMaterno.Location = new Point(32, 165);
            lblApellidoMaterno.Name = "lblApellidoMaterno";
            lblApellidoMaterno.Size = new Size(99, 15);
            lblApellidoMaterno.TabIndex = 16;
            lblApellidoMaterno.Text = "Apellido Materno";
            // 
            // txtApellidoPaterno
            // 
            txtApellidoPaterno.Location = new Point(32, 115);
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoPaterno.Size = new Size(159, 23);
            txtApellidoPaterno.TabIndex = 15;
            // 
            // lblApellidoPaterno
            // 
            lblApellidoPaterno.AutoSize = true;
            lblApellidoPaterno.Location = new Point(32, 97);
            lblApellidoPaterno.Name = "lblApellidoPaterno";
            lblApellidoPaterno.Size = new Size(95, 15);
            lblApellidoPaterno.TabIndex = 14;
            lblApellidoPaterno.Text = "Apellido paterno";
            // 
            // lblDisponibilidad
            // 
            lblDisponibilidad.AutoSize = true;
            lblDisponibilidad.Location = new Point(35, 290);
            lblDisponibilidad.Name = "lblDisponibilidad";
            lblDisponibilidad.Size = new Size(83, 15);
            lblDisponibilidad.TabIndex = 18;
            lblDisponibilidad.Text = "Disponibilidad";
            lblDisponibilidad.Click += label1_Click;
            // 
            // pnlBotonActualizar
            // 
            pnlBotonActualizar.Controls.Add(btnActualizar);
            pnlBotonActualizar.Location = new Point(246, 46);
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
            // FormProfesores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 559);
            Controls.Add(pnlBotonActualizar);
            Controls.Add(lblDisponibilidad);
            Controls.Add(txtApellidoMaterno);
            Controls.Add(lblApellidoMaterno);
            Controls.Add(txtApellidoPaterno);
            Controls.Add(lblApellidoPaterno);
            Controls.Add(dgvProfesores);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(cboxDisponible);
            Controls.Add(txtEspecialidad);
            Controls.Add(lblEspecialidad);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "FormProfesores";
            Text = "FormProfesores";
            Load += FormProfesores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProfesores).EndInit();
            pnlBotonActualizar.ResumeLayout(false);
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
        private CheckBox cboxDisponible;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DataGridView dgvProfesores;
        private TextBox txtApellidoMaterno;
        private Label lblApellidoMaterno;
        private TextBox txtApellidoPaterno;
        private Label lblApellidoPaterno;
        private Label lblDisponibilidad;
        private Panel pnlBotonActualizar;
        private Button btnActualizar;
    }
}