using AsignacionAcademica.aulas;
using System;
using System.Data;
using System.Windows.Forms;

namespace AsignacionAcademica
{
    public partial class FormAulas : Form
    {
        private consultaAulas consultaAulas;
        private int aulaId = 0;

        public FormAulas()
        {
            InitializeComponent();
            consultaAulas = new consultaAulas();
            CargarAulas();
            pnlBotonActualizar.Visible = false;
        }

        private void CargarAulas()
        {
            dgvAulas.DataSource = consultaAulas.ConsultarAulas();
        }

        private void GuardarAula()
        {
            string nombre = txtNombreAula.Text;
            int capacidad = int.Parse(txtCapacidad.Text);
            string ubicacion = txtUbicacion.Text;

            if (consultaAulas.GuardarAula(nombre, capacidad, ubicacion))
            {
                MessageBox.Show("Aula agregada correctamente");
                CargarAulas();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al agregar el aula");
            }
        }

        private void EditarAula()
        {
            if (dgvAulas.SelectedRows.Count > 0)
            {
                aulaId = Convert.ToInt32(dgvAulas.SelectedRows[0].Cells["ID"].Value);
                txtNombreAula.Text = dgvAulas.SelectedRows[0].Cells["Nombre"].Value.ToString();
                txtCapacidad.Text = dgvAulas.SelectedRows[0].Cells["Capacidad"].Value.ToString();
                txtUbicacion.Text = dgvAulas.SelectedRows[0].Cells["Ubicacion"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione un aula para editar");
            }
        }

        private void ActualizarAula()
        {
            string nombre = txtNombreAula.Text;
            int capacidad = int.Parse(txtCapacidad.Text);
            string ubicacion = txtUbicacion.Text;

            if (consultaAulas.ActualizarAula(aulaId, nombre, capacidad, ubicacion))
            {
                MessageBox.Show("Aula actualizada correctamente");
                CargarAulas();
                LimpiarCampos();
                pnlBotonActualizar.Visible = false;
            }
            else
            {
                MessageBox.Show("Error al actualizar el aula");
            }
        }

        private void EliminarAula()
        {
            if (dgvAulas.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar esta aula?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvAulas.SelectedRows[0].Cells["ID"].Value);
                    if (consultaAulas.EliminarAula(id))
                    {
                        MessageBox.Show("Aula eliminada correctamente");
                        CargarAulas();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el aula");
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un aula para eliminar");
            }
        }

        private void LimpiarCampos()
        {
            txtNombreAula.Clear();
            txtCapacidad.Clear();
            txtUbicacion.Clear();
            aulaId = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarAula();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarAula();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarAula();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarAula();
            pnlBotonActualizar.Visible = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            pnlBotonActualizar.Visible = false;
        }
    }
}


