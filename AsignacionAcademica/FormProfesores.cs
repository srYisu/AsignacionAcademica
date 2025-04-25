using AsignacionAcademica.profesores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsignacionAcademica
{
    public partial class FormProfesores : Form
    {
        private List<GestionProfesores> profesores;
        Conexion c = new Conexion();
        private ConsultaProfesores consultaProfesores;
        private GestionProfesores gestionProfesores;

        int profesorId = 0;
        public FormProfesores()
        {
            InitializeComponent();
            configTabla();
            profesores = new List<GestionProfesores>();
            consultaProfesores = new ConsultaProfesores();
            gestionProfesores = new GestionProfesores();
            CargarProfesores();
            pnlBotonActualizar.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormMenuPrincipal formMenuPrincipal = new FormMenuPrincipal();
            formMenuPrincipal.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormProfesores_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            EliminarProfesor();
        }
        private void configTabla()
        {
            // Configuración de la tabla
            dgvProfesores.AllowUserToAddRows = false;

            dgvProfesores.Columns.Add("id", "ID");
            dgvProfesores.Columns.Add("nombre", "Nombre");
            dgvProfesores.Columns.Add("apellidoP", "Apellido paterno");
            dgvProfesores.Columns.Add("apellidoM", "Apelliod materno");
            dgvProfesores.Columns.Add("especialidad", "Especialidad");

            // Establecer el modo de selección de filas
            dgvProfesores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void CargarProfesores(string filtro = "")
        {
            dgvProfesores.Rows.Clear();
            dgvProfesores.Refresh();
            profesores.Clear();
            profesores = consultaProfesores.GetProfesores(filtro);

            for (int i = 0; i < profesores.Count; i++)
            {
                dgvProfesores.Rows.Add
                    (profesores[i].id,
                    profesores[i].nombre,
                    profesores[i].apellidoPaterno,
                    profesores[i].apellidoMaterno,
                    profesores[i].especialidad);
            }
        }
        private void GuardarProfesor()
        {
            gestionProfesores.nombre = txtNombre.Text;
            gestionProfesores.apellidoPaterno = txtApellidoPaterno.Text;
            gestionProfesores.apellidoMaterno = txtApellidoMaterno.Text;
            gestionProfesores.especialidad = txtEspecialidad.Text;

            if (consultaProfesores.AgregarProfesor(gestionProfesores))
            {
                MessageBox.Show("Profesor agregado correctamente");
                CargarProfesores();
                LimpiarCampos();
            }

        }

        private void EditarProfesor()
        {
            if (dgvProfesores.SelectedRows.Count > 0)
            {
                profesorId = Convert.ToInt32(dgvProfesores.SelectedRows[0].Cells[0].Value);
                txtNombre.Text = dgvProfesores.SelectedRows[0].Cells[1].Value.ToString();
                txtApellidoPaterno.Text = dgvProfesores.SelectedRows[0].Cells[2].Value.ToString();
                txtApellidoMaterno.Text = dgvProfesores.SelectedRows[0].Cells[3].Value.ToString();
                txtEspecialidad.Text = dgvProfesores.SelectedRows[0].Cells[4].Value.ToString();
            }
        }
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellidoPaterno.Clear();
            txtApellidoMaterno.Clear();
            txtEspecialidad.Clear();
        }
        private void EliminarProfesor()
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este profesor?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (dgvProfesores.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dgvProfesores.SelectedRows[0].Cells[0].Value);
                    if (consultaProfesores.EliminarProfesor(id))
                    {
                        MessageBox.Show("Profesor eliminado correctamente");
                        CargarProfesores();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el profesor");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un profesor para eliminar");
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarProfesor();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            pnlBotonActualizar.Visible = true;
            EditarProfesor();
            btnLimpiar.Text = "Cancelar";
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
            pnlBotonActualizar.Visible = false;
            btnLimpiar.Text = "Limpiar";
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            gestionProfesores.nombre = txtNombre.Text;
            gestionProfesores.apellidoPaterno = txtApellidoPaterno.Text;
            gestionProfesores.apellidoMaterno = txtApellidoMaterno.Text;
            gestionProfesores.especialidad = txtEspecialidad.Text;

            if (consultaProfesores.EditarProfesor(gestionProfesores, profesorId))
            {
                MessageBox.Show("Profesor actualizado correctamente");
                CargarProfesores();
                LimpiarCampos();
                pnlBotonActualizar.Visible = false;
            }
            btnLimpiar.Text = "Limpiar";
        }
    }

}
