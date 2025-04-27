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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            comboBox1 = new ComboBox();
            lblFiltros = new Label();
            cmbFiltro = new ComboBox();
            btnBuscar = new Button();
            rbtnGrupo = new RadioButton();
            rbtnAula = new RadioButton();
            rbtnProfesor = new RadioButton();
            dgvConsulta = new Guna.UI2.WinForms.Guna2DataGridView();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(32, 87);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(0, 23);
            comboBox1.TabIndex = 0;
            // 
            // lblFiltros
            // 
            lblFiltros.AutoSize = true;
            lblFiltros.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFiltros.ForeColor = Color.White;
            lblFiltros.Location = new Point(23, 71);
            lblFiltros.Name = "lblFiltros";
            lblFiltros.Size = new Size(82, 21);
            lblFiltros.TabIndex = 6;
            lblFiltros.Text = "Filtrar por:";
            // 
            // cmbFiltro
            // 
            cmbFiltro.FormattingEnabled = true;
            cmbFiltro.Location = new Point(23, 201);
            cmbFiltro.Name = "cmbFiltro";
            cmbFiltro.Size = new Size(170, 23);
            cmbFiltro.TabIndex = 5;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(209, 200);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // rbtnGrupo
            // 
            rbtnGrupo.AutoSize = true;
            rbtnGrupo.ForeColor = Color.White;
            rbtnGrupo.Location = new Point(24, 101);
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
            rbtnAula.ForeColor = Color.White;
            rbtnAula.Location = new Point(23, 146);
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
            rbtnProfesor.ForeColor = Color.White;
            rbtnProfesor.Location = new Point(161, 101);
            rbtnProfesor.Name = "rbtnProfesor";
            rbtnProfesor.Size = new Size(69, 19);
            rbtnProfesor.TabIndex = 11;
            rbtnProfesor.TabStop = true;
            rbtnProfesor.Text = "Profesor";
            rbtnProfesor.UseVisualStyleBackColor = true;
            rbtnProfesor.CheckedChanged += rbtnProfesor_CheckedChanged;
            // 
            // dgvConsulta
            // 
            dgvConsulta.AllowUserToAddRows = false;
            dgvConsulta.AllowUserToDeleteRows = false;
            dgvConsulta.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(182, 205, 235);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgvConsulta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvConsulta.BackgroundColor = Color.FromArgb(27, 57, 106);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(27, 57, 160);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(27, 57, 160);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvConsulta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvConsulta.ColumnHeadersHeight = 25;
            dgvConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(182, 205, 235);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvConsulta.DefaultCellStyle = dataGridViewCellStyle3;
            dgvConsulta.GridColor = Color.FromArgb(231, 229, 255);
            dgvConsulta.Location = new Point(331, 87);
            dgvConsulta.Name = "dgvConsulta";
            dgvConsulta.ReadOnly = true;
            dgvConsulta.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvConsulta.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvConsulta.RowHeadersVisible = false;
            dgvConsulta.Size = new Size(588, 293);
            dgvConsulta.TabIndex = 48;
            dgvConsulta.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvConsulta.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvConsulta.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvConsulta.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvConsulta.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvConsulta.ThemeStyle.BackColor = Color.FromArgb(27, 57, 106);
            dgvConsulta.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvConsulta.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvConsulta.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvConsulta.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvConsulta.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvConsulta.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvConsulta.ThemeStyle.HeaderStyle.Height = 25;
            dgvConsulta.ThemeStyle.ReadOnly = true;
            dgvConsulta.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvConsulta.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvConsulta.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvConsulta.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvConsulta.ThemeStyle.RowsStyle.Height = 25;
            dgvConsulta.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvConsulta.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(378, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(171, 47);
            lblTitulo.TabIndex = 49;
            lblTitulo.Text = "Consultas";
            // 
            // FormConsultaAsignaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 57, 106);
            ClientSize = new Size(931, 559);
            Controls.Add(lblTitulo);
            Controls.Add(dgvConsulta);
            Controls.Add(rbtnProfesor);
            Controls.Add(rbtnAula);
            Controls.Add(rbtnGrupo);
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
        private RadioButton rbtnGrupo;
        private RadioButton rbtnAula;
        private RadioButton rbtnProfesor;
        private Guna.UI2.WinForms.Guna2DataGridView dgvConsulta;
        private Label lblTitulo;
    }
}