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
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            FormProfesores formProfesores = new FormProfesores();
            formProfesores.Show();
            this.Hide();
        }

        private void btnAulas_Click(object sender, EventArgs e)
        {
            FormAulas formAulas = new FormAulas();
            formAulas.Show();
            this.Hide();
        }

        private void btnAsignaturas_Click(object sender, EventArgs e)
        {
            FormAsignaturas formAsignaturas = new FormAsignaturas();
            formAsignaturas.Show();
            this.Hide();
        }

        private void btnGrupos_Click(object sender, EventArgs e)
        {
            FormGrupos formGrupos = new FormGrupos();
            formGrupos.Show();
            this.Hide();
        }

        private void btnAsignarClases_Click(object sender, EventArgs e)
        {
            FormAsignaciones formAsignarClases = new FormAsignaciones();
            formAsignarClases.Show();
            this.Hide();
        }

        private void btnConsultarAsignaciones_Click(object sender, EventArgs e)
        {
            FormConsultaAsignaciones formConsultarAsignaciones = new FormConsultaAsignaciones();
            formConsultarAsignaciones.Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
