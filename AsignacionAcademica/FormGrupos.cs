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
        private consultaGrupos consultaGrupos;
        private int grupoId = 0;

        public FormGrupos()
        {
            InitializeComponent();
            consultaGrupos = new consultaGrupos();
            CargarGrupos();
            pnlBotonActualizar.Visible = false;
        }

        private void CargarGrupos()
        {
            dgvGrupos.DataSource = consultaGrupos.ConsultarGrupos();
        }

        private void GuardarGrupo()
        {
            string nombre = txtGrupo.Text;
            int numAlumnos = int.Parse(txtNumAlumnos.Text);
            string carrera = cmbCarrera.Text;

            if (consultaGrupos.GuardarGrupo(nombre, numAlumnos, carrera))
            {
                MessageBox.Show("Grupo agregado correctamente");
                CargarGrupos();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al agregar el grupo");
            }
        }

        private void EditarGrupo()
        {
            if (dgvGrupos.SelectedRows.Count > 0)
            {
                grupoId = Convert.ToInt32(dgvGrupos.SelectedRows[0].Cells["ID"].Value);
                txtGrupo.Text = dgvGrupos.SelectedRows[0].Cells["Grupo"].Value.ToString();
                txtNumAlumnos.Text = dgvGrupos.SelectedRows[0].Cells["NumeroAlumnos"].Value.ToString();
                cmbCarrera.Text = dgvGrupos.SelectedRows[0].Cells["Carrera"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione un grupo para editar");
            }
        }

        private void ActualizarGrupo()
        {
            string nombre = txtGrupo.Text;
            int numAlumnos = int.Parse(txtNumAlumnos.Text);
            string carrera = cmbCarrera.Text;

            if (consultaGrupos.ActualizarGrupo(grupoId, nombre, numAlumnos, carrera))
            {
                MessageBox.Show("Grupo actualizado correctamente");
                CargarGrupos();
                LimpiarCampos();
                pnlBotonActualizar.Visible = false;
            }
            else
            {
                MessageBox.Show("Error al actualizar el grupo");
            }
        }

        private void EliminarGrupo()
        {
            if (dgvGrupos.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este grupo?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvGrupos.SelectedRows[0].Cells["ID"].Value);
                    if (consultaGrupos.EliminarGrupo(id))
                    {
                        MessageBox.Show("Grupo eliminado correctamente");
                        CargarGrupos();
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un grupo para eliminar");
            }
        }

        private void LimpiarCampos()
        {
            txtGrupo.Clear();
            txtNumAlumnos.Clear();
            cmbCarrera.SelectedIndex = -1;
            grupoId = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarGrupo();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarGrupo();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarGrupo();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarGrupo();
            pnlBotonActualizar.Visible = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            pnlBotonActualizar.Visible = false;
        }
    }


}
