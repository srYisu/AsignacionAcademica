using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsignacionAcademica
{
    internal class AbrirForms
    {
        public void AbrirFormPanel(System.Windows.Forms.Panel panelContenedor, Form formHijo)
        {
            // Cerrar y eliminar el formulario anterior
            if (panelContenedor.Controls.Count > 0)
            {
                var controlAnterior = panelContenedor.Controls[0] as Form;

                if (controlAnterior != null)
                {
                    controlAnterior.Close();
                    controlAnterior.Dispose();
                    panelContenedor.Controls.Remove(controlAnterior);
                }
            }

            // Configurar el nuevo formulario hijo
            formHijo.TopLevel = false; // Es necesario para embebido
            formHijo.FormBorderStyle = FormBorderStyle.None; // Sin bordes
            formHijo.Dock = DockStyle.Fill; // Ajustar al contenedor
            panelContenedor.Controls.Add(formHijo); // Agregar al panel
            panelContenedor.Tag = formHijo; // Etiquetar el panel
            formHijo.BringToFront(); // Asegurar que está al frente
            formHijo.Show(); // Mostrar
        }
    }
}
