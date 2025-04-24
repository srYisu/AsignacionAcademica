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
            btnCerrar = new Button();
            pnlBase = new Panel();
            SuspendLayout();
            // 
            // btnProfesores
            // 
            btnProfesores.Location = new Point(12, 110);
            btnProfesores.Name = "btnProfesores";
            btnProfesores.Size = new Size(151, 57);
            btnProfesores.TabIndex = 0;
            btnProfesores.Text = "Profesores";
            btnProfesores.UseVisualStyleBackColor = true;
            btnProfesores.Click += btnProfesores_Click;
            // 
            // btnAulas
            // 
            btnAulas.Location = new Point(12, 183);
            btnAulas.Name = "btnAulas";
            btnAulas.Size = new Size(151, 57);
            btnAulas.TabIndex = 1;
            btnAulas.Text = "Aulas";
            btnAulas.UseVisualStyleBackColor = true;
            btnAulas.Click += btnAulas_Click;
            // 
            // btnAsignaturas
            // 
            btnAsignaturas.Location = new Point(12, 255);
            btnAsignaturas.Name = "btnAsignaturas";
            btnAsignaturas.Size = new Size(151, 57);
            btnAsignaturas.TabIndex = 2;
            btnAsignaturas.Text = "Asignaturas";
            btnAsignaturas.UseVisualStyleBackColor = true;
            btnAsignaturas.Click += btnAsignaturas_Click;
            // 
            // btnGrupos
            // 
            btnGrupos.Location = new Point(12, 330);
            btnGrupos.Name = "btnGrupos";
            btnGrupos.Size = new Size(151, 57);
            btnGrupos.TabIndex = 3;
            btnGrupos.Text = "Grupos";
            btnGrupos.UseVisualStyleBackColor = true;
            btnGrupos.Click += btnGrupos_Click;
            // 
            // btnAsignarClases
            // 
            btnAsignarClases.Location = new Point(12, 402);
            btnAsignarClases.Name = "btnAsignarClases";
            btnAsignarClases.Size = new Size(151, 57);
            btnAsignarClases.TabIndex = 4;
            btnAsignarClases.Text = "Asignar Clases";
            btnAsignarClases.UseVisualStyleBackColor = true;
            btnAsignarClases.Click += btnAsignarClases_Click;
            // 
            // btnConsultarAsignaciones
            // 
            btnConsultarAsignaciones.Location = new Point(12, 472);
            btnConsultarAsignaciones.Name = "btnConsultarAsignaciones";
            btnConsultarAsignaciones.Size = new Size(151, 57);
            btnConsultarAsignaciones.TabIndex = 5;
            btnConsultarAsignaciones.Text = "Consultar Asignaciones";
            btnConsultarAsignaciones.UseVisualStyleBackColor = true;
            btnConsultarAsignaciones.Click += btnConsultarAsignaciones_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(49, 535);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 6;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // pnlBase
            // 
            pnlBase.Location = new Point(191, 0);
            pnlBase.Name = "pnlBase";
            pnlBase.Size = new Size(947, 598);
            pnlBase.TabIndex = 7;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 597);
            Controls.Add(pnlBase);
            Controls.Add(btnCerrar);
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
        private Button btnCerrar;
        private Panel pnlBase;
    }
}