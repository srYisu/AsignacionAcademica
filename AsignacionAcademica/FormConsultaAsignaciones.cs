using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AsignacionAcademica
{
    public partial class FormConsultaAsignaciones : Form
    {
        private Conexion conexion = new Conexion();

        public FormConsultaAsignaciones()
        {
            InitializeComponent();
            ConfigurarInterfaz();
            CargarFiltros();
        }

        private void ConfigurarInterfaz()
        {
            // Configuración básica del formulario
            this.Text = "Consulta de Asignaciones";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            // Configurar DataGridView
            dgvConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConsulta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConsulta.MultiSelect = false;
            dgvConsulta.ReadOnly = true;
            dgvConsulta.AllowUserToAddRows = false;

            // Configurar controles
            rbtnProfesor.Checked = true; // Por defecto buscar por grupo
            cmbFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarFiltros()
        {
            try
            {
                using (MySqlConnection conn = conexion.ObtenerConexion())
                {
                    conn.Open();

                    if (rbtnGrupo.Checked)
                    {
                        // Cargar grupos
                        string query = "SELECT idGrupos, nombre FROM grupos ORDER BY nombre";
                        MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        cmbFiltro.DataSource = dt;
                        cmbFiltro.DisplayMember = "nombre";
                        cmbFiltro.ValueMember = "idGrupos";
                        cmbFiltro.SelectedIndex = -1;
                    }
                    else if (rbtnProfesor.Checked)
                    {
                        // Cargar profesores
                        string query = "SELECT idProfesores, CONCAT(nombre, ' ', apellido_P, ' ', apellido_M) AS nombreCompleto FROM profesores ORDER BY nombre";
                        MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        cmbFiltro.DataSource = dt;
                        cmbFiltro.DisplayMember = "nombreCompleto";
                        cmbFiltro.ValueMember = "idProfesores";
                        cmbFiltro.SelectedIndex = -1;
                    }
                    else if (rbtnAula.Checked)
                    {
                        // Cargar aulas
                        string query = "SELECT idAulas, nombre FROM aulas ORDER BY nombre";
                        MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        cmbFiltro.DataSource = dt;
                        cmbFiltro.DisplayMember = "nombre";
                        cmbFiltro.ValueMember = "idAulas";
                        cmbFiltro.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los filtros: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbFiltro.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un elemento para filtrar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    string query = @"SELECT 
                                    g.nombre AS Grupo, 
                                    p.nombre AS Profesor, 
                                    a.nombre AS Aula, 
                                    asig.nombre AS Asignatura, 
                                    c.dia AS Día, 
                                    c.hora_inicio AS 'Hora Inicio', 
                                    c.hora_fin AS 'Hora Fin'
                                FROM clases c
                                JOIN grupos g ON c.grupo_id = g.idGrupos
                                JOIN profesores p ON c.profesor_id = p.idProfesores
                                JOIN aulas a ON c.aula_id = a.idAulas
                                JOIN asignaturas asig ON c.asignatura_id = asig.idAsignaturas
                                WHERE ";

                    if (rbtnGrupo.Checked)
                    {
                        query += "c.grupo_id = @id";
                    }
                    else if (rbtnProfesor.Checked)
                    {
                        query += "c.profesor_id = @id";
                    }
                    else if (rbtnAula.Checked)
                    {
                        query += "c.aula_id = @id";
                    }

                    query += " ORDER BY c.dia, c.hora_inicio";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", cmbFiltro.SelectedValue);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvConsulta.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontraron asignaciones para el criterio seleccionado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la consulta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbtnGrupo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnGrupo.Checked) CargarFiltros();
        }

        private void rbtnProfesor_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnProfesor.Checked) CargarFiltros();
        }

        private void rbtnAula_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAula.Checked) CargarFiltros();
        }
    }
}