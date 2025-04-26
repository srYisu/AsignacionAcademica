namespace AsignacionAcademica
{
    partial class FormConsultaAsignaciones
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
            lblFiltros = new Label();
            cmbFiltro = new ComboBox();
            btnBuscar = new Button();
            dgvConsulta = new DataGridView();
            rbtnGrupo = new RadioButton();
            rbtnAula = new RadioButton();
            rbtnProfesor = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(32, 49);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(0, 23);
            comboBox1.TabIndex = 0;
            // 
            // lblFiltros
            // 
            lblFiltros.AutoSize = true;
            lblFiltros.Location = new Point(23, 31);
            lblFiltros.Name = "lblFiltros";
            lblFiltros.Size = new Size(61, 15);
            lblFiltros.TabIndex = 6;
            lblFiltros.Text = "Filtrar por:";
            // 
            // cmbFiltro
            // 
            cmbFiltro.FormattingEnabled = true;
            cmbFiltro.Location = new Point(23, 161);
            cmbFiltro.Name = "cmbFiltro";
            cmbFiltro.Size = new Size(170, 23);
            cmbFiltro.TabIndex = 5;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(209, 160);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvConsulta
            // 
            dgvConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsulta.Location = new Point(331, 31);
            dgvConsulta.Name = "dgvConsulta";
            dgvConsulta.Size = new Size(588, 345);
            dgvConsulta.TabIndex = 8;
            // 
            // rbtnGrupo
            // 
            rbtnGrupo.AutoSize = true;
            rbtnGrupo.Location = new Point(24, 61);
            rbtnGrupo.Name = "rbtnGrupo";
            rbtnGrupo.Size = new Size(58, 19);
            rbtnGrupo.TabIndex = 9;
            rbtnGrupo.TabStop = true;
            rbtnGrupo.Text = "Grupo";
            rbtnGrupo.UseVisualStyleBackColor = true;
            rbtnGrupo.CheckedChanged += rbtnGrupo_CheckedChanged;
            // 
            // rbtnAula
            // 
            rbtnAula.AutoSize = true;
            rbtnAula.Location = new Point(23, 106);
            rbtnAula.Name = "rbtnAula";
            rbtnAula.Size = new Size(49, 19);
            rbtnAula.TabIndex = 10;
            rbtnAula.TabStop = true;
            rbtnAula.Text = "Aula";
            rbtnAula.UseVisualStyleBackColor = true;
            rbtnAula.CheckedChanged += rbtnAula_CheckedChanged;
            // 
            // rbtnProfesor
            // 
            rbtnProfesor.AutoSize = true;
            rbtnProfesor.Location = new Point(161, 61);
            rbtnProfesor.Name = "rbtnProfesor";
            rbtnProfesor.Size = new Size(69, 19);
            rbtnProfesor.TabIndex = 11;
            rbtnProfesor.TabStop = true;
            rbtnProfesor.Text = "Profesor";
            rbtnProfesor.UseVisualStyleBackColor = true;
            rbtnProfesor.CheckedChanged += rbtnProfesor_CheckedChanged;
            // 
            // FormConsultaAsignaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 559);
            Controls.Add(rbtnProfesor);
            Controls.Add(rbtnAula);
            Controls.Add(rbtnGrupo);
            Controls.Add(dgvConsulta);
            Controls.Add(btnBuscar);
            Controls.Add(lblFiltros);
            Controls.Add(cmbFiltro);
            Controls.Add(comboBox1);
            Name = "FormConsultaAsignaciones";
            Text = "FormConsultaAsignaciones";
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label lblFiltros;
        private ComboBox cmbFiltro;
        private Button btnBuscar;
        private DataGridView dgvConsulta;
        private RadioButton rbtnGrupo;
        private RadioButton rbtnAula;
        private RadioButton rbtnProfesor;
    }
}