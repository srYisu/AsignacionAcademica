using AsignacionAcademica.asignaturas;
using AsignacionAcademica.aulas;
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
    public partial class FormAsignaturas : Form
    {
        private List<GestionAsignaturas> asignaturas;
        Conexion Conexion;
        private consultaAsignaturas consultaAsignaturas;
        private GestionAsignaturas gestionAsignaturas;
        int asignaturaId = 0;
        public FormAsignaturas()
        {
            InitializeComponent();
            pnlBotonActualizar.Visible = false;
            configTabla();

            asignaturas = new List<GestionAsignaturas>();
            consultaAsignaturas = new consultaAsignaturas();
            gestionAsignaturas = new GestionAsignaturas();

            CargarAsignaturas();
        }
        private void configTabla()
        {
            // Configuración de la tabla
            dgvAsignaturas.AllowUserToAddRows = false;

            dgvAsignaturas.Columns.Add("id", "ID");
            dgvAsignaturas.Columns.Add("asignatura", "Asignatura");
            dgvAsignaturas.Columns.Add("Tipo", "Tipo");

            // Establecer el modo de selección de filas
            dgvAsignaturas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void CargarAsignaturas(string filtro = "")
        {
            dgvAsignaturas.Rows.Clear();
            dgvAsignaturas.Refresh();
            asignaturas.Clear();
            asignaturas = consultaAsignaturas.GetAsignaturas(filtro);

            for (int i = 0; i < asignaturas.Count; i++)
            {
                dgvAsignaturas.Rows.Add
                    (asignaturas[i].id,
                    asignaturas[i].asignatura,
                    asignaturas[i].tipo);
            }
        }
        private void GuardarAsignatura()
        {
            gestionAsignaturas.asignatura = txtAsignatura.Text;
            gestionAsignaturas.tipo = cmbTipo.Text;

            if (consultaAsignaturas.AgregarAsignatura(gestionAsignaturas))
            {
                MessageBox.Show("Aula agregada correctamente");
                CargarAsignaturas();
                LimpiarCampos();
            }

        }
        private void LimpiarCampos()
        {
            txtAsignatura.Clear();
            cmbTipo.SelectedIndex = -1;
        }
        private void EliminarAsignaturas()
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar esta asignatura?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (dgvAsignaturas.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dgvAsignaturas.SelectedRows[0].Cells[0].Value);
                    if (consultaAsignaturas.EliminarAsignatura(id))
                    {
                        MessageBox.Show("Asignatura eliminada correctamente");
                        CargarAsignaturas();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una asignatura para eliminar");
                }
            }
        }
        private void EditarAsignatura()
        {
            if (dgvAsignaturas.SelectedRows.Count > 0)
            {
                asignaturaId = Convert.ToInt32(dgvAsignaturas.SelectedRows[0].Cells[0].Value);
                txtAsignatura.Text = dgvAsignaturas.SelectedRows[0].Cells[1].Value.ToString();
                cmbTipo.Text = dgvAsignaturas.SelectedRows[0].Cells[2].Value.ToString();
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormMenuPrincipal formMenuPrincipal = new FormMenuPrincipal();
            formMenuPrincipal.Show();
            this.Hide();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarAsignatura();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarAsignaturas();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarAsignatura();
            pnlBotonActualizar.Visible = true;
            btnLimpiar.Text = "Cancelar";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            pnlBotonActualizar.Visible = false;
            LimpiarCampos();
            btnLimpiar.Text = "Limpiar";
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            gestionAsignaturas.asignatura = txtAsignatura.Text;
            gestionAsignaturas.tipo = cmbTipo.Text;

            if (consultaAsignaturas.EditarAsignatura(gestionAsignaturas, asignaturaId))
            {
                MessageBox.Show("Asignatura actualizada correctamente");
                CargarAsignaturas();
                LimpiarCampos();
                pnlBotonActualizar.Visible = false;
                btnLimpiar.Text = "Limpiar";
            }
        }
    }
}
