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

        AbrirForms open = new AbrirForms();
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            FormProfesores formProfesores = new FormProfesores();
            open.AbrirFormPanel(this.pnlBase, formProfesores);
        }

        private void btnAulas_Click(object sender, EventArgs e)
        {
            FormAulas formAulas = new FormAulas();
            open.AbrirFormPanel(this.pnlBase, formAulas);
        }

        private void btnAsignaturas_Click(object sender, EventArgs e)
        {
            FormAsignaturas formAsignaturas = new FormAsignaturas();
            open.AbrirFormPanel(this.pnlBase, formAsignaturas);
        }

        private void btnGrupos_Click(object sender, EventArgs e)
        {
            FormGrupos formGrupos = new FormGrupos();
            open.AbrirFormPanel(this.pnlBase, formGrupos);
        }

        private void btnAsignarClases_Click(object sender, EventArgs e)
        {
            FormAsignaciones formAsignarClases = new FormAsignaciones();
            open.AbrirFormPanel(this.pnlBase, formAsignarClases);
        }

        private void btnConsultarAsignaciones_Click(object sender, EventArgs e)
        {
            FormConsultaAsignaciones formConsultarAsignaciones = new FormConsultaAsignaciones();
            open.AbrirFormPanel(this.pnlBase, formConsultarAsignaciones);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
