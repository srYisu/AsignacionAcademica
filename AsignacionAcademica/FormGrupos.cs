using AsignacionAcademica.asignaturas;
using AsignacionAcademica.aulas;
using AsignacionAcademica.grupos;
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
    public partial class FormGrupos : Form
    {
        private List<GestionGrupos> grupos;
        Conexion Conexion;
        private consultaGrupos consultaGrupos;
        private GestionGrupos gestionGrupos;
        int grupoId = 0;
        public FormGrupos()
        {
            InitializeComponent();
            configTabla();
            pnlBotonActualizar.Visible = false;

            grupos = new List<GestionGrupos>();
            consultaGrupos = new consultaGrupos();
            gestionGrupos = new GestionGrupos();
            pnlBotonActualizar.Visible = false;
            CargarGrupos();
        }
        private void configTabla()
        {
            // Configuración de la tabla
            dgvGrupos.AllowUserToAddRows = false;

            dgvGrupos.Columns.Add("id", "ID");
            dgvGrupos.Columns.Add("grupo", "Grupo");
            dgvGrupos.Columns.Add("n_alumnos", "Número de alumnos");
            dgvGrupos.Columns.Add("carrera", "Carrera");

            // Establecer el modo de selección de filas
            dgvGrupos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void CargarGrupos(string filtro = "")
        {
            dgvGrupos.Rows.Clear();
            dgvGrupos.Refresh();
            grupos.Clear();
            grupos = consultaGrupos.GetGrupos(filtro);

            for (int i = 0; i < grupos.Count; i++)
            {
                dgvGrupos.Rows.Add
                    (grupos[i].id,
                    grupos[i].grupo,
                    grupos[i].numAlumnos,
                    grupos[i].carrera);
            }
        }
        private void GuardarGrupo()
        {
            gestionGrupos.grupo = txtGrupo.Text;
            gestionGrupos.numAlumnos = int.Parse(txtNumAlumnos.Text);
            gestionGrupos.carrera = cmbCarrera.Text;

            if (consultaGrupos.AgregarGrupo(gestionGrupos))
            {
                MessageBox.Show("Grupo agregado correctamente");
                CargarGrupos();
                LimpiarCampos();
            }

        }
        private void LimpiarCampos()
        {
            txtGrupo.Clear();
            txtNumAlumnos.Clear();
            cmbCarrera.SelectedIndex = -1;
        }
        private void EliminarGrupo()
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este grupo?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (dgvGrupos.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dgvGrupos.SelectedRows[0].Cells[0].Value);
                    if (consultaGrupos.EliminarGrupo(id))
                    {
                        MessageBox.Show("Grupo eliminado correctamente");
                        CargarGrupos();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el grupo");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un grupo para eliminar");
                }
            }
        }
        private void EditarGrupo()
        {
            if (dgvGrupos.SelectedRows.Count > 0)
            {
                grupoId = Convert.ToInt32(dgvGrupos.SelectedRows[0].Cells[0].Value);
                txtGrupo.Text = dgvGrupos.SelectedRows[0].Cells[1].Value.ToString();
                txtNumAlumnos.Text = dgvGrupos.SelectedRows[0].Cells[2].Value.ToString();
                cmbCarrera.Text = dgvGrupos.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormMenuPrincipal formMenuPrincipal = new FormMenuPrincipal();
            formMenuPrincipal.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormGrupos_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarGrupo();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnLimpiar.Text = "Limpiar";
            pnlBotonActualizar.Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarGrupo();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarGrupo();
            pnlBotonActualizar.Visible = true;
            btnLimpiar.Text = "Cancelar";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            gestionGrupos.grupo = txtGrupo.Text;
            gestionGrupos.numAlumnos = int.Parse(txtNumAlumnos.Text);
            gestionGrupos.carrera = cmbCarrera.Text;

            if (consultaGrupos.EditarGrupos(gestionGrupos, grupoId))
            {
                MessageBox.Show("Grupo actualizada correctamente");
                CargarGrupos();
                LimpiarCampos();
                pnlBotonActualizar.Visible = false;
                btnLimpiar.Text = "Limpiar";
            }
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void dgvGrupos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
