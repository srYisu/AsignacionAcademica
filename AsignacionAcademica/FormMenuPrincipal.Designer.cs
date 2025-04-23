namespace AsignacionAcademica
{
    partial class FormMenuPrincipal
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
            btnProfesores = new Button();
            btnAulas = new Button();
            btnAsignaturas = new Button();
            btnGrupos = new Button();
            btnAsignarClases = new Button();
            btnConsultarAsignaciones = new Button();
            SuspendLayout();
            // 
            // btnProfesores
            // 
            btnProfesores.Location = new Point(312, 149);
            btnProfesores.Name = "btnProfesores";
            btnProfesores.Size = new Size(151, 57);
            btnProfesores.TabIndex = 0;
            btnProfesores.Text = "Profesores";
            btnProfesores.UseVisualStyleBackColor = true;
            btnProfesores.Click += btnProfesores_Click;
            // 
            // btnAulas
            // 
            btnAulas.Location = new Point(521, 149);
            btnAulas.Name = "btnAulas";
            btnAulas.Size = new Size(151, 57);
            btnAulas.TabIndex = 1;
            btnAulas.Text = "Aulas";
            btnAulas.UseVisualStyleBackColor = true;
            btnAulas.Click += btnAulas_Click;
            // 
            // btnAsignaturas
            // 
            btnAsignaturas.Location = new Point(312, 238);
            btnAsignaturas.Name = "btnAsignaturas";
            btnAsignaturas.Size = new Size(151, 57);
            btnAsignaturas.TabIndex = 2;
            btnAsignaturas.Text = "Asignaturas";
            btnAsignaturas.UseVisualStyleBackColor = true;
            btnAsignaturas.Click += btnAsignaturas_Click;
            // 
            // btnGrupos
            // 
            btnGrupos.Location = new Point(521, 238);
            btnGrupos.Name = "btnGrupos";
            btnGrupos.Size = new Size(151, 57);
            btnGrupos.TabIndex = 3;
            btnGrupos.Text = "Grupos";
            btnGrupos.UseVisualStyleBackColor = true;
            btnGrupos.Click += btnGrupos_Click;
            // 
            // btnAsignarClases
            // 
            btnAsignarClases.Location = new Point(312, 330);
            btnAsignarClases.Name = "btnAsignarClases";
            btnAsignarClases.Size = new Size(151, 57);
            btnAsignarClases.TabIndex = 4;
            btnAsignarClases.Text = "Asignar Clases";
            btnAsignarClases.UseVisualStyleBackColor = true;
            btnAsignarClases.Click += btnAsignarClases_Click;
            // 
            // btnConsultarAsignaciones
            // 
            btnConsultarAsignaciones.Location = new Point(521, 330);
            btnConsultarAsignaciones.Name = "btnConsultarAsignaciones";
            btnConsultarAsignaciones.Size = new Size(151, 57);
            btnConsultarAsignaciones.TabIndex = 5;
            btnConsultarAsignaciones.Text = "Consultar Asignaciones";
            btnConsultarAsignaciones.UseVisualStyleBackColor = true;
            btnConsultarAsignaciones.Click += btnConsultarAsignaciones_Click;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(btnConsultarAsignaciones);
            Controls.Add(btnAsignarClases);
            Controls.Add(btnGrupos);
            Controls.Add(btnAsignaturas);
            Controls.Add(btnAulas);
            Controls.Add(btnProfesores);
            Name = "FormMenuPrincipal";
            Text = "FormMenuPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnProfesores;
        private Button btnAulas;
        private Button btnAsignaturas;
        private Button btnGrupos;
        private Button btnAsignarClases;
        private Button btnConsultarAsignaciones;
    }
}