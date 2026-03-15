using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacro_Examen_Parcial
{
    internal class Inscripciones
    {
        int dpiEstudiante;
        String tallerCodigo;
        DateTime fechaInscripcion;

        public int DpiEstudiante { get => dpiEstudiante; set => dpiEstudiante = value; }
        public string TallerCodigo { get => tallerCodigo; set => tallerCodigo = value; }
        public DateTime FechaInscripcion { get => fechaInscripcion; set => fechaInscripcion = value; }
    }
}
