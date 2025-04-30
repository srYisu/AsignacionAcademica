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
        private ConsultaProfesores consultaProfesores;
        private int profesorId = 0;

        public FormProfesores()
        {
            InitializeComponent();
            consultaProfesores = new ConsultaProfesores();
            CargarProfesores();
            pnlBotonActualizar.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormMenuPrincipal formMenuPrincipal = new FormMenuPrincipal();
            formMenuPrincipal.Show();
            this.Hide();
        }

        private void CargarProfesores()
        {
            dgvProfesores.DataSource = consultaProfesores.ConsultarProfesores();
        }

        private void GuardarProfesor()
        {
            string nombre = txtNombre.Text;
            string apellidoPaterno = txtApellidoPaterno.Text;
            string apellidoMaterno = txtApellidoMaterno.Text;
            string especialidad = txtEspecialidad.Text;

            if (consultaProfesores.GuardarProfesor(nombre, apellidoPaterno, apellidoMaterno, especialidad))
            {
                MessageBox.Show("Profesor agregado correctamente");
                CargarProfesores();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al agregar el profesor");
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
            else
            {
                MessageBox.Show("Seleccione un profesor para editar");
            }
        }

        private void ActualizarProfesor()
        {
            string nombre = txtNombre.Text;
            string apellidoPaterno = txtApellidoPaterno.Text;
            string apellidoMaterno = txtApellidoMaterno.Text;
            string especialidad = txtEspecialidad.Text;

            if (consultaProfesores.ActualizarProfesor(profesorId, nombre, apellidoPaterno, apellidoMaterno, especialidad))
            {
                MessageBox.Show("Profesor actualizado correctamente");
                CargarProfesores();
                LimpiarCampos();
                pnlBotonActualizar.Visible = false;
            }
            else
            {
                MessageBox.Show("Error al actualizar el profesor");
            }
        }

        private void EliminarProfesor()
        {
            if (dgvProfesores.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este profesor?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
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
            }
            else
            {
                MessageBox.Show("Seleccione un profesor para eliminar");
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellidoPaterno.Clear();
            txtApellidoMaterno.Clear();
            txtEspecialidad.Clear();
            profesorId = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarProfesor();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            pnlBotonActualizar.Visible = true;
            EditarProfesor();
            btnLimpiar.Text = "Cancelar";
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            ActualizarProfesor();
            btnLimpiar.Text = "Limpiar";
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
            pnlBotonActualizar.Visible = false;
            btnLimpiar.Text = "Limpiar";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarProfesor();
        }
    }


}
