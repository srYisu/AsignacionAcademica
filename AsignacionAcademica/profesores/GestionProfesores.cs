using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsignacionAcademica.profesores
{
    internal class GestionProfesores
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string especialidad { get; set; }
        public bool disponibilidad { get; set; }
    }
}
