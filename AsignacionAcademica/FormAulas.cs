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
using AsignacionAcademica.aulas;

namespace AsignacionAcademica
{
    public partial class FormAulas : Form
    {
        private List<GestionAulas> aulas;
        Conexion Conexion;
        private consultaAulas consultaAulas;
        private GestionAulas gestionAulas;
        int aulaId = 0;
        public FormAulas()
        {
            InitializeComponent();
            configTabla();

            aulas = new List<GestionAulas>();
            consultaAulas = new consultaAulas();
            gestionAulas = new GestionAulas();
            pnlBotonActualizar.Visible = false;
            CargarAulas();
        }
        private void configTabla()
        {
            // Configuración de la tabla
            dgvAulas.AllowUserToAddRows = false;

            dgvAulas.Columns.Add("id", "ID");
            dgvAulas.Columns.Add("nombre", "Nombre del aula");
            dgvAulas.Columns.Add("capacidad", "Capacidad");
            dgvAulas.Columns.Add("ubicacion", "Ubicación");

            // Establecer el modo de selección de filas
            dgvAulas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void CargarAulas(string filtro = "")
        {
            dgvAulas.Rows.Clear();
            dgvAulas.Refresh();
            aulas.Clear();
            aulas = consultaAulas.GetAulas(filtro);

            for (int i = 0; i < aulas.Count; i++)
            {
                dgvAulas.Rows.Add
                    (aulas[i].id,
                    aulas[i].nombre,
                    aulas[i].capacidad,
                    aulas[i].ubicacion);
            }
        }
        private void GuardarAula()
        {
            gestionAulas.nombre = txtNombreAula.Text;
            gestionAulas.capacidad = int.Parse(txtCapacidad.Text);
            gestionAulas.ubicacion = txtUbicacion.Text;

            if (consultaAulas.AgregarAula(gestionAulas))
            {
                MessageBox.Show("Aula agregada correctamente");
                CargarAulas();
                LimpiarCampos();
            }

        }
        private void LimpiarCampos()
        {
            txtNombreAula.Clear();
            txtCapacidad.Clear();
            txtUbicacion.Clear();
        }
        private void EliminarAulas()
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar esta aula?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (dgvAulas.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dgvAulas.SelectedRows[0].Cells[0].Value);
                    if (consultaAulas.EliminarAula(id))
                    {
                        MessageBox.Show("Aula eliminado correctamente");
                        CargarAulas();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el aula");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un aula para eliminar");
                }
            }
        }
        private void EditarAula()
        {
            if (dgvAulas.SelectedRows.Count > 0)
            {
                aulaId = Convert.ToInt32(dgvAulas.SelectedRows[0].Cells[0].Value);
                txtNombreAula.Text = dgvAulas.SelectedRows[0].Cells[1].Value.ToString();
                txtCapacidad.Text = dgvAulas.SelectedRows[0].Cells[2].Value.ToString();
                txtUbicacion.Text = dgvAulas.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormMenuPrincipal formMenuPrincipal = new FormMenuPrincipal();
            formMenuPrincipal.Show();
            this.Hide();
        }

        private void FormAulas_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarAula();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarAulas();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            pnlBotonActualizar.Visible = true;
            EditarAula();
            btnLimpiar.Text = "Cancelar";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            gestionAulas.nombre = txtNombreAula.Text;
            gestionAulas.capacidad = int.Parse(txtCapacidad.Text);
            gestionAulas.ubicacion = txtUbicacion.Text;

            if (consultaAulas.EditarAula(gestionAulas, aulaId))
            {
                MessageBox.Show("Aula actualizada correctamente");
                CargarAulas();
                LimpiarCampos();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            pnlBotonActualizar.Visible = false;
            LimpiarCampos();
            btnLimpiar.Text = "Limpiar";
        }
    }
}
