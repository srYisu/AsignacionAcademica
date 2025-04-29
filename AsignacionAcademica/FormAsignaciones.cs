using AsignacionAcademica.grupos;
using AsignacionAcademica.profesores;
using AsignacionAcademica.aulas;
using AsignacionAcademica.asignaturas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AsignacionAcademica.asignaciones;

namespace AsignacionAcademica
{
    public partial class FormAsignaciones : Form
    {
        private consultaAsignaciones consulta;
        int idClaseSeleccionada = -1;

        public FormAsignaciones()
        {
            InitializeComponent();
            dtpHoraInicio.Format = DateTimePickerFormat.Time;
            dtpHoraInicio.ShowUpDown = true;
            dtpHoraFin.Format = DateTimePickerFormat.Time;
            dtpHoraFin.ShowUpDown = true;

            consulta = new consultaAsignaciones();
            pnlBotonActualizar.Visible = false; // Ocultar el panel de actualización al inicio
            LlenarComboBox();
            LimpiarCampos();
            CargarClases();

            // Configurar DataGridView
            dgvClases.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClases.MultiSelect = false;
            dgvClases.CellClick += DgvClases_CellClick;
        }

        private void DgvClases_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegurarse de que no se hizo clic en el encabezado
            {
                DataGridViewRow row = dgvClases.Rows[e.RowIndex];
                idClaseSeleccionada = Convert.ToInt32(row.Cells["idClases"].Value);
            }
        }

        public void LlenarComboBox()
        {
            // Grupos
            consultaGrupos consultaG = new consultaGrupos();
            List<GestionGrupos> grupos = consultaG.GetGrupos(null);
            cmbGrupo.DataSource = grupos;
            cmbGrupo.DisplayMember = "grupo";
            cmbGrupo.ValueMember = "id";

            // Profesores
            ConsultaProfesores consultaP = new ConsultaProfesores();
            List<GestionProfesores> profesores = consultaP.GetProfesores(null);
            cmbProfesor.DataSource = profesores;
            cmbProfesor.DisplayMember = "nombre"; // Asumo que existe esta propiedad
            cmbProfesor.ValueMember = "id";

            // Aulas
            consultaAulas consultaA = new consultaAulas();
            List<GestionAulas> aulas = consultaA.GetAulas(null);
            cmbAula.DataSource = aulas;
            cmbAula.DisplayMember = "nombre";
            cmbAula.ValueMember = "id";

            // Asignaturas
            consultaAsignaturas consultaAsig = new consultaAsignaturas();
            List<GestionAsignaturas> asignaturas = consultaAsig.GetAsignaturas(null);
            cmbAsignatura.DataSource = asignaturas;
            cmbAsignatura.DisplayMember = "asignatura";
            cmbAsignatura.ValueMember = "id";

            // Días de la semana
            cmDia.Items.AddRange(new string[] { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado" });
        }

        private bool ObtenerDatosClase(out int grupoId, out int profesorId, out int aulaId, out int asignaturaId, out string dia, out TimeSpan horaInicio, out TimeSpan horaFin)
        {
            grupoId = profesorId = aulaId = asignaturaId = -1;
            dia = "";
            horaInicio = horaFin = TimeSpan.Zero;

            if (cmbGrupo.SelectedValue == null || cmbProfesor.SelectedValue == null ||
                cmbAula.SelectedValue == null || cmbAsignatura.SelectedValue == null ||
                string.IsNullOrEmpty(cmDia.Text))
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return false;
            }

            grupoId = Convert.ToInt32(cmbGrupo.SelectedValue);
            profesorId = Convert.ToInt32(cmbProfesor.SelectedValue);
            aulaId = Convert.ToInt32(cmbAula.SelectedValue);
            asignaturaId = Convert.ToInt32(cmbAsignatura.SelectedValue);
            dia = cmDia.Text;
            horaInicio = dtpHoraInicio.Value.TimeOfDay;
            horaFin = dtpHoraFin.Value.TimeOfDay;

            // Validar que la hora de fin sea mayor que la de inicio
            if (horaFin <= horaInicio)
            {
                MessageBox.Show("La hora de fin debe ser mayor que la hora de inicio.");
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            cmbGrupo.SelectedIndex = -1;
            cmbProfesor.SelectedIndex = -1;
            cmbAula.SelectedIndex = -1;
            cmbAsignatura.SelectedIndex = -1;
            cmDia.SelectedIndex = -1;
            dtpHoraInicio.Value = DateTime.Today.AddHours(8); // Hora por defecto 8:00 AM
            dtpHoraFin.Value = DateTime.Today.AddHours(9);    // Hora por defecto 9:00 AM
            idClaseSeleccionada = -1;
            pnlBotonActualizar.Visible = false;
        }

        private void CargarClases()
        {
            dgvClases.DataSource = consulta.ConsultarClases();

            // Ocultar la columna de ID si existe
            if (dgvClases.Columns.Contains("idClases"))
                dgvClases.Columns["idClases"].Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ObtenerDatosClase(out int grupoId, out int profesorId, out int aulaId, out int asignaturaId, out string dia, out TimeSpan horaInicio, out TimeSpan horaFin))
            {
                bool guardado = consulta.GuardarClaseSiDisponible(grupoId, profesorId, aulaId, asignaturaId, dia, horaInicio, horaFin);
                if (guardado)
                {
                    MessageBox.Show("Clase guardada exitosamente.");
                    LimpiarCampos();
                    CargarClases();
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idClaseSeleccionada == -1)
            {
                MessageBox.Show("Seleccione una clase para actualizar.");
                return;
            }

            if (ObtenerDatosClase(out int grupoId, out int profesorId, out int aulaId, out int asignaturaId, out string dia, out TimeSpan horaInicio, out TimeSpan horaFin))
            {
                bool actualizado = consulta.ActualizarClase(idClaseSeleccionada, grupoId, profesorId, aulaId, asignaturaId, dia, horaInicio, horaFin);
                if (actualizado)
                {
                    MessageBox.Show("Clase actualizada exitosamente.");
                    LimpiarCampos();
                    CargarClases();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idClaseSeleccionada == -1)
            {
                MessageBox.Show("Seleccione una clase para editar.");
                return;
            }

            DataRow clase = consulta.ObtenerClasePorId(idClaseSeleccionada);
            if (clase != null)
            {
                // Llenar los controles con los datos de la clase
                cmbGrupo.SelectedValue = clase["grupo_id"];
                cmbProfesor.SelectedValue = clase["profesor_id"];
                cmbAula.SelectedValue = clase["aula_id"];
                cmbAsignatura.SelectedValue = clase["asignatura_id"];
                cmDia.Text = clase["dia"].ToString();
                dtpHoraInicio.Value = DateTime.Today.Add((TimeSpan)clase["hora_inicio"]);
                dtpHoraFin.Value = DateTime.Today.Add((TimeSpan)clase["hora_fin"]);

                // Mostrar el panel de actualización
                pnlBotonActualizar.Visible = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idClaseSeleccionada == -1)
            {
                MessageBox.Show("Seleccione una clase para eliminar.");
                return;
            }

            if (MessageBox.Show("¿Estás seguro de eliminar esta clase?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool eliminado = consulta.EliminarClase(idClaseSeleccionada);
                if (eliminado)
                {
                    MessageBox.Show("Clase eliminada exitosamente.");
                    LimpiarCampos();
                    CargarClases();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dgvClases_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}