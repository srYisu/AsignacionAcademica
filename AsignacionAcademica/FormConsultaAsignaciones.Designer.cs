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
            cmbFiltro.Location = new Point(23, 49);
            cmbFiltro.Name = "cmbFiltro";
            cmbFiltro.Size = new Size(170, 23);
            cmbFiltro.TabIndex = 5;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(23, 78);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgvConsulta
            // 
            dgvConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsulta.Location = new Point(257, 31);
            dgvConsulta.Name = "dgvConsulta";
            dgvConsulta.Size = new Size(662, 345);
            dgvConsulta.TabIndex = 8;
            // 
            // FormConsultaAsignaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 559);
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
    }
}