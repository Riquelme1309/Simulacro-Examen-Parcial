using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacro_Examen_Parcial
{
    internal class Taller
    {
        String codigotaller;
        String nombreTaller;
        Decimal costo;

        public string Codigotaller { get => codigotaller; set => codigotaller = value; }
        public string NombreTaller { get => nombreTaller; set => nombreTaller = value; }
        public decimal Costo { get => costo; set => costo = value; }
    }
}
