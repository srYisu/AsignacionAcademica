using AsignacionAcademica.asignaturas;
using System;
using System.Data;
using System.Windows.Forms;

namespace AsignacionAcademica
{
    public partial class FormAsignaturas : Form
    {
        private consultaAsignaturas consultaAsignaturas;
        private int asignaturaId = 0;

        public FormAsignaturas()
        {
            InitializeComponent();
            consultaAsignaturas = new consultaAsignaturas();
            CargarAsignaturas();
            pnlBotonActualizar.Visible = false;
        }

        private void CargarAsignaturas()
        {
            dgvAsignaturas.DataSource = consultaAsignaturas.ConsultarAsignaturas();
        }

        private void GuardarAsignatura()
        {
            string asignatura = txtAsignatura.Text;
            string tipo = cmbTipo.Text;

            if (consultaAsignaturas.GuardarAsignatura(asignatura, tipo))
            {
                MessageBox.Show("Asignatura agregada correctamente");
                CargarAsignaturas();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al agregar la asignatura");
            }
        }

        private void EditarAsignatura()
        {
            if (dgvAsignaturas.SelectedRows.Count > 0)
            {
                asignaturaId = Convert.ToInt32(dgvAsignaturas.SelectedRows[0].Cells["ID"].Value);
                txtAsignatura.Text = dgvAsignaturas.SelectedRows[0].Cells["Asignatura"].Value.ToString();
                cmbTipo.Text = dgvAsignaturas.SelectedRows[0].Cells["Tipo"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una asignatura para editar");
            }
        }

        private void ActualizarAsignatura()
        {
            string asignatura = txtAsignatura.Text;
            string tipo = cmbTipo.Text;

            if (consultaAsignaturas.ActualizarAsignatura(asignaturaId, asignatura, tipo))
            {
                MessageBox.Show("Asignatura actualizada correctamente");
                CargarAsignaturas();
                LimpiarCampos();
                pnlBotonActualizar.Visible = false;
            }
            else
            {
                MessageBox.Show("Error al actualizar la asignatura");
            }
        }

        private void EliminarAsignatura()
        {
            if (dgvAsignaturas.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar esta asignatura?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvAsignaturas.SelectedRows[0].Cells["ID"].Value);
                    if (consultaAsignaturas.EliminarAsignatura(id))
                    {
                        MessageBox.Show("Asignatura eliminada correctamente");
                        CargarAsignaturas();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la asignatura");
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una asignatura para eliminar");
            }
        }

        private void LimpiarCampos()
        {
            txtAsignatura.Clear();
            cmbTipo.SelectedIndex = -1;
            asignaturaId = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarAsignatura();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarAsignatura();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarAsignatura();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarAsignatura();
            pnlBotonActualizar.Visible = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            pnlBotonActualizar.Visible = false;
        }
    }
}
